using LeagueClientApi.Model;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class PluginManagerDiagnostics
    {
        public static class V1
        {
            public static class PluginStats
            {
                public static class Log
                {
                    /// <summary>
                    /// Write the current plugin stats for the log file.
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Get(LeagueClientSession session) =>
                        PluginManager.V1.PluginStats.Log.Get(session);
                }
            }

            public static class Status
            {
                /// <summary>
                /// Gets the status of the plugin manager.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PluginManagerResource> Get(LeagueClientSession session) =>
                    PluginManager.V1.Status.Get(session);
            }
        }

        public static class V2
        {
            public static class Plugins
            {
                /// <summary>
                /// Get diagnostic information for all plugins.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PluginResource> Get(LeagueClientSession session) =>
                    PluginManager.V2.Plugins.Get(session);

                /// <summary>
                /// Get diagnostic information for a single plugin.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PluginResource> Get(LeagueClientSession session, string plugin) =>
                    PluginManager.V2.Plugins.Get(session, plugin);
            }

            public static class PluginsManifest
            {
                /// <summary>
                /// Get the plugin manifest.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    PluginManager.V2.PluginsManifest.Get(session);
            }
        }
    }
}