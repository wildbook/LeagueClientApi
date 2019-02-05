using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolBetaOptIn
    {
        public static class V1
        {
            public static class MigrationError
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Get(LeagueClientSession session) =>
                    session.SendRequestAsync("GET", "/lol-beta-opt-in/v1/migration-error");

                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="errString"></param>
                /// <returns></returns>
                public static Task Put(LeagueClientSession session, string errString)
                {
                    var query = new Dictionary<string, string> { { "errString", errString } };
                    return session.SendRequestAsync("PUT", "/lol-beta-opt-in/v1/migration-error", query);
                }
            }

            public static class NeedsMigration
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Get(LeagueClientSession session) =>
                    session.SendRequestAsync("GET", "/lol-beta-opt-in/v1/needs-migration");
            }

            public static class DoMigration
            {
                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-beta-opt-in/v1/do-migration");
            }
        }
    }
}