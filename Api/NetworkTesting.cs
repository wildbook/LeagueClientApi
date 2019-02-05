using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class NetworkTesting
    {
        public static class V1
        {
            public static class Experiments
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<NetworkExperimentsResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<NetworkExperimentsResource>("GET", "/network-testing/v1/experiments");
            }
        }
    }
}