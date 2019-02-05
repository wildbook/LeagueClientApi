using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Builtin
    {
        public static class AsyncDelete
        {
            /// <summary>
            /// Cancels the asynchronous operation or removes its completion status.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="asyncToken">ID of the asynchronous operation to remove</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, int asyncToken)
            {
                var query = new Dictionary<string, string> { { "asyncToken", asyncToken.ToString() } };
                return session.SendRequestAsync<dynamic>("POST", "/AsyncDelete", query);
            }
        }

        public static class AsyncResult
        {
            /// <summary>
            /// Retrieves the result of a completed asynchronous operation.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="asyncToken">ID of the asynchronous operation to check</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, int asyncToken)
            {
                var query = new Dictionary<string, string> { { "asyncToken", asyncToken.ToString() } };
                return session.SendRequestAsync<dynamic>("POST", "/AsyncResult", query);
            }
        }

        public static class AsyncStatus
        {
            /// <summary>
            /// Retrieves details on the current state of an asynchronous operation.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="asyncToken">ID of the asynchronous operation to check</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, int asyncToken)
            {
                var query = new Dictionary<string, string> { { "asyncToken", asyncToken.ToString() } };
                return session.SendRequestAsync<dynamic>("POST", "/AsyncStatus", query);
            }
        }

        public static class Cancel
        {
            /// <summary>
            /// Cancels the asynchronous operation or removes its completion status.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="asyncToken">Operation to cancel</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, int asyncToken)
            {
                var query = new Dictionary<string, string> { { "asyncToken", asyncToken.ToString() } };
                return session.SendRequestAsync<dynamic>("POST", "/Cancel", query);
            }
        }

        public static class Exit
        {
            /// <summary>
            /// Cancels the asynchronous operation or removes its completion status.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session) =>
                session.SendRequestAsync<dynamic>("POST", "/Exit");
        }

        public static class Help
        {
            /// <summary>
            /// Returns information on available functions and types
            ///
            /// With no arguments, returns a list of all available functions and types along with a short description. If a function or type is specified, returns detailed information about it.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="target">Name of the function or type to describe</param>
            /// <param name="format">Format for returned information</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, string target,
                RemotingHelpFormat? format = null)
            {
                var query = new Dictionary<string, string> { { "target", target } };
                if (format.HasValue) query.Add("format", format.ToString());
                return session.SendRequestAsync<dynamic>("POST", "/Help", query);
            }
        }

        public static class Subscribe
        {
            /// <summary>
            /// Subscribes to a given event
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="eventName">Name of the event to subscribe to</param>
            /// <param name="format">Desired format to receive events in. If unspecified, events will be sent in the active result format at the time.</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, string eventName,
                RemotingSerializedFormat? format = null)
            {
                var query = new Dictionary<string, string> { { "eventName", eventName } };
                if (format.HasValue) query.Add("format", format.ToString());
                return session.SendRequestAsync<dynamic>("POST", "/Subscribe", query);
            }
        }

        public static class Unsubscribe
        {
            /// <summary>
            /// Subscribes to a given event
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="eventName">Name of the event to subscribe to</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, string eventName)
            {
                var query = new Dictionary<string, string> { { "eventName", eventName } };
                return session.SendRequestAsync<dynamic>("POST", "/Unsubscribe", query);
            }
        }

        public static class WebSocketFormat
        {
            /// <summary>
            /// Controls the console output format
            ///
            /// With no arguments, returns the current output format being used. If a format is specified, switches the console output to that format.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="target">Name of the function or type to describe</param>
            /// <param name="format">Format for returned information</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, string target,
                RemotingSerializedFormat? format)
            {
                var query = new Dictionary<string, string> { { "target", target } };
                if (format.HasValue) query.Add("format", format.ToString());
                return session.SendRequestAsync<dynamic>("POST", "/WebSocketFormat", query);
            }
        }

        public static class Async
        {
            public static class V1
            {
                public static class Result
                {
                    /// <summary>
                    /// Retrieves the result of a completed asynchronous operation.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="asyncToken">ID of the asynchronous operation to check</param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session, int asyncToken) =>
                        session.SendRequestAsync<dynamic>("GET", $"/async/v1/result/{asyncToken}");
                }

                public static class Status
                {
                    /// <summary>
                    /// Retrieves details on the current state of an asynchronous operation.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="asyncToken">ID of the asynchronous operation to check</param>
                    /// <returns></returns>
                    public static Task<dynamic> Delete(LeagueClientSession session, int asyncToken) =>
                        session.SendRequestAsync<dynamic>("DELETE", $"/async/v1/status/{asyncToken}");

                    /// <summary>
                    /// Retrieves details on the current state of an asynchronous operation.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="asyncToken">ID of the asynchronous operation to check</param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session, int asyncToken) =>
                        session.SendRequestAsync<dynamic>("GET", $"/async/v1/status/{asyncToken}");
                }
            }
        }

        public static class V1
        {
            public static class ApiDocs
            {
                /// <summary>
                /// Retrieves the API documentation resource listing
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/v1/api-docs");

                /// <summary>
                /// Retrieves the API declaration for a supported API
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="api">API to get a declaration for</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string api) =>
                    session.SendRequestAsync<dynamic>("GET", $"/v1/api-docs/{api}");
            }
        }

        public static class V2
        {
            public static class SwaggerJson
            {
                /// <summary>
                /// Retrieves the API documentation
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/v2/swagger.json");
            }
        }

        public static class V3
        {
            public static class OpenApi
            {
                /// <summary>
                /// Retrieves the API documentation
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/v3/openapi.json");
            }
        }
    }
}