using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolReplays
    {
        public static class V1
        {
            public static class Configuration
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolReplaysReplaysConfiguration> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolReplaysReplaysConfiguration>("GET", "/lol-replays/v1/configuration");
            }

            public static class Metadata
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="gameId"></param>
                /// <returns></returns>
                public static Task<LolReplaysReplayMetadata> Get(LeagueClientSession session, long gameId) =>
                    session.SendRequestAsync<LolReplaysReplayMetadata>("GET", $"/lol-replays/v1/metadata/{gameId}");

                public static class Create
                {
                    public static class GameVersion
                    {
                        public static class GameType
                        {
                            public static class QueueId
                            {
                                // TODO: Decide if this should be nested in classes or not
                                // Technically it should be nested to follow the "standard", but there is not really a point in nesting it.
                                // For now, I will leave it nested as it will be easier to transition to an automatically generated/updating api
                                // if all the endpoints follow a standard.

                                /// <summary>
                                /// </summary>
                                /// <param name="session">The session object</param>
                                /// <param name="gameId"></param>
                                /// <param name="gameVersion"></param>
                                /// <param name="gameType"></param>
                                /// <param name="queueId"></param>
                                /// <returns></returns>
                                public static Task Post(LeagueClientSession session, long gameId, string gameVersion,
                                    string gameType, int queueId) => session.SendRequestAsync("POST",
                                    $"/lol-replays/v1/metadata/{gameId}/create/gameVersion/{gameVersion}/gameType/{gameType}/queueId/{queueId}");
                            }
                        }
                    }
                }
            }

            public static class Rofls
            {
                public static class Path
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<string> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<string>("GET", "/lol-replays/v1/rofls/path");

                    public static class Default
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<string> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<string>("GET", "/lol-replays/v1/rofls/path/default");
                    }
                }

                public static class Scan
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) =>
                        session.SendRequestAsync("POST", "/lol-replays/v1/rofls/scan");
                }

                public static class Download
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="gameId"></param>
                    /// <param name="contextData"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, long gameId,
                        LolReplaysReplayContextData contextData) =>
                        session.SendRequestAsync("POST", $"/lol-replays/v1/rofls/{gameId}/download", body: contextData);

                    public static class Graceful
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="gameId"></param>
                        /// <param name="contextData"></param>
                        /// <returns></returns>
                        public static Task Post(LeagueClientSession session, long gameId,
                            LolReplaysReplayContextData contextData) =>
                            session.SendRequestAsync("POST", $"/lol-replays/v1/rofls/{gameId}/download/graceful",
                                body: contextData);
                    }
                }

                public static class Watch
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="gameId"></param>
                    /// <param name="contextData"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, long gameId,
                        LolReplaysReplayContextData contextData) =>
                        session.SendRequestAsync("POST", $"/lol-replays/v1/rofls/{gameId}/watch",
                            body: contextData);
                }
            }
        }

        public static class V2
        {
            public static class Metadata
            {
                public static class Create
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="gameId"></param>
                    /// <param name="request"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, long gameId,
                        LolReplaysReplayCreateMetadata request) => session.SendRequestAsync("POST",
                        $"/lol-replays/v2/metadata/{gameId}/create", body: request);
                }
            }
        }
    }
}