using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolSuggestedPlayers
    {
        public static class V1
        {
            public static class ReportedPlayer
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="resource"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session,
                    LolSuggestedPlayersSuggestedPlayersReportedPlayer resource) => session.SendRequestAsync("POST",
                    "/lol-suggested-players/v1/reported-player", body: resource);
            }

            public static class SuggestedPlayers
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolSuggestedPlayersSuggestedPlayersSuggestedPlayer[]>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolSuggestedPlayersSuggestedPlayersSuggestedPlayer[]>("GET",
                        "/lol-suggested-players/v1/suggested-players");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerId"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long summonerId) =>
                    session.SendRequestAsync<dynamic>("DELETE",
                        $"/lol-suggested-players/v1/suggested-players/{summonerId}");
            }

            public static class VictoriousComrade
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="resource"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session,
                    LolSuggestedPlayersSuggestedPlayersVictoriousComrade resource) => session.SendRequestAsync("POST",
                    "/lol-suggested-players/v1/victorious-comrade", body: resource);
            }
        }
    }
}