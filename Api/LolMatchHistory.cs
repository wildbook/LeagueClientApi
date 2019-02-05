using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolMatchHistory
    {
        public static class V1
        {
            public static class Delta
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMatchHistoryMatchHistoryPlayerDelta> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMatchHistoryMatchHistoryPlayerDelta>("GET",
                        "/lol-match-history/v1/delta");
            }

            public static class FriendMatchlists
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <returns></returns>
                public static Task<LolMatchHistoryMatchHistoryList> Get(LeagueClientSession session, long accountId) =>
                    session.SendRequestAsync<LolMatchHistoryMatchHistoryList>("GET",
                        $"/lol-match-history/v1/friend-matchlists/{accountId}");
            }

            public static class GameTimelines
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="gameId"></param>
                /// <returns></returns>
                public static Task<LolMatchHistoryMatchHistoryTimelineFrames>
                    Get(LeagueClientSession session, long gameId) =>
                    session.SendRequestAsync<LolMatchHistoryMatchHistoryTimelineFrames>("GET",
                        $"/lol-match-history/v1/game-timelines/{gameId}");
            }

            public static class Games
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="gameId"></param>
                /// <returns></returns>
                public static Task<LolMatchHistoryMatchHistoryGame> Get(LeagueClientSession session, long gameId) =>
                    session.SendRequestAsync<LolMatchHistoryMatchHistoryGame>("GET",
                        $"/lol-match-history/v1/games/{gameId}");
            }

            public static class Matchlist
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMatchHistoryMatchHistoryList> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMatchHistoryMatchHistoryList>("GET", "/lol-match-history/v1/matchlist");
            }

            public static class RecentlyPlayedSummoners
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMatchHistoryRecentlyPlayedSummoner[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMatchHistoryRecentlyPlayedSummoner[]>("GET",
                        "/lol-match-history/v1/recently-played-summoners");
            }

            public static class WebUrl
            {
                //TODO: string?
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-match-history/v1/web-url");
            }
        }
    }
}