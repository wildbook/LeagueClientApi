using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class PluginAssetServing
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
                string ifNoneMatch = null) => PluginManager.Assets.Get(session, plugin, path, ifNoneMatch);

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
                string ifNoneMatch = null) => PluginManager.Assets.Head(session, plugin, path, ifNoneMatch);
        }
    }
}