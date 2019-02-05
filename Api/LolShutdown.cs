using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolShutdown
    {
        public static class V1
        {
            public static class Notification
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<ShutdownNotification> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<ShutdownNotification>("GET", "/lol-shutdown/v1/notification");
            }
        }
    }
}