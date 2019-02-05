using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolServiceStatus
    {
        public static class V1
        {
            public static class LcuStatus
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<ServiceStatusResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<ServiceStatusResource>("GET", "/lol-service-status/v1/lcu-status");
            }

            public static class TickerMessages
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<TickerMessage[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<TickerMessage[]>("GET", "/lol-service-status/v1/ticker-messages");
            }
        }
    }
}