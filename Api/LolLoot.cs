using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLoot
    {
        public static class V1
        {
            public static class CurrencyConfiguration
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Get(LeagueClientSession session) =>
                    session.SendRequestAsync("GET", "/lol-loot/v1/currency-configuration");
            }

            public static class Enabled
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-loot/v1/enabled");
            }

            public static class LootGrants
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLootLootGrantNotification[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLootLootGrantNotification[]>("GET", "/lol-loot/v1/loot-grants");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-loot/v1/loot-grants/{id}");
            }

            public static class LootItems
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLootLootItem[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLootLootItem[]>("GET", "/lol-loot/v1/loot-items");
            }

            public static class NewPlayerCheckDone
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-loot/v1/new-player-check-done");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="newValue"></param>
                /// <returns></returns>
                public static Task<string> Post(LeagueClientSession session, bool newValue) =>
                    session.SendRequestAsync<string>("POST", $"/lol-loot/v1/new-player-check-done/{newValue}");
            }

            public static class PlayerDisplayCategories
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string[]>("GET", "/lol-loot/v1/player-display-categories");
            }

            public static class PlayerLoot
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLootPlayerLoot[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLootPlayerLoot[]>("GET", "/lol-loot/v1/player-loot");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="lootId"></param>
                /// <returns></returns>
                public static Task<LolLootPlayerLoot> Get(LeagueClientSession session, string lootId) =>
                    session.SendRequestAsync<LolLootPlayerLoot>("GET", $"/lol-loot/v1/player-loot/{lootId}");

                public static class ContextMenu
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="lootId"></param>
                    /// <returns></returns>
                    public static Task<LolLootContextMenu[]> Get(LeagueClientSession session, string lootId) =>
                        session.SendRequestAsync<LolLootContextMenu[]>("GET",
                            $"/lol-loot/v1/player-loot/{lootId}/context-menu");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="lootId"></param>
                    /// <returns></returns>
                    public static Task<LolLootContextMenu[]> Post(LeagueClientSession session, string lootId) =>
                        session.SendRequestAsync<LolLootContextMenu[]>("POST",
                            $"/lol-loot/v1/player-loot/{lootId}/context-menu");
                }

                public static class NewNotification
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="lootId"></param>
                    /// <returns></returns>
                    public static Task<LolLootContextMenu[]> Delete(LeagueClientSession session, string lootId) =>
                        session.SendRequestAsync<LolLootContextMenu[]>("DELETE",
                            $"/lol-loot/v1/player-loot/{lootId}/new-notification");
                }

                public static class Redeem
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="lootName"></param>
                    /// <returns></returns>
                    public static Task<LolLootPlayerLootUpdate> Post(LeagueClientSession session, string lootName) =>
                        session.SendRequestAsync<LolLootPlayerLootUpdate>("POST",
                            $"/lol-loot/v1/player-loot/{lootName}/redeem");
                }
            }

            public static class PlayerLootMap
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-loot/v1/player-loot-map");
            }

            public static class PlayerLootNotifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLootPlayerLootNotification[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLootPlayerLootNotification[]>("GET",
                        "/lol-loot/v1/player-loot-notifications");

                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<string> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<string>("POST",
                            $"/lol-loot/v1/player-loot-notifications/{id}/acknowledge");
                }
            }

            public static class Ready
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-loot/v1/ready");
            }

            public static class Recipes
            {
                public static class Configuration
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Get(LeagueClientSession session) =>
                        session.SendRequestAsync("GET", "/lol-loot/v1/recipes/configuration");
                }

                public static class IninitalItem
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="lootId"></param>
                    /// <returns></returns>
                    public static Task<LolLootRecipe[]> Get(LeagueClientSession session, string lootId) =>
                        session.SendRequestAsync<LolLootRecipe[]>("GET", $"/lol-loot/v1/recipes/initial-item/{lootId}");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="lootId"></param>
                    /// <returns></returns>
                    public static Task<LolLootRecipe[]> Post(LeagueClientSession session, string lootId) =>
                        session.SendRequestAsync<LolLootRecipe[]>("POST",
                            $"/lol-loot/v1/recipes/initial-item/{lootId}");
                }

                public static class Craft
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="recipeName"></param>
                    /// <param name="playerLootList"></param>
                    /// <param name="repeat"></param>
                    /// <returns></returns>
                    public static Task<LolLootPlayerLootUpdate> Post(LeagueClientSession session, string recipeName,
                        string[] playerLootList, int? repeat = null)
                    {
                        var query = new Dictionary<string, string>();
                        if (repeat.HasValue) query.Add("repeat", repeat.ToString());

                        return session.SendRequestAsync<LolLootPlayerLootUpdate>("POST",
                            $"/lol-loot/v1/recipes/{recipeName}/craft", query, body: playerLootList);
                    }
                }
            }

            public static class Refresh
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="force"></param>
                /// <returns></returns>
                public static Task<string> Post(LeagueClientSession session, bool force) =>
                    session.SendRequestAsync<string>("POST", "/lol-loot/v1/refresh",
                        new Dictionary<string, string> {{"force", force.ToString()}});
            }
        }

        public static class V2
        {
            /// <summary>
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<LolLootPlayerLootMap> Get(LeagueClientSession session) =>
                session.SendRequestAsync<LolLootPlayerLootMap>("GET", "/lol-loot/v2/player-loot-map");
        }
    }
}