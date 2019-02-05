using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class RsoAuth
    {
        public static class V1
        {
            public static class Authorization
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/rso-auth/v1/authorization");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RsoAuthAuthorization> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RsoAuthAuthorization>("GET", "/rso-auth/v1/authorization");

                public static class AccessToken
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthAccessToken> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthAccessToken>("GET", "/rso-auth/v1/authorization/access-token");
                }

                public static class EntitlementsToken
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthEntitlementsToken> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthEntitlementsToken>("GET",
                            "/rso-auth/v1/authorization/entitlements-token");
                }

                public static class Error
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthAuthError> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthAuthError>("GET", "/rso-auth/v1/authorization/error");
                }

                public static class Gas
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="creds"></param>
                    /// <returns></returns>
                    public static Task<RsoAuthAuthorization> Post(LeagueClientSession session,
                        RsoAuthRSOPlayerCredentials creds) =>
                        session.SendRequestAsync<RsoAuthAuthorization>("POST", "/rso-auth/v1/authorization/gas",
                            body: creds);
                }

                public static class GasToken
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("GET", "/rso-auth/v1/authorization/gas-token");
                }

                public static class IdToken
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthIdToken> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthIdToken>("GET", "/rso-auth/v1/authorization/id-token");
                }

                public static class Refresh
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthAuthorization> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthAuthorization>("POST", "/rso-auth/v1/authorization/refresh");
                }

                public static class UserInfo
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthUserInfo> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthUserInfo>("GET", "/rso-auth/v1/authorization/userinfo");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<RsoAuthUserInfo> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<RsoAuthUserInfo>("POST", "/rso-auth/v1/authorization/userinfo");
                }
            }

            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/rso-auth/v1/config");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="config"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, RsoAuthRSOJWTConfig config) =>
                    session.SendRequestAsync("POST", "/rso-auth/v1/config", body: config);


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="config"></param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, RsoAuthRSOJWTConfig config) =>
                    session.SendRequestAsync("PUT", "/rso-auth/v1/config", body: config);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="platformId"></param>
                /// <returns></returns>
                public static Task<RsoAuthRSOJWTConfig> Get(LeagueClientSession session, string platformId) =>
                    session.SendRequestAsync<RsoAuthRSOJWTConfig>("GET", $"/rso-auth/v1/config/{platformId}");
            }

            public static class DeviceId
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RsoAuthDeviceId> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<RsoAuthDeviceId>("POST", "/rso-auth/v1/device-id");
            }

            public static class Status
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="platformId"></param>
                /// <returns></returns>
                public static Task<RsoAuthRegionStatus> Get(LeagueClientSession session, string platformId) =>
                    session.SendRequestAsync<RsoAuthRegionStatus>("GET", $"/rso-auth/v1/status/{platformId}");
            }
        }

        public static class V2
        {
            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/rso-auth/v2/config");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="config"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, RsoAuthPublicClientConfig config) =>
                    session.SendRequestAsync("POST", "/rso-auth/v2/config", body: config);
            }
        }
    }
}