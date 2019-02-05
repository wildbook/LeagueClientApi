using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class DataStore
    {
        public static class V1
        {
            public static class InstallDir
            {
                /// <summary>
                /// Gets the current install directory (used internally.)
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string>("GET", "/data-store/v1/install-dir");
            }

            public static class InstallSettings
            {
                /// <summary>
                /// Get the data for the specified key from the install settings.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="path">The path to the settings key</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session, string path) =>
                    session.SendRequestAsync<string>("GET", $"/data-store/v1/install-settings/{path}");

                /// <summary>
                /// Set the data for the specified key from the install settings.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="path">The path to the settings key</param>
                /// <param name="data">The data to assign to the key</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string path, string data) =>
                    session.SendRequestAsync("POST", $"/data-store/v1/install-settings/{path}", body: data);
            }

            public static class SystemSettings
            {
                /// <summary>
                /// Get the setting for the specified key.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="path">The path to the settings key</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session, string path) =>
                    session.SendRequestAsync<string>("GET", $"/data-store/v1/system-settings/{path}");
            }
        }
    }
}