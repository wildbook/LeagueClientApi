using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolRiotMessagingService
    {
        public static class V1
        {
            public static class Connect
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/riot-messaging-service/v1/connect");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="idToken"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string idToken) =>
                    session.SendRequestAsync("POST", "/riot-messaging-service/v1/connect", body: idToken);
            }

            public static class Reconnect
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/riot-messaging-service/v1/reconnect");
            }

            public static class Session
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/riot-messaging-service/v1/session");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RiotMessagingServiceSession> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RiotMessagingServiceSession>("GET", "/riot-messaging-service/v1/session");
            }

            public static class State
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RiotMessagingServiceState> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RiotMessagingServiceState>("GET", "/riot-messaging-service/v1/state");
            }
        }
    }
}