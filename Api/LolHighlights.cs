using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolHighlights
    {
        public static class V1
        {
            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<HighlightsConfig> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<HighlightsConfig>("GET", "/lol-highlights/v1/config");
            }

            public static class FileBrowser
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="highlightId"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, long highlightId) =>
                    session.SendRequestAsync<dynamic>("POST", $"/lol-highlights/v1/file-browser/{highlightId}");
            }

            public static class Highlights
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<Highlight[]> Get(LeagueClientSession session) => session.SendRequestAsync<Highlight[]>("GET", "/lol-highlights/v1/highlights");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<Highlight[]> Post(LeagueClientSession session) => session.SendRequestAsync<Highlight[]>("POST", "/lol-highlights/v1/highlights");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<Highlight> Delete(LeagueClientSession session, long id) => session.SendRequestAsync<Highlight>("DELETE", $"/lol-highlights/v1/highlights/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<Highlight> Get(LeagueClientSession session, long id) => session.SendRequestAsync<Highlight>("GET", $"/lol-highlights/v1/highlights/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="highlight"></param>
                /// <returns></returns>
                public static Task<Highlight> Put(LeagueClientSession session, long id, Highlight highlight) => session.SendRequestAsync<Highlight>("PUT", $"/lol-highlights/v1/highlights/{id}", body: highlight);
            }

            public static class HighlightsFolderPath
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session) => session.SendRequestAsync<string>("GET", "/lol-highlights/v1/highlights-folder-path");

                public static class Default
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<string> Get(LeagueClientSession session) => session.SendRequestAsync<string>("GET", "/lol-highlights/v1/highlights-folder-path/default");
                }
            }
        }
    }
}