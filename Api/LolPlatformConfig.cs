using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolPlatformConfig
    {
        public static class V1
        {
            public static class InitialConfigurationComplete
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-platform-config/v1/initial-configuration-complete");
            }

            public static class Namespaces
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-platform-config/v1/namespaces");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ns"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string ns) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-platform-config/v1/namespaces/{ns}");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ns"></param>
                /// <param name="key"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string ns, string key) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-platform-config/v1/namespaces/{ns}/{key}");
            }
        }
    }
}