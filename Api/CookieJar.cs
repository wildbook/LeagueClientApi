using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class CookieJar
    {
        public static class V1
        {
            public static class Cookies
            {
                /// <summary>
                /// Get all cookies.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="api">API to get a declaration for</param>
                /// <returns></returns>
                public static Task<Cookie[]> Get(LeagueClientSession session, string api = null) =>
                    session.SendRequestAsync<Cookie[]>("GET", "/cookie-jar/v1/cookies");

                /// <summary>
                /// Set a cookie.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="cookie">Cookie to set</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, Cookie[] cookie) =>
                    session.SendRequestAsync("POST", "/cookie-jar/v1/cookies", body: cookie);
            }
        }
    }
}