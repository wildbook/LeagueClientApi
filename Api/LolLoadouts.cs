using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;
using Newtonsoft.Json;

namespace LeagueClientApi.Api
{
    public static class LolLoadouts
    {
        public static class V1
        {
            public static class Inventory
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="inventoryTypes"></param>
                /// <returns></returns>
                public static Task<LolLoadoutsFrontendInventoryResponse> Get(LeagueClientSession session,
                    string[] inventoryTypes) =>
                    session.SendRequestAsync<LolLoadoutsFrontendInventoryResponse>("GET", "/lol-loadouts/v1/inventory",
                        new Dictionary<string, string>
                        {
                            {"inventoryTypes", JsonConvert.SerializeObject(inventoryTypes)}
                        });
            }

            public static class Loadout
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="loadout"></param>
                /// <returns></returns>
                public static Task<LolLoadoutsLoadout> Post(LeagueClientSession session, LolLoadoutsLoadout loadout) =>
                    session.SendRequestAsync<LolLoadoutsLoadout>("POST", "/lol-loadouts/v1/loadout", body: loadout);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="loadout"></param>
                /// <returns></returns>
                public static Task<LolLoadoutsLoadout> Put(LeagueClientSession session, LolLoadoutsLoadout loadout) =>
                    session.SendRequestAsync<LolLoadoutsLoadout>("PUT", "/lol-loadouts/v1/loadout", body: loadout);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-loadouts/v1/loadout/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLoadoutsLoadout> Get(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<LolLoadoutsLoadout>("GET", $"/lol-loadouts/v1/loadout/{id}");
            }

            public static class SendToMegaPacket
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("POST", $"/lol-loadouts/v1/sendToMegaPacket/{id}");
            }

            public static class SendItemsToMegaPacket
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("POST", $"/lol-loadouts/v1/sendItemsToMegaPacket/{id}");
            }
        }

        public static class V2
        {
            public static class Items
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="inventoryType"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, int id, string inventoryType) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-loadouts/v2/items/{id}",
                        new Dictionary<string, string> {{"inventoryType", inventoryType}});

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="items"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, int id, dynamic items) =>
                    session.SendRequestAsync<dynamic>("POST", $"/lol-loadouts/v2/items/{id}", body: items);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="inventoryType"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, int id, string inventoryType) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-loadouts/v2/items/{id}/{inventoryType}");
            }
        }
    }
}