using LeagueClientApi.Model;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class System
    {
        public static class V1
        {
            public static class Builds
            {
                /// <summary>
                /// Information about the current artifacts that make up this build
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<BuildInfo> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<BuildInfo>("GET", "/system/v1/builds");
            }
        }
    }
}