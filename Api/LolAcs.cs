using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolAcs
    {
        public static class V1
        {
            public static class Delta
            {
                /// <summary></summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <param name="force"></param>
                /// <returns></returns>
                public static Task<LolAcsAcsChampionGamesCollection> Get(LeagueClientSession session, long accountId,
                    bool force)
                {
                    var query = new Dictionary<string, string> {{"force", force.ToString()}};
                    return session.SendRequestAsync<LolAcsAcsChampionGamesCollection>("GET",
                        $"/lol-acs/v1/recently-played-champions/{accountId}", query);
                }
            }

            public static class Games
            {
                /// <summary></summary>
                /// <param name="session">The session object</param>
                /// <param name="gameId"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, long gameId) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-acs/v1/games/{gameId}");
            }

            public static class GameTimelines
            {
                /// <summary></summary>
                /// <param name="session">The session object</param>
                /// <param name="gameId"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, long gameId) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-acs/v1/gametimelines/{gameId}");
            }

            public static class Matchlists
            {
                /// <summary></summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, long accountId) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-acs/v1/matchlists/{accountId}");
            }

            public static class RecentlyPlayedChampions
            {
                /// <summary></summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <returns></returns>
                public static Task<LolAcsAcsChampionGamesCollection> Get(LeagueClientSession session,
                    long accountId) =>
                    session.SendRequestAsync<LolAcsAcsChampionGamesCollection>("GET",
                        $"/lol-acs/v1/recently-played-champions/{accountId}");
            }

            public static class AcsEndpointOverride
            {
                /// <summary></summary>
                /// <param name="session">The session object</param>
                /// <param name="data"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, LolAcsAcsEndPoint data) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-acs/v1/acs-endpoint-override", body: data);
            }
        }

        public static class V2
        {
            public static class RecentlyPlayedChampions
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <returns></returns>
                public static Task<LolAcsAcsChampionGamesCollection> Get(LeagueClientSession session,
                    long accountId) =>
                    session.SendRequestAsync<LolAcsAcsChampionGamesCollection>("GET",
                        $"/lol-acs/v2/recently-played-champions/{accountId}");
            }

            public static class RequestRecentlyPlayedChampions
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <param name="force"></param>
                /// <returns></returns>
                public static Task Get(LeagueClientSession session, long accountId,
                    bool force)
                {
                    var query = new Dictionary<string, string> {{"force", force.ToString()}};
                    return session.SendRequestAsync("GET", $"/lol-acs/v2/request-recently-played-champions/{accountId}",
                        query);
                }
            }
        }
    }
}