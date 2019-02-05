using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Maps
    {
        public static class V1
        {
            public static class Map
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="map"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, LolMapsMaps map) =>
                    session.SendRequestAsync("POST", "/lol-maps/v1/map", body: map);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMapsMaps> Get(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<LolMapsMaps>("GET", $"/lol-maps/v1/map/{id}");
            }

            public static class Maps
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMapsMaps[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMapsMaps[]>("GET", "/lol-maps/v1/maps");
            }
        }

        public static class V2
        {
            public static class Map
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMapsMaps> Get(LeagueClientSession session, long id, string gameMode) =>
                    session.SendRequestAsync<LolMapsMaps>("GET", $"/lol-maps/v2/map/{id}/{gameMode}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMapsMaps> Get(LeagueClientSession session, long id, string gameMode,
                    string gameMutator) =>
                    session.SendRequestAsync<LolMapsMaps>("GET", $"/lol-maps/v2/map/{id}/{gameMode}/{gameMutator}");
            }

            public static class Maps
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolMapsMaps[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolMapsMaps[]>("GET", "/lol-maps/v2/maps");
            }
        }
    }
}