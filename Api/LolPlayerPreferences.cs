using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPlayerPreferences
    {
        public static class V1
        {
            public static class Hash
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="preferences"></param>
                /// <returns></returns>
                public static Task<string> Post(LeagueClientSession session, string preferences) =>
                    session.SendRequestAsync<string>("POST", "/lol-player-preferences/v1/hash", body: preferences);
            }

            public static class PlayerPreferencesEndpointOverride
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="preferences"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, PlayerPreferencesEndpoint preferences) =>
                    session.SendRequestAsync<dynamic>("POST",
                        "/lol-player-preferences/v1/player-preferences-endpoint-override", body: preferences);
            }

            public static class PlayerPreferencesReady
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-player-preferences/v1/player-preferences-ready");
            }

            public static class Preference
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="preferences"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, PlayerPreferences preferences) =>
                    session.SendRequestAsync<dynamic>("PUT", "/lol-player-preferences/v1/preference",
                        body: preferences);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string type, string hash = null)
                {
                    var query = new Dictionary<string, string>();
                    if (hash != null) query.Add("hash", hash);
                    return session.SendRequestAsync<dynamic>("GET", $"/lol-player-preferences/v1/preference/{type}",
                        query);
                }
            }
        }
    }
}