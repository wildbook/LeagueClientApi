using LeagueClientApi.Model;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class PlayerNotifications
    {
        public static class V1
        {
            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlayerNotificationConfigResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlayerNotificationConfigResource>("GET",
                        "/player-notifications/v1/config");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="config"></param>
                /// <returns></returns>
                public static Task<PlayerNotificationConfigResource> Put(LeagueClientSession session,
                    PlayerNotificationResource config) =>
                    session.SendRequestAsync<PlayerNotificationConfigResource>("PUT", "/player-notifications/v1/config",
                        body: config);
            }

            public static class Notifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlayerNotificationResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlayerNotificationResource[]>("GET",
                        "/player-notifications/v1/notifications");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="notification"></param>
                /// <returns></returns>
                public static Task<PlayerNotificationResource> Post(LeagueClientSession session,
                    PlayerNotificationResource notification) =>
                    session.SendRequestAsync<PlayerNotificationResource>("POST",
                        "/player-notifications/v1/notifications", body: notification);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/player-notifications/v1/notifications/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<PlayerNotificationResource> Get(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<PlayerNotificationResource>("GET",
                        $"/player-notifications/v1/notifications/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="notification"></param>
                /// <returns></returns>
                public static Task<PlayerNotificationResource> Put(LeagueClientSession session, long id,
                    dynamic notification) =>
                    session.SendRequestAsync<PlayerNotificationResource>("PUT",
                        $"/player-notifications/v1/notifications/{id}", body: notification);
            }
        }
    }
}