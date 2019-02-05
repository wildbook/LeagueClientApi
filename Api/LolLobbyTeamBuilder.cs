using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLobbyTeamBuilder
    {
        public static class ChampSelect
        {
            public static class V1
            {
                public static class BannableChampions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderChampSelectBannableChampions>
                        Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderChampSelectBannableChampions>("GET",
                            "/lol-lobby-team-builder/champ-select/v1/bannable-champions");
                }

                public static class DisabledChampions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderChampSelectDisabledChampions>
                        Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderChampSelectDisabledChampions>("GET",
                            "/lol-lobby-team-builder/champ-select/v1/disabled-champions");
                }

                public static class ImplementationActive
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<bool> Get(LeagueClientSession session) => session.SendRequestAsync<bool>("GET",
                        "/lol-lobby-team-builder/champ-select/v1/implementation-active");
                }

                public static class PickableChampions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderChampSelectPickableChampions>
                        Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderChampSelectPickableChampions>("GET",
                            "/lol-lobby-team-builder/champ-select/v1/pickable-champions");
                }

                public static class PickableSkins
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderChampSelectPickableSkins> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderChampSelectPickableSkins>("GET",
                            "/lol-lobby-team-builder/champ-select/v1/pickable-skins");
                }

                public static class Session
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderChampSelectSession> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderChampSelectSession>("GET",
                            "/lol-lobby-team-builder/champ-select/v1/session");

                    public static class Actions
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="data"></param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, int id,
                            LolLobbyTeamBuilderChampSelectAction data) => session.SendRequestAsync<dynamic>("POST",
                            $"/lol-lobby-team-builder/champ-select/v1/session/actions/{id}", body: data);

                        public static class Complete
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="id"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session, int id) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-lobby-team-builder/champ-select/v1/session/actions/{id}/complete");
                        }
                    }

                    public static class MySelection
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="selection"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Patch(LeagueClientSession session,
                            LolLobbyTeamBuilderChampSelectMySelection selection) =>
                            session.SendRequestAsync<dynamic>("PATCH",
                                "/lol-lobby-team-builder/champ-select/v1/session/my-selection", body: selection);

                        public static class Reroll
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    "/lol-lobby-team-builder/champ-select/v1/session/my-selection/reroll");
                        }
                    }

                    public static class Timer
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyTeamBuilderChampSelectTimer> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyTeamBuilderChampSelectTimer>("GET",
                                "/lol-lobby-team-builder/champ-select/v1/session/timer");
                    }

                    public static class Trades
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyTeamBuilderChampSelectTradeContract[]>
                            Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyTeamBuilderChampSelectTradeContract[]>("GET",
                                "/lol-lobby-team-builder/champ-select/v1/session/trades");

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<LolLobbyTeamBuilderChampSelectTradeContract>
                            Get(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<LolLobbyTeamBuilderChampSelectTradeContract>("GET",
                                $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}");

                        public static class Accept
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="id"></param>
                            /// <returns></returns>
                            public static Task<dynamic>
                                Post(LeagueClientSession session, int id) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/accept");
                        }

                        public static class Cancel
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="id"></param>
                            /// <returns></returns>
                            public static Task<dynamic>
                                Post(LeagueClientSession session, int id) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/cancel");
                        }

                        public static class Decline
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="id"></param>
                            /// <returns></returns>
                            public static Task<dynamic>
                                Post(LeagueClientSession session, int id) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/decline");
                        }

                        public static class Request
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="id"></param>
                            /// <returns></returns>
                            public static Task<LolLobbyTeamBuilderChampSelectTradeContract>
                                Post(LeagueClientSession session, int id) =>
                                session.SendRequestAsync<LolLobbyTeamBuilderChampSelectTradeContract>("POST",
                                    $"/lol-lobby-team-builder/champ-select/v1/session/trades/{id}/request");
                        }
                    }
                }

                public static class TeamBoost
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderTeamBoost> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderTeamBoost>("GET",
                            "/lol-lobby-team-builder/champ-select/v1/team-boost");

                    public static class Purchase
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<dynamic>
                            Post(LeagueClientSession session) =>
                            session.SendRequestAsync<dynamic>("POST",
                                "/lol-lobby-team-builder/champ-select/v1/team-boost/purchase");
                    }
                }
            }
        }

        public static class V1
        {
            public static class Invitations
            {
                public static class Accept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="invitation"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session,
                        LolLobbyTeamBuilderLobbyInvitation invitation) => session.SendRequestAsync<dynamic>("POST",
                        "/lol-lobby-team-builder/v1/invitations/accept", body: invitation);
                }
            }

            public static class Lobby
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/lol-lobby-team-builder/v1/lobby");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyTeamBuilderLobby> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyTeamBuilderLobby>("GET", "/lol-lobby-team-builder/v1/lobby");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="lobby"></param>
                /// <returns></returns>
                public static Task<LolLobbyTeamBuilderLobby> Post(LeagueClientSession session,
                    LolLobbyTeamBuilderLobby lobby) =>
                    session.SendRequestAsync<LolLobbyTeamBuilderLobby>("POST", "/lol-lobby-team-builder/v1/lobby",
                        body: lobby);

                public static class Countdown
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyTeamBuilderLobbyCountdownTimer> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyTeamBuilderLobbyCountdownTimer>("GET",
                            "/lol-lobby-team-builder/v1/lobby/countdown");
                }

                public static class Members
                {
                    public static class Kick
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-lobby-team-builder/v1/lobby/members/{id}/kick");
                    }

                    public static class Promote
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-lobby-team-builder/v1/lobby/members/{id}/promote");
                    }
                }
            }

            public static class Matchmaking
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyTeamBuilderMatchmakingSearchResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyTeamBuilderMatchmakingSearchResource>("GET",
                        "/lol-lobby-team-builder/v1/matchmaking");

                public static class LowPriorityQueueAbandon
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="leaverBusterToken"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string leaverBusterToken) =>
                        session.SendRequestAsync<dynamic>("POST",
                            "/lol-lobby-team-builder/v1/matchmaking/low-priority-queue/abandon",
                            body: leaverBusterToken);
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/lol-lobby-team-builder/v1/matchmaking/search");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="leaverBusterToken"></param>
                /// <returns></returns>
                public static Task<LolLobbyTeamBuilderMatchmakingSearchResource>
                    Post(LeagueClientSession session, string leaverBusterToken) =>
                    session.SendRequestAsync<LolLobbyTeamBuilderMatchmakingSearchResource>("POST",
                        "/lol-lobby-team-builder/v1/matchmaking/search", body: leaverBusterToken);
            }

            public static class PositionPreferences
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="positionPreferences"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolLobbyTeamBuilderLobbyPositionPreferences positionPreferences) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-lobby-team-builder/v1/position-preferences",
                        body: positionPreferences);
            }

            public static class ReadyCheck
            {
                public static class Accept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-lobby-team-builder/v1/ready-check/accept");
                }

                public static class Decline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-lobby-team-builder/v1/ready-check/decline");
                }
            }

            public static class TbEnabledFeatures
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyTeamBuilderTbLobbyEnabledFeaturesResource>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyTeamBuilderTbLobbyEnabledFeaturesResource>("GET",
                        "/lol-lobby-team-builder/v1/tb-enabled-features");
            }
        }

        public static class V2
        {
            public static class PositionPreferences
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="positionPreferences"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolLobbyTeamBuilderLobbyPositionPreferencesV2 positionPreferences) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-lobby-team-builder/v2/position-preferences",
                        body: positionPreferences);
            }
        }
    }
}