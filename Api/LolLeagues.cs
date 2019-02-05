using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;
using Newtonsoft.Json;

namespace LeagueClientApi.Api
{
    public static class LolLeagues
    {
        public static class V1
        {
            public static class ChallangerLeagues
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLeaguesApexLeagues> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLeaguesApexLeagues>("GET", "/lol-leagues/v1/challenger-leagues");
            }

            public static class SummonerLeagues
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerId"></param>
                /// <returns></returns>
                public static Task<LolLeaguesLeague[]> Get(LeagueClientSession session, long summonerId) =>
                    session.SendRequestAsync<LolLeaguesLeague[]>("GET",
                        $"/lol-leagues/v1/summoner-leagues/{summonerId}");
            }

            public static class SummonerTopChamps
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerId"></param>
                /// <returns></returns>
                public static Task<LolLeaguesLeagueChampAndStat[]> Get(LeagueClientSession session, long summonerId) =>
                    session.SendRequestAsync<LolLeaguesLeagueChampAndStat[]>("GET",
                        $"/lol-leagues/v1/summoner-top-champs/{summonerId}");
            }

            public static class Teams
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolLeaguesLeagueTeam> Get(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<LolLeaguesLeagueTeam>("GET", $"/lol-leagues/v1/teams/{id}");
            }
        }

        public static class V2
        {
            public static class Notifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLeaguesLeaguesNotification[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLeaguesLeaguesNotification[]>("GET", "/lol-leagues/v2/notifications");

                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-leagues/v2/notifications/{id}/acknowledge");
                }
            }

            public static class SummonerLeagues
            {
                public static class CurrentSummoner
                {
                    public static class SignedLeagues
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLeaguesSignedSummonerLeagueItemsDTO> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLeaguesSignedSummonerLeagueItemsDTO>("GET",
                                "/lol-leagues/v2/summoner-leagues/current-summoner/signed-leagues");
                    }
                }
            }

            public static class Tiers
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerIds"></param>
                /// <param name="queueTypes"></param>
                /// <returns></returns>
                public static Task<LolLeaguesParticipantTiers[]> Get(LeagueClientSession session, long[] summonerIds,
                    LolLeaguesLeagueQueueType[] queueTypes) => session.SendRequestAsync<LolLeaguesParticipantTiers[]>(
                    "GET", "/lol-leagues/v2/tiers", new Dictionary<string, string>
                    {
                        {"summonerIds", JsonConvert.SerializeObject(summonerIds)},
                        {"queueTypes", JsonConvert.SerializeObject(queueTypes)}
                    });
            }
        }
    }
}