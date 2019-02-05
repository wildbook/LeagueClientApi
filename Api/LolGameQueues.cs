using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolGameQueues
    {
        public static class V1
        {
            public static class Custom
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGameQueuesQueueCustomGame> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGameQueuesQueueCustomGame>("GET", "/lol-game-queues/v1/custom");
            }

            public static class CustomNonDefault
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGameQueuesQueueCustomGame> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGameQueuesQueueCustomGame>("GET",
                        "/lol-game-queues/v1/custom-non-default");
            }

            public static class GameTypeConfig
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="gameTypeConfigId"></param>
                /// <returns></returns>
                public static Task<LolGameQueuesQueueGameTypeConfig>
                    Get(LeagueClientSession session, int gameTypeConfigId) =>
                    session.SendRequestAsync<LolGameQueuesQueueGameTypeConfig>("GET",
                        $"/lol-game-queues/v1/game-type-config/{gameTypeConfigId}");

                public static class Map
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="gameTypeConfigId"></param>
                    /// <param name="mapId"></param>
                    /// <returns></returns>
                    public static Task<LolGameQueuesQueueGameTypeConfig> Get(LeagueClientSession session,
                        int gameTypeConfigId, int mapId) =>
                        session.SendRequestAsync<LolGameQueuesQueueGameTypeConfig>("GET",
                            $"/lol-game-queues/v1/game-type-config/{gameTypeConfigId}/map/{mapId}");
                }
            }

            public static class Queues
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGameQueuesQueue[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGameQueuesQueue[]>("GET", "/lol-game-queues/v1/queues");

                public static class Type
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="queueType"></param>
                    /// <returns></returns>
                    public static Task<LolGameQueuesQueue> Get(LeagueClientSession session, int queueType) =>
                        session.SendRequestAsync<LolGameQueuesQueue>("GET",
                            $"/lol-game-queues/v1/queues/type/{queueType}");
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolGameQueuesQueue> Get(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<LolGameQueuesQueue>("GET", $"/lol-game-queues/v1/queues/{id}");
            }
        }
    }
}