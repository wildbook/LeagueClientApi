using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLoyality
    {
        public static class V1
        {
            public static class StatusNotification
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LoyaltyStatusNotification> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LoyaltyStatusNotification>("GET", "/lol-loyalty/v1/status-notification");
            }
        }
    }
}