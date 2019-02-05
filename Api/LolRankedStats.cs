using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolRankedStats
    {
        public static class V1
        {
            public static class Stats
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolRankedStatsRankedData> Get(LeagueClientSession session, long summonerId) =>
                    session.SendRequestAsync<LolRankedStatsRankedData>("GET",
                        $"/lol-ranked-stats/v1/stats/{summonerId}");
            }

            public static class Status
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolRankedStatsPluginStatus> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolRankedStatsPluginStatus>("GET", "/lol-ranked-stats/v1/status");
            }
        }
    }
}