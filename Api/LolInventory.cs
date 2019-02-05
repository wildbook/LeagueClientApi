using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;
using Newtonsoft.Json;

namespace LeagueClientApi.Api
{
    public static class LolInventory
    {
        public static class V1
        {
            public static class Inventory
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="inventoryTypes">At least one required.</param>
                /// <returns></returns>
                public static Task<LolInventoryInventoryItem>
                    Get(LeagueClientSession session, string[] inventoryTypes) =>
                    session.SendRequestAsync<LolInventoryInventoryItem>("GET", "/lol-inventory/v1/inventory",
                        new Dictionary<string, string>
                        {
                            {"inventoryTypes", JsonConvert.SerializeObject(inventoryTypes)}
                        });

                public static class Emotes
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolInventoryInventoryItem> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolInventoryInventoryItem>("GET",
                            "/lol-inventory/v1/inventory/emotes");
                }
            }

            public static class SignedInventory
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="inventoryTypes">At least one required.</param>
                /// <returns></returns>
                public static Task<LolInventoryInventoryItem>
                    Get(LeagueClientSession session, string[] inventoryTypes) =>
                    session.SendRequestAsync<LolInventoryInventoryItem>("GET", "/lol-inventory/v1/signedInventory",
                        new Dictionary<string, string>
                        {
                            {"inventoryTypes", JsonConvert.SerializeObject(inventoryTypes)}
                        });
            }
        }
    }
}