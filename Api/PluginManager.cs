using LeagueClientApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class PluginManager
    {
        public static class Assets
        {
            /// <summary>
            /// Download a backend asset
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="plugin">Plugin name to serve from</param>
            /// <param name="path">Path to the asset to serve</param>
            /// <param name="ifNoneMatch">optional ETag of the asset that the caller has cached</param>
            /// <returns></returns>
            public static Task<dynamic> Get(LeagueClientSession session, string plugin, string path,
                string ifNoneMatch = null)
            {
                var headers = new Dictionary<string, string>();
                if (!string.IsNullOrEmpty(ifNoneMatch)) headers.Add("if-none-match", ifNoneMatch);
                return session.SendRequestAsync<dynamic>("GET", $"/{plugin}/assets/{path}", headers: headers);
            }

            //TODO: Check if rewriting to return headers instead of body is required. It probably is.
            /// <summary>
            /// Download the header for a backend asset
            /// </summary>
            /// <remarks>I'm pretty sure that the endpoint returns just headers and no content. If that's the case this method will not work, and will need to be rewritten.</remarks>
            /// <param name="session">The session object</param>
            /// <param name="plugin">Plugin name to serve from</param>
            /// <param name="path">Path to the asset to serve</param>
            /// <param name="ifNoneMatch">optional ETag of the asset that the caller has cached</param>
            /// <returns></returns>
            public static Task<dynamic> Head(LeagueClientSession session, string plugin, string path,
                string ifNoneMatch = null)
            {
                var headers = new Dictionary<string, string>();
                if (!string.IsNullOrEmpty(ifNoneMatch)) headers.Add("if-none-match", ifNoneMatch);
                return session.SendRequestAsync<dynamic>("HEAD", $"/{plugin}/assets/{path}", headers: headers);
            }
        }

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
                        session.SendRequestAsync("GET", "/plugin-manager/v1/plugin-stats/log");
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
                    session.SendRequestAsync<PluginManagerResource>("GET", "/plugin-manager/v1/status");
            }
        }

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
                    session.SendRequestAsync<PluginDescriptionResource[]>("GET", "/plugin-manager/v2/descriptions");

                /// <summary>
                /// Get a plugin description.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="plugin">Plugin name</param>
                /// <returns></returns>
                public static Task<PluginDescriptionResource> Get(LeagueClientSession session, string plugin) =>
                    session.SendRequestAsync<PluginDescriptionResource>("GET",
                        $"/plugin-manager/v2/descriptions/{plugin}");
            }

            public static class Plugins
            {
                /// <summary>
                /// Get diagnostic information for all plugins.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PluginResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PluginResource>("GET", "/plugin-manager/v2/plugins");

                /// <summary>
                /// Get diagnostic information for a single plugin.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PluginResource> Get(LeagueClientSession session, string plugin) =>
                    session.SendRequestAsync<PluginResource>("GET", $"/plugin-manager/v2/plugins/{plugin}");
            }

            public static class PluginsManifest
            {
                /// <summary>
                /// Get the plugin manifest.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/plugin-manager/v2/plugins-manifest");
            }
        }
    }
}