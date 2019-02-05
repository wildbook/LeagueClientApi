using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolMissions
    {
        public static class V1
        {
            public static class Missions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlayerMissionDTO[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlayerMissionDTO[]>("GET", "/lol-missions/v1/missions");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-missions/v1/missions");

                public static class Update
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) =>
                        session.SendRequestAsync("POST", "/lol-missions/v1/missions/update");
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="missionId"></param>
                /// <returns></returns>
                public static Task<PlayerMissionDTO> Get(LeagueClientSession session, string missionId) =>
                    session.SendRequestAsync<PlayerMissionDTO>("GET", $"/lol-missions/v1/missions/{missionId}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="missionId"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string missionId) =>
                    session.SendRequestAsync("POST", $"/lol-missions/v1/missions/{missionId}");
            }

            public static class Series
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<SeriesDTO[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<SeriesDTO[]>("GET", "/lol-missions/v1/series");
            }
        }

        public static class V2
        {
            public static class Missions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="missionIds"></param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, MissionIdsDTO missionIds) =>
                    session.SendRequestAsync("PUT", "/lol-missions/v2/missions", body: missionIds);
            }
        }
    }
}