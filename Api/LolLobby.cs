using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLobby
    {
        public static class V1
        {
            public static class AutofillDisplayed
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-lobby/v1/autofill-displayed");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Put(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("PUT", "/lol-lobby/v1/autofill-displayed");
            }

            public static class ChangeQueue
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="queueId"></param>
                /// <returns></returns>
                public static Task<LolLobbyLobby> Post(LeagueClientSession session, LolLobbyLobbyChangeQueue queueId) =>
                    session.SendRequestAsync<LolLobbyLobby>("POST", "/lol-lobby/v1/change-queue", body: queueId);
            }

            public static class CustomGames
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyCustomGame[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobbyCustomGame[]>("GET", "/lol-lobby/v1/custom-games");

                public static class Refresh
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v1/custom-games/refresh");
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyCustomGame> Get(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<LolLobbyLobbyCustomGame>("GET", $"/lol-lobby/v1/custom-games/{id}");

                public static class Join
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <param name="parameters"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id,
                        LolLobbyLobbyCustomJoinParameters parameters) => session.SendRequestAsync<dynamic>("POST",
                        $"/lol-lobby/v1/custom-games/{id}/join", body: parameters);
                }
            }

            public static class LastQueuedLobby
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyLastQueuedLobby> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobbyLastQueuedLobby>("GET", "/lol-lobby/v1/last-queued-lobby");

                public static class PlayAgain
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobby> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyLobby>("POST", "/lol-lobby/v1/last-queued-lobby/play-again");
                }
            }

            public static class Lobby
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/lol-lobby/v1/lobby");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobby> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobby>("GET", "/lol-lobby/v1/lobby");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="lobby"></param>
                /// <returns></returns>
                public static Task<LolLobbyLobby> Post(LeagueClientSession session, LolLobbyLobby lobby) =>
                    session.SendRequestAsync<LolLobbyLobby>("POST", "/lol-lobby/v1/lobby", body: lobby);

                public static class Availability
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyQueueAvailability> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyQueueAvailability>("GET", "/lol-lobby/v1/lobby/availability");
                }

                public static class Countdown
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<int> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<int>("GET", "/lol-lobby/v1/lobby/countdown");
                }

                public static class Custom
                {
                    public static class AvailableBots
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyBotChampion[]> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyLobbyBotChampion[]>("GET",
                                "/lol-lobby/v1/lobby/custom/available-bots");
                    }

                    public static class Bots
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="parameters"></param>
                        /// <returns></returns>
                        public static Task<dynamic>
                            Post(LeagueClientSession session, LolLobbyLobbyBotParams parameters) =>
                            session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v1/lobby/custom/bots",
                                body: parameters);

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerInternalName"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Delete(LeagueClientSession session, string summonerInternalName) =>
                            session.SendRequestAsync<dynamic>("DELETE",
                                $"/lol-lobby/v1/lobby/custom/bots/{summonerInternalName}");

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerInternalName"></param>
                        /// <param name="parameters"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, string summonerInternalName,
                            LolLobbyLobbyBotParams parameters) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-lobby/v1/lobby/custom/bots/{summonerInternalName}",
                                body: parameters);
                    }

                    public static class BotsEnabled
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<bool> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<bool>("GET", "/lol-lobby/v1/lobby/custom/bots-enabled");
                    }

                    public static class CancelChampSelect
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session) =>
                            session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v1/lobby/custom/cancel-champ-select");
                    }

                    public static class StartChampSelect
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyCustomChampSelectStartResponse> Post(
                            LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyLobbyCustomChampSelectStartResponse>("POST",
                                "/lol-lobby/v1/lobby/custom/start-champ-select");
                    }

                    public static class SwitchTeams
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="team"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, string team = null)
                        {
                            var query = new Dictionary<string, string>();
                            if (team != null) query.Add("team", team);
                            return session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v1/lobby/custom/switch-teams",
                                query);
                        }
                    }
                }

                public static class Invitations
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyInvitation[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyLobbyInvitation[]>("GET", "/lol-lobby/v1/lobby/invitations");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="invitation"></param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyInvitation> Post(LeagueClientSession session,
                        LolLobbyLobbyInvitation invitation) =>
                        session.SendRequestAsync<LolLobbyLobbyInvitation>("POST", "/lol-lobby/v1/lobby/invitations",
                            body: invitation);

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyInvitation> Get(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<LolLobbyLobbyInvitation>("GET",
                            $"/lol-lobby/v1/lobby/invitations/{id}");
                }

                public static class Members
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyMember[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyLobbyMember[]>("GET", "/lol-lobby/v1/lobby/members");

                    public static class LocalMember
                    {
                        public static class PositionPreferences
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="positionPreferences"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Put(LeagueClientSession session,
                                LolLobbyLobbyPositionPreferences positionPreferences) =>
                                session.SendRequestAsync<dynamic>("PUT",
                                    "/lol-lobby/v1/lobby/members/localMember/position-preferences",
                                    body: positionPreferences);
                        }
                    }

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyMember> Get(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<LolLobbyLobbyMember>("GET", $"/lol-lobby/v1/lobby/members/{id}");

                    public static class GrantInvite
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyMember> Post(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<LolLobbyLobbyMember>("POST",
                                $"/lol-lobby/v1/lobby/members/{id}/grant-invite");
                    }

                    public static class Kick
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyMember> Post(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<LolLobbyLobbyMember>("POST",
                                $"/lol-lobby/v1/lobby/members/{id}/kick");
                    }

                    public static class Promote
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyMember> Post(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<LolLobbyLobbyMember>("POST",
                                $"/lol-lobby/v1/lobby/members/{id}/promote");
                    }

                    public static class RevokeInvite
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="id"></param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyMember> Post(LeagueClientSession session, long id) =>
                            session.SendRequestAsync<LolLobbyLobbyMember>("POST",
                                $"/lol-lobby/v1/lobby/members/{id}/revoke-invite");
                    }
                }
            }


            public static class Parties
            {
                public static class Active
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="active"></param>
                    /// <returns></returns>
                    public static Task Put(LeagueClientSession session, int active) =>
                        session.SendRequestAsync("PUT", "/lol-lobby/v1/parties/active", body: active);
                }

                public static class Health
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<string> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<string>("GET", "/lol-lobby/v1/parties/health");
                }

                public static class Metadata
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="metadata"></param>
                    /// <returns></returns>
                    public static Task Put(LeagueClientSession session, LolLobbyPartyMemberMetadataDto metadata) =>
                        session.SendRequestAsync("PUT", "/lol-lobby/v1/parties/metadata", body: metadata);
                }

                public static class Player
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyPlayerDto> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyPlayerDto>("GET", "/lol-lobby/v1/parties/player");
                }

                public static class Queue
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="queueId"></param>
                    /// <returns></returns>
                    public static Task Put(LeagueClientSession session, int queueId) =>
                        session.SendRequestAsync("PUT", "/lol-lobby/v1/parties/queue", body: queueId);
                }

                public static class Ready
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="ready"></param>
                    /// <returns></returns>
                    public static Task Put(LeagueClientSession session, int ready) =>
                        session.SendRequestAsync("PUT", "/lol-lobby/v1/parties/ready", body: ready);
                }

                public static class Members
                {
                    public static class Role
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="partyId"></param>
                        /// <param name="puuid"></param>
                        /// <param name="role"></param>
                        /// <returns></returns>
                        public static Task Put(LeagueClientSession session, string partyId, string puuid,
                            string role) =>
                            session.SendRequestAsync("PUT", $"/lol-lobby/v1/parties/{partyId}/members/{puuid}/role",
                                body: role);
                    }
                }
            }

            public static class PartyRewards
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyPartyRewards> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobbyPartyRewards>("GET", "/lol-lobby/v1/party-rewards");
            }

            public static class RecievedInvitations
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyInvitation[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobbyInvitation[]>("GET", "/lol-lobby/v1/received-invitations");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-lobby/v1/received-invitations/{id}");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyInvitation> Get(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<LolLobbyLobbyInvitation>("GET",
                        $"/lol-lobby/v1/received-invitations/{id}");

                public static class Accept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $" /lol-lobby/v1/received-invitations/{id}/accept");
                }

                public static class Decline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $" /lol-lobby/v1/received-invitations/{id}/decline");
                }
            }

            public static class Tournaments
            {
                public static class Join
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $" /lol-lobby/v1/tournaments/{id}/join");
                }
            }
        }

        public static class V2
        {
            public static class Comms
            {
                public static class Members
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyPremadePartyDto> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyPremadePartyDto>("GET", "/lol-lobby/v2/comms/members");
                }

                public static class Token
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<string> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<string>("GET", "/lol-lobby/v2/comms/token");
                }
            }

            public static class Lobby
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/lol-lobby/v2/lobby");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyDto> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobbyDto>("GET", "/lol-lobby/v2/lobby");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="lobbyChange"></param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyDto> Post(LeagueClientSession session,
                    LolLobbyLobbyChangeGameDto lobbyChange) =>
                    session.SendRequestAsync<LolLobbyLobbyDto>("POST", "/lol-lobby/v2/lobby", body: lobbyChange);

                public static class Custom
                {
                    public static class AvailableBots
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyBotChampion[]> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyLobbyBotChampion[]>("GET",
                                "/lol-lobby/v2/lobby/custom/available-bots");
                    }

                    public static class BotsEnabled
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<bool> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<bool>("GET", "/lol-lobby/v2/lobby/custom/bots-enabled");
                    }
                }

                public static class Eligibility
                {
                    public static class Premade
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyEligibility[]> Post(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyEligibility[]>("POST",
                                "/lol-lobby/v2/lobby/eligibility/premade");
                    }
                }

                public static class Invitations
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyInvitationDto[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyLobbyInvitationDto[]>("GET",
                            "/lol-lobby/v2/lobby/invitations");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="invitations"></param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyInvitationDto[]> Post(LeagueClientSession session,
                        LolLobbyLobbyInvitationDto[] invitations) =>
                        session.SendRequestAsync<LolLobbyLobbyInvitationDto[]>("POST",
                            "/lol-lobby/v2/lobby/invitations", body: invitations);
                }

                public static class Matchmaking
                {
                    public static class Search
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<dynamic> Delete(LeagueClientSession session) =>
                            session.SendRequestAsync<dynamic>("DELETE", "/lol-lobby/v2/lobby/matchmaking/search");


                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session) =>
                            session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v2/lobby/matchmaking/search");
                    }

                    public static class SearchState
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolLobbyLobbyMatchmakingSearchResource> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolLobbyLobbyMatchmakingSearchResource>("GET",
                                "/lol-lobby/v2/lobby/matchmaking/search-state");
                    }
                }

                public static class Members
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyLobbyParticipantDto[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyLobbyParticipantDto[]>("GET", "/lol-lobby/v2/lobby/members");

                    public static class LocalMember
                    {
                        public static class PositionPreferences
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="positionPreferences"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Put(LeagueClientSession session,
                                LolLobbyLobbyPositionPreferences positionPreferences) =>
                                session.SendRequestAsync<dynamic>("PUT",
                                    "/lol-lobby/v2/lobby/members/localMember/position-preferences",
                                    body: positionPreferences);
                        }
                    }

                    public static class GrantInvite
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<int> Post(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<int>("POST",
                                $"/lol-lobby/v2/lobby/members/{summonerId}/grant-invite");
                    }

                    public static class Kick
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<int> Post(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<int>("POST",
                                $"/lol-lobby/v2/lobby/members/{summonerId}/kick");
                    }

                    public static class Promote
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<int> Post(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<int>("POST",
                                $"/lol-lobby/v2/lobby/members/{summonerId}/promote");
                    }

                    public static class RevokeInvite
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<int> Post(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<int>("POST",
                                $"/lol-lobby/v2/lobby/members/{summonerId}/revoke-invite");
                    }
                }
            }

            public static class Notifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyLobbyNotification[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyLobbyNotification[]>("GET", "/lol-lobby/v2/notifications");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="notification"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, LolLobbyLobbyNotification notification) =>
                    session.SendRequestAsync("POST", "/lol-lobby/v2/notifications", body: notification);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="notificationId"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string notificationId) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-lobby/v2/notifications/{notificationId}");
            }

            public static class Parties
            {
                public static class Overrides
                {
                    public static class Enabled
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="enabled"></param>
                        /// <returns></returns>
                        public static Task Post(LeagueClientSession session, bool enabled) => session.SendRequestAsync(
                            "POST",
                            "/lol-lobby/v2/parties/overrides/Enabled",
                            new Dictionary<string, string> {{"enabled", enabled.ToString()}});
                    }

                    public static class EnabledForTeamBuilderQueues
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="enabledForTeambuilderQueues"></param>
                        /// <returns></returns>
                        public static Task Post(LeagueClientSession session, bool enabledForTeambuilderQueues) =>
                            session.SendRequestAsync("POST",
                                "/lol-lobby/v2/parties/overrides/EnabledForTeamBuilderQueues",
                                new Dictionary<string, string>
                                {
                                    {"enabledForTeambuilderQueues", enabledForTeambuilderQueues.ToString()}
                                });
                    }
                }
            }

            public static class PlayAgain
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v2/play-again");
            }

            public static class PlayAgainDecline
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-lobby/v2/play-again-decline");
            }

            public static class ReceivedInvitations
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLobbyReceivedInvitationDto[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLobbyReceivedInvitationDto[]>("GET",
                        "/lol-lobby/v2/received-invitations");

                public static class Accept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="invitationId"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string invitationId) =>
                        session.SendRequestAsync("POST",
                            $"/lol-lobby/v2/received-invitations/{invitationId}/accept");
                }

                public static class Decline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="invitationId"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string invitationId) =>
                        session.SendRequestAsync("POST",
                            $"/lol-lobby/v2/received-invitations/{invitationId}/decline");
                }
            }
        }
    }
}