using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolSettings
    {
        public static class V1
        {
            public static class Account
            {
                public static class DidReset
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<bool> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<bool>("GET", "/lol-settings/v1/account/didreset");
                }

                public static class Save
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) =>
                        session.SendRequestAsync("POST", "/lol-settings/v1/account/save");
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="category"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string category) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-settings/v1/account/{category}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="category"></param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Patch(LeagueClientSession session, string category,
                    LolSettingsSettingCategory settingsResource) =>
                    session.SendRequestAsync<dynamic>("PATCH", $"/lol-settings/v1/account/{category}",
                        body: settingsResource);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="category"></param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, string category,
                    LolSettingsSettingCategory settingsResource) =>
                    session.SendRequestAsync<dynamic>("PUT", $"/lol-settings/v1/account/{category}",
                        body: settingsResource);
            }

            public static class Local
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string category) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-settings/v1/local/{category}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="category"></param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Patch(LeagueClientSession session, string category,
                    LolSettingsSettingCategory settingsResource) =>
                    session.SendRequestAsync<dynamic>("PATCH", $"/lol-settings/v1/local/{category}",
                        body: settingsResource);
            }
        }

        public static class V2
        {
            public static class Account
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ppType"></param>
                /// <param name="category"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string ppType, string category) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-settings/v2/account/{ppType}/{category}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ppType"></param>
                /// <param name="category"></param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Patch(LeagueClientSession session, string ppType, string category,
                    LolSettingsSettingCategory settingsResource) =>
                    session.SendRequestAsync<dynamic>("PATCH", $"/lol-settings/v2/account/{ppType}/{category}",
                        body: settingsResource);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ppType"></param>
                /// <param name="category"></param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, string ppType, string category,
                    LolSettingsSettingCategory settingsResource) =>
                    session.SendRequestAsync<dynamic>("PUT", $"/lol-settings/v2/account/{ppType}/{category}",
                        body: settingsResource);
            }

            public static class DidReset
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ppType"></param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session, string ppType) =>
                    session.SendRequestAsync<bool>("GET", $"/lol-settings/v2/didreset/{ppType}");
            }

            public static class Local
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="category"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string category) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-settings/v2/local/{category}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="category"></param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Patch(LeagueClientSession session, string category,
                    LolSettingsSettingCategory settingsResource) =>
                    session.SendRequestAsync<dynamic>("PATCH", $"/lol-settings/v2/local/{category}");
            }

            public static class Ready
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-settings/v2/ready");
            }
        }
    }
}