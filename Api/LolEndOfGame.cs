using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolEndOfGame
    {
        public static class V1
        {
            public static class ChampionMasteryUpdates
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolEndOfGameChampionMasteryUpdate>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolEndOfGameChampionMasteryUpdate>("GET",
                        "/lol-end-of-game/v1/champion-mastery-updates");
            }

            public static class EogStatsBlock
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolEndOfGameEndOfGameStats> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolEndOfGameEndOfGameStats>("GET", "/lol-end-of-game/v1/eog-stats-block");
            }

            public static class ReportedPlayers
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<int[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<int[]>("GET", "/lol-end-of-game/v1/reported-players");
            }

            public static class State
            {
                public static class DismissStats
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-end-of-game/v1/state/dismiss-stats");
                }
            }
        }

        public static class V2
        {
            public static class PlayerComplaints
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="complaint"></param>
                /// <returns></returns>
                public static Task<LolEndOfGameEndOfGamePlayerComplaintV2> Post(LeagueClientSession session,
                    LolEndOfGameEndOfGamePlayerComplaintV2 complaint) =>
                    session.SendRequestAsync<LolEndOfGameEndOfGamePlayerComplaintV2>("POST",
                        "/lol-end-of-game/v2/player-complaints", body: complaint);
            }
        }
    }
}