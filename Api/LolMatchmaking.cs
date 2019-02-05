using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolMatchmaking
    {
        public static class V1
        {
            public static class ReadyCheck
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMatchmakingMatchmakingReadyCheckResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMatchmakingMatchmakingReadyCheckResource>("GET",
                        "/lol-matchmaking/v1/ready-check");

                public static class Accept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-matchmaking/v1/ready-check/accept");
                }

                public static class Decline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-matchmaking/v1/ready-check/decline");
                }
            }

            public static class Search
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/lol-matchmaking/v1/search");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMatchmakingMatchmakingSearchResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMatchmakingMatchmakingSearchResource>("GET",
                        "/lol-matchmaking/v1/search");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-matchmaking/v1/search");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="search"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session,
                    LolMatchmakingMatchmakingSearchResource search) =>
                    session.SendRequestAsync<dynamic>("PUT", "/lol-matchmaking/v1/search", body: search);

                public static class Errors
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolMatchmakingMatchmakingSearchErrorResource> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolMatchmakingMatchmakingSearchErrorResource>("GET",
                            "/lol-matchmaking/v1/search/errors");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolMatchmakingMatchmakingSearchErrorResource> Get(LeagueClientSession session, int id) =>
                        session.SendRequestAsync<LolMatchmakingMatchmakingSearchErrorResource>("GET",
                            $"/lol-matchmaking/v1/search/errors/{id}");
                }
            }
        }
    }
}