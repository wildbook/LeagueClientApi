using LeagueClientApi.Model;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class PluginManagerInfo
    {
        public static class V2
        {
            public static class Descriptions
            {
                /// <summary>
                /// Get all plugin descriptions.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PluginDescriptionResource[]> Get(LeagueClientSession session) =>
                    PluginManager.V2.Descriptions.Get(session);

                /// <summary>
                /// Get a plugin description.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="plugin">Plugin name</param>
                /// <returns></returns>
                public static Task<PluginDescriptionResource> Get(LeagueClientSession session, string plugin) =>
                    PluginManager.V2.Descriptions.Get(session, plugin);
            }
        }
    }
}