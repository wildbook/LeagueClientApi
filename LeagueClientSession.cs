using LeagueClientApi.Errors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebSocketSharp;

namespace LeagueClientApi
{
    public class LeagueClientSession : IDisposable
    {
        private readonly Dictionary<string, List<Action<LeagueEvent>>> _endpoints =
            new Dictionary<string, List<Action<LeagueEvent>>>();

        private readonly Lockfile _lockfileData;

        public LeagueClientSession(Lockfile lockfileData)
        {
            _lockfileData = lockfileData;
            ConnectWebSocket();
        }
        
        public event EventHandler<LeagueClientSession> OnSessionEnd;

        private WebSocket Socket { get; set; }

        public void Dispose()
        {
            OnSessionEnd?.Invoke(this, this);
            ((IDisposable)Socket)?.Dispose();
        }

        public void RegisterEndpoint(string endpointRegex, Action<LeagueEvent> action)
        {
            if (_endpoints.Keys.Contains(endpointRegex))
                _endpoints[endpointRegex].Add(action);
            else
                _endpoints.Add(endpointRegex, new List<Action<LeagueEvent>> { action });
        }

        public async Task<HttpResponseMessage> SendRequestAsync(string method, string endpoint,
            IEnumerable<KeyValuePair<string, string>> query = null,
            IEnumerable<KeyValuePair<string, string>> headers = null, object body = null, bool serializeBody = true) =>
            await SendValidHttpRequestAsync(method, endpoint, query, headers, body, serializeBody);

        public async Task<T> SendRequestAsync<T>(string method, string endpoint,
            IEnumerable<KeyValuePair<string, string>> query = null,
            IEnumerable<KeyValuePair<string, string>> headers = null, object body = null, bool serializeBody = true) =>
            JsonConvert.DeserializeObject<T>(
                await (await SendValidHttpRequestAsync(method, endpoint, query, headers, body, serializeBody)).Content
                    .ReadAsStringAsync());

        public async Task<HttpResponseMessage> SendValidHttpRequestAsync(string method, string endpoint,
            IEnumerable<KeyValuePair<string, string>> query = null,
            IEnumerable<KeyValuePair<string, string>> headers = null, object body = null, bool serializeBody = true, bool ensureSuccess = true)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpMethod = new HttpMethod(method.ToUpper());
            var requestUrl = new Uri($"https://localhost.:{_lockfileData.Port}{endpoint}");
            ServicePointManager.ServerCertificateValidationCallback =
                (sender, certificate, chain, sslPolicyErrors) => true; //certificate.Subject.Contains("CN=rclient");
                                                                       // I know this is a bad idea. There is probably a ton of better ways to do this.

            var client = new HttpClient();
            var request = new HttpRequestMessage(httpMethod, requestUrl);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes($"riot:{_lockfileData.Password}")));
            client.DefaultRequestHeaders.Host = $"127.0.0.1:{_lockfileData.Port}";

            var queryList = query as IList<KeyValuePair<string, string>> ?? query?.ToList();

            if (queryList?.Count > 0)
                request.RequestUri = new Uri(request.RequestUri + "?" +
                    await new FormUrlEncodedContent(queryList).ReadAsStringAsync());

            if (body != null)
                request.Content =
                    new StringContent(serializeBody ? JsonConvert.SerializeObject(body) : body.ToString(), Encoding.UTF8, "application/json");

            if (headers != null)
                foreach (var header in headers)
                    request.Headers.Add(header.Key, header.Value);

            var hrm = await client.SendAsync(request);

            if (hrm.IsSuccessStatusCode) return hrm;

            var contentRecieved = await hrm.Content.ReadAsStringAsync();
            var rpcError = JsonConvert.DeserializeObject<RiotException>(contentRecieved);
            if (rpcError != null)
                throw rpcError;
            throw new InvalidOperationException(contentRecieved);
        }

        public bool UnregisterEndpoint(string endpointRegex, Action<LeagueEvent> action) =>
            _endpoints.Keys.Contains(endpointRegex) && _endpoints[endpointRegex].Remove(action);

        public async Task<LeagueEvent> WaitForWebsocketDataAsync(string endpointRegex, LeagueEventType eventType)
        {
            var tcs = new TaskCompletionSource<LeagueEvent>();

            Action<LeagueEvent> action = null;

            RegisterEndpoint(endpointRegex, action = e =>
            {
                if (e.EventType != eventType && eventType != LeagueEventType.Any) return;
                tcs.SetResult(e);
                UnregisterEndpoint(endpointRegex, action);
            });

            return await tcs.Task;
        }
        
        private void ConnectWebSocket()
        {
            Socket = new WebSocket($"wss://localhost:{_lockfileData.Port}/", "wamp");
            Socket.SetCredentials("riot", _lockfileData.Password, true);
            Socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            //TODO: at least a bit of validation wouldn't hurt
            Socket.SslConfiguration.ServerCertificateValidationCallback = (a, b, c, d) => true;
            
            Socket.OnClose += (sender, e) => { Dispose(); };
            Socket.OnMessage += (sender, e) =>
            {
                var data = JsonConvert.DeserializeObject<dynamic>(e.Data);

                if ((long)data[0] != 8 || !((string)data[1]).Equals("OnJsonApiEvent")) return;

                var ev = data[2];
                var uri = (string)ev["uri"];

                var actionQueue = new Queue<Action<LeagueEvent>>();

                foreach (var endpoint in _endpoints)
                    if (Regex.IsMatch(uri, endpoint.Key))
                        endpoint.Value.ForEach(actionQueue.Enqueue);

                while (actionQueue.Count > 0)
                {
                    var eventType = Enum.TryParse((string)ev.eventType, out LeagueEventType type) ? type : LeagueEventType.Undefined;
                    actionQueue.Dequeue().Invoke(new LeagueEvent(ev.data, (string)ev.uri, eventType, ev));
                }
            };

            Socket.Connect();
            Socket.Send("[5,\"OnJsonApiEvent\"]");
        }
    }
}