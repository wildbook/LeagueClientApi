using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolSpectator
    {
        public static class V1
        {
            public static class Buddy
            {
                public static class Spectate
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerOrTeamNames"></param>
                    /// <returns></returns>
                    public static Task<SummonerOrTeamAvailabilty>
                        Post(LeagueClientSession session, string[] summonerOrTeamNames) =>
                        session.SendRequestAsync<SummonerOrTeamAvailabilty>("POST", "/lol-spectator/v1/buddy/spectate",
                            body: summonerOrTeamNames);
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-kr-playtime-reminder/v1/message");
            }

            public static class Spectate
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<SpectateGameInfo> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<SpectateGameInfo>("GET", "/lol-spectator/v1/spectate");

                public static class Launch
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="specateGameInfo"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, SpectateGameInfo specateGameInfo) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-spectator/v1/spectate/launch",
                            body: specateGameInfo);
                }
            }
        }
    }
}