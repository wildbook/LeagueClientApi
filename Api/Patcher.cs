using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Patcher
    {
        public static class V1
        {
            public static class ExecutableVersion
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string>("GET", "/patcher/v1/executable-version");
            }

            public static class Notifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PatcherNotification[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PatcherNotification[]>("GET", "/patcher/v1/notifications");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="notificationId"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, PatcherNotificationId notificationId) =>
                    session.SendRequestAsync("POST", "/plugin-name/endpoint",
                        new Dictionary<string, string> {{"notificationId", notificationId.ToString()}});


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/patcher/v1/notifications/{id}");
            }

            public static class P2P
            {
                public static class Status
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<PatcherP2PStatus> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<PatcherP2PStatus>("GET", "/patcher/v1/p2p/status");


                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="data"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Patch(LeagueClientSession session, PatcherP2PStatusUpdate data) =>
                        session.SendRequestAsync<dynamic>("PATCH", "/patcher/v1/p2p/status", body: data);
                }
            }

            public static class Products
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string[]>("GET", "/patcher/v1/products");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="productId"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string productId) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/patcher/v1/products/{productId}");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="productId"></param>
                /// <param name="data"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, string productId,
                    PatcherProductResource data) =>
                    session.SendRequestAsync<dynamic>("PUT", $"/patcher/v1/products/{productId}", body: data);

                public static class DetectCorruptionRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<PatcherProductState> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<PatcherProductState>("POST",
                            $"/patcher/v1/products/{productId}/detect-corruption-request");
                }

                public static class FullRepairRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/full-repair-request");
                }

                public static class InjectError
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <param name="componentId"></param>
                    /// <param name="error"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string productId,
                        string componentId, PatcherInjectedPatcherError error) =>
                        session.SendRequestAsync("POST",
                            $"/patcher/v1/products/{productId}/inject-error",
                            new Dictionary<string, string>
                            {
                                {"component-id", componentId},
                                {"error", error.ToString()}
                            });
                }

                public static class PartialRepairRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/partial-repair-request");
                }

                public static class Paths
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("GET",
                            $"/patcher/v1/products/{productId}/paths");
                }

                public static class SignalStartPatchingDelayed
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/signal-start-patching-delayed");
                }

                public static class StartCheckingRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/start-checking-request");
                }

                public static class StartPatchingRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/start-patching-request");
                }

                public static class State
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<PatcherProductState> Get(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<PatcherProductState>("GET",
                            $"/patcher/v1/products/{productId}/state");
                }

                public static class StopCheckingRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/stop-checking-request");
                }

                public static class StopPatchingRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/patcher/v1/products/{productId}/stop-patching-request");
                }

                public static class Tags
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session, string productId) =>
                        session.SendRequestAsync<dynamic>("GET",
                            $"/patcher/v1/products/{productId}/tags");
                }

                public static class HttpHeaders
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <param name="componentId"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Delete(LeagueClientSession session, string productId,
                        string componentId) => session.SendRequestAsync<dynamic>("DELETE",
                        $"/patcher/v1/products/{productId}/{componentId}/http-headers");


                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="productId"></param>
                    /// <param name="componentId"></param>
                    /// <param name="headers"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Put(LeagueClientSession session, string productId, string componentId,
                        PatcherHeaderEntry[] headers) => session.SendRequestAsync<dynamic>("PUT",
                        $"/patcher/v1/products/{productId}/{componentId}/http-headers", body: headers);
                }
            }

            public static class SelfUpdateRestart
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="forceRestartOnSelfUpdate"></param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, bool forceRestartOnSelfUpdate) =>
                    session.SendRequestAsync("PUT", "/patcher/v1/self-update-restart",
                        new Dictionary<string, string>
                        {
                            {"forceRestartOnSelfUpdate", forceRestartOnSelfUpdate.ToString()}
                        });
            }

            public static class Status
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PatcherStatus> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PatcherStatus>("GET", "/patcher/v1/status");
            }
        }
    }
}