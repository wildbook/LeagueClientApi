using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolKrShutdownLaw
    {
        public static class V1
        {
            public static class CustomStatus
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolKrShutdownLawQueueShutdownStatus> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolKrShutdownLawQueueShutdownStatus>("GET", "/lol-kr-shutdown-law/v1/custom-status");
            }

            public static class DisabledQueues
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<int[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<int[]>("GET", "/lol-kr-shutdown-law/v1/disabled-queues");
            }

            public static class Notification
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolKrShutdownLawShutdownLawNotification> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolKrShutdownLawShutdownLawNotification>("GET", "/lol-kr-shutdown-law/v1/notification");
            }

            public static class QueueStatus
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="queue_id"></param>
                /// <returns></returns>
                public static Task<LolKrShutdownLawQueueShutdownStatus> Get(LeagueClientSession session, int queue_id) =>
                    session.SendRequestAsync<LolKrShutdownLawQueueShutdownStatus>("GET",
                        $"/lol-kr-shutdown-law/v1/queue-status/{queue_id}");
            }

            public static class Status
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolKrShutdownLawAllQueueShutdownStatus> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolKrShutdownLawAllQueueShutdownStatus>("GET", "/lol-kr-shutdown-law/v1/status");
            }
        }
    }
}