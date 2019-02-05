using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPerks
    {
        public static class V1
        {
            public static class CurrentPage
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksPerkPageResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksPerkPageResource>("GET", "/lol-perks/v1/currentpage");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("PUT", "/lol-perks/v1/currentpage", body: id);
            }

            public static class CustomizationLimits
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksCustomizationLimits> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksCustomizationLimits>("GET", "/lol-perks/v1/customizationlimits");
            }

            public static class Inventory
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksPlayerInventory> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksPlayerInventory>("GET", "/lol-perks/v1/inventory");
            }

            public static class Pages
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/lol-perks/v1/pages");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksPerkPageResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksPerkPageResource>("GET", "/lol-perks/v1/pages");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="page"></param>
                /// <returns></returns>
                public static Task<LolPerksPerkPageResource> Post(LeagueClientSession session,
                    LolPerksPerkPageResource page) =>
                    session.SendRequestAsync<LolPerksPerkPageResource>("POST", "/lol-perks/v1/pages", body: page);


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-perks/v1/pages/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolPerksPerkPageResource> Get(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<LolPerksPerkPageResource>("GET", $"/lol-perks/v1/pages/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="page"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, int id, LolPerksPerkPageResource page) =>
                    session.SendRequestAsync<dynamic>("PUT", $"/lol-perks/v1/pages/{id}", body: page);
            }

            public static class Perks
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksPerkUIPerk[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksPerkUIPerk[]>("GET", "/lol-perks/v1/perks");

                public static class Disabled
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<int[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<int[]>("GET", "/lol-perks/v1/perks/disabled");
                }
            }

            public static class ServiceSettings
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksServiceSettings> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksServiceSettings>("GET", "/lol-perks/v1/servicesettings");
            }

            public static class Settings
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksUISettings> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksUISettings>("GET", "/lol-perks/v1/settings");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="showLongDescriptions"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, LolPerksUISettings showLongDescriptions) =>
                    session.SendRequestAsync<dynamic>("PUT", "/lol-perks/v1/settings", body: showLongDescriptions);
            }

            public static class Styles
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPerksPerkUIStyle[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPerksPerkUIStyle[]>("GET", "/lol-perks/v1/styles");
            }
        }
    }
}