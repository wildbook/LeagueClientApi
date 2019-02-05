using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLeaverBuster
    {
        public static class V1
        {
            public static class Notifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LeaverBusterNotificationResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LeaverBusterNotificationResource[]>("GET",
                        "/lol-leaver-buster/v1/notifications");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-leaver-buster/v1/notifications/{id}");

                /// <summary>
                /// 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LeaverBusterNotificationResource> Get(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<LeaverBusterNotificationResource>("GET", $"/lol-leaver-buster/v1/notifications/{id}");
            }
        }
    }
}