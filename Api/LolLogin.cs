using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLogin
    {
        public static class V1
        {
            public static class AccessToken
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="AccessToken"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, LolLoginAccessToken AccessToken) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-login/v1/access-token", body: AccessToken);
            }

            public static class AccountState
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLoginAccountStateResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLoginAccountStateResource>("GET", "/lol-login/v1/account-state");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-login/v1/account-state");
            }

            public static class ChangeSummonerName
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="name"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, string name) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-login/v1/change-summoner-name", body: name);
            }

            public static class LoginDataPacket
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-login/v1/login-data-packet");
            }

            public static class LoginInGameCreds
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-login/v1/login-in-game-creds");
            }

            public static class LoginPlatformCredentials
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLoginPlatformGeneratedCredentials> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLoginPlatformGeneratedCredentials>("GET",
                        "/lol-login/v1/login-platform-credentials");
            }

            public static class NewPlayerFlowCompleted
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-login/v1/new-player-flow-completed");
            }

            public static class ServiceProxyAsyncRequest
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="serviceName"></param>
                /// <param name="methodName"></param>
                /// <param name="pluginId"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string serviceName, string methodName,
                    int pluginId) => session.SendRequestAsync<dynamic>("DELETE",
                    $"/lol-login/v1/service-proxy-async-requests/{serviceName}/{methodName}",
                    new Dictionary<string, string> {{"pluginId", pluginId.ToString()}});

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="serviceName"></param>
                /// <param name="methodName"></param>
                /// <param name="pluginId"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, string serviceName, string methodName,
                    int pluginId) => session.SendRequestAsync<dynamic>("POST",
                    $"/lol-login/v1/service-proxy-async-requests/{serviceName}/{methodName}",
                    new Dictionary<string, string> {{"pluginId", pluginId.ToString()}});
            }

            public static class ServiceProxyMethodRequest
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="serviceName"></param>
                /// <param name="methodName"></param>
                /// <param name="responseMethodName"></param>
                /// <param name="responseErrorName"></param>
                /// <param name="pluginId"></param>
                /// <param name="payload"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string serviceName, string methodName,
                    string responseMethodName, string responseErrorName, int pluginId, string payload) =>
                    session.SendRequestAsync("POST", "/lol-login/v1/service-proxy-method-requests",
                        new Dictionary<string, string>
                        {
                            {"serviceName", serviceName},
                            {"methodName", methodName},
                            {"responseMethodName", responseErrorName},
                            {"responseErrorName", responseErrorName},
                            {"pluginId", pluginId.ToString()},
                            {"payload", payload}
                        });
            }

            public static class ServiceProxyUuidRequests
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="serviceName"></param>
                /// <param name="methodName"></param>
                /// <param name="pluginId"></param>
                /// <param name="payload"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string serviceName, string methodName,
                    int pluginId, string payload) =>
                    session.SendRequestAsync("POST", "/lol-login/v1/service-proxy-uuid-requests",
                        new Dictionary<string, string>
                        {
                            {"serviceName", serviceName},
                            {"methodName", methodName},
                            {"pluginId", pluginId.ToString()},
                            {"payload", payload}
                        });
            }

            public static class Session
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/lol-login/v1/session");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLoginLoginSession> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLoginLoginSession>("GET", "/lol-login/v1/session");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="usernameAndPassword"></param>
                /// <returns></returns>
                public static Task<LolLoginLoginSession> Post(LeagueClientSession session,
                    LolLoginUsernameAndPassword usernameAndPassword) =>
                    session.SendRequestAsync<LolLoginLoginSession>("POST", "/lol-login/v1/session",
                        body: usernameAndPassword);

                public static class Invoke
                {
                    //TODO: formData things, might need "serializeBody: false"
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="method"></param>
                    /// <param name="args"></param>
                    /// <param name="destination"></param>
                    /// <returns></returns>
                    public static Task<LolLoginLcdsResponse> Post(LeagueClientSession session, string destination,
                        string method, string args) => session.SendRequestAsync<LolLoginLcdsResponse>("POST",
                        "/lol-login/v1/session/invoke", new Dictionary<string, string>
                        {
                            {"destination", destination},
                            {"method", method}
                        }, body: "args=" + args);
                }
            }

            public static class ShutdownLocks
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="lockName"></param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session, string lockName) =>
                    session.SendRequestAsync("DELETE", $"/lol-login/v1/shutdown-locks/{lockName}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="lockName"></param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, string lockName) =>
                    session.SendRequestAsync("PUT", $"/lol-login/v1/shutdown-locks/{lockName}");
            }

            public static class SummonerCreated
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerId"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolLoginSummonerCreatedResource summonerId) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-login/v1/summoner-created", body: summonerId);
            }

            public static class Wallet
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLoginLoginSessionWallet> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLoginLoginSessionWallet>("GET", "/lol-login/v1/wallet");
            }
        }
    }
}