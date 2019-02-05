using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPlayerMessaging
    {
        public static class V1
        {
            public static class Celebration
            {
                public static class Notification
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<DynamicCelebrationMessagingNotificationResource>
                        Get(LeagueClientSession session) =>
                        session.SendRequestAsync<DynamicCelebrationMessagingNotificationResource>("GET",
                            "/lol-player-messaging/v1/celebration/notification");

                    public static class Acknowledge
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Delete(LeagueClientSession session, int id) =>
                            session.SendRequestAsync<dynamic>("DELETE",
                                $"/lol-player-messaging/v1/celebration/notification/{id}/acknowledge");
                    }
                }
            }

            public static class Notification
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlayerMessagingNotificationResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlayerMessagingNotificationResource>("GET",
                        "/lol-player-messaging/v1/notification");

                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Delete(LeagueClientSession session, int id) =>
                        session.SendRequestAsync<dynamic>("DELETE",
                            $"/lol-player-messaging/v1/notification/{id}/acknowledge");
                }
            }
        }
    }
}