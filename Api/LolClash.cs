using LeagueClientApi.Model;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolClash
    {
        public static class V1
        {
            public static class CheckinAllowed
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-clash/v1/checkin-allowed");
            }

            public static class Enabled
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-clash/v1/enabled");
            }

            public static class EogPlayerUpdate
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashEogPlayerUpdateDTO> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashEogPlayerUpdateDTO>("GET", "/lol-clash/v1/eogPlayerUpdate");

                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-clash/v1/eogPlayerUpdate/acknowledge");
                }
            }

            public static class Event
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="uuid"></param>
                /// <returns></returns>
                public static Task<ClashEventData> Get(LeagueClientSession session, string uuid) =>
                    session.SendRequestAsync<ClashEventData>("GET", $"/lol-clash/v1/event/{uuid}");
            }

            public static class Events
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="uuids"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, string[] uuids) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-clash/v1/events", body: uuids);
            }

            public static class GameEnd
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashTournamentGameEnd> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashTournamentGameEnd>("GET", "/lol-clash/v1/gameEnd");

                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-clash/v1/gameEnd/acknowledge");
                }
            }

            public static class HistoryAndWinners
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashTournamentHistoryAndWinners> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashTournamentHistoryAndWinners>("GET",
                        "/lol-clash/v1/historyandwinners");
            }

            public static class Iconconfig
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-clash/v1/iconconfig");
            }

            public static class Invitations
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashRoster[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashRoster[]>("GET", "/lol-clash/v1/invitations");
            }

            public static class Notifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashPlayerNotificationData> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashPlayerNotificationData>("GET", "/lol-clash/v1/notifications");

                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) =>
                        session.SendRequestAsync("POST", "/lol-clash/v1/notifications/acknowledge");
                }
            }

            public static class Ping
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-clash/v1/ping");
            }

            public static class Player
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashPlayerData> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashPlayerData>("GET", "/lol-clash/v1/player");

                public static class ChatRosters
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolClashPlayerChatRoster[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolClashPlayerChatRoster[]>("GET",
                            "/lol-clash/v1/player/chat-rosters");
                }

                public static class History
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolClashRosterStats[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolClashRosterStats[]>("GET", "/lol-clash/v1/player/history");
                }
            }

            public static class PlaymodeRestricted
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-clash/v1/playmode-restricted");
            }

            public static class Ready
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-clash/v1/ready");
            }

            public static class Refresh
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-clash/v1/refresh");
            }

            public static class Rewards
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashPlayerRewards> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashPlayerRewards>("GET", "/lol-clash/v1/rewards");
            }

            public static class Roster
            {
                public static class Stats
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="rosterId"></param>
                    /// <returns></returns>
                    public static Task<LolClashRosterStats> Get(LeagueClientSession session, long rosterId) =>
                        session.SendRequestAsync<LolClashRosterStats>("GET", $"/lol-clash/v1/roster/{rosterId}/stats");
                }
            }

            public static class Scouting
            {
                public static class Ranked
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolClashRankedScoutingMember[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolClashRankedScoutingMember[]>("GET",
                            "/lol-clash/v1/scouting/ranked");
                }
            }

            public static class Time
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<long> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<long>("GET", "/lol-clash/v1/time");
            }

            public static class Tournament
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="tournamentId"></param>
                /// <returns></returns>
                public static Task<LolClashTournament> Get(LeagueClientSession session, long tournamentId) =>
                    session.SendRequestAsync<LolClashTournament>("GET", $"/lol-clash/v1/tournament/{tournamentId}");

                public static class BidOffer
                {
                    public static class Accept
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            long summonerId) => session.SendRequestAsync<dynamic>("POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/bid-offer/{summonerId}/accept");
                    }

                    public static class Decline
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            long summonerId) => session.SendRequestAsync<dynamic>("POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/bid-offer/{summonerId}/decline");
                    }

                    public static class Offer
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            long summonerId) => session.SendRequestAsync<dynamic>("POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/bid-offer/{summonerId}/offer");
                    }

                    public static class Revoke
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            long summonerId) => session.SendRequestAsync<dynamic>("POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/bid-offer/{summonerId}/revoke");
                    }
                }

                public static class Bracket
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="tournamentId"></param>
                    /// <param name="bracketId"></param>
                    /// <returns></returns>
                    public static Task<LolClashBracket> Get(LeagueClientSession session, long tournamentId,
                        long bracketId) =>
                        session.SendRequestAsync<LolClashBracket>("GET",
                            $"/lol-clash/v1/tournament/{tournamentId}/bracket/{bracketId}");
                }

                public static class CreateRoster
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="tournamentId"></param>
                    /// <param name="rosterDetails"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                        LolClashRosterDetails rosterDetails) => session.SendRequestAsync<dynamic>("POST",
                        $"/lol-clash/v1/tournament/{tournamentId}/create-roster", body: rosterDetails);
                }

                public static class Invitations
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="tournamentId"></param>
                    /// <returns></returns>
                    public static Task<LolClashRoster[]> Get(LeagueClientSession session, long tournamentId) =>
                        session.SendRequestAsync<LolClashRoster[]>("GET",
                            $"/lol-clash/v1/tournament/{tournamentId}/invitations");
                }

                public static class Player
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="tournamentId"></param>
                    /// <returns></returns>
                    public static Task<LolClashPlayerTournamentData>
                        Get(LeagueClientSession session, long tournamentId) =>
                        session.SendRequestAsync<LolClashPlayerTournamentData>("GET",
                            $"/lol-clash/v1/tournament/{tournamentId}/player");
                }

                public static class Roster
                {
                    public static class CancelWithdraw
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/cancel-withdraw");
                    }

                    public static class ChangeAllDetails
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="rosterDetails"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashRosterDetails rosterDetails) => session.SendRequestAsync<dynamic>("POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/roster/change-all-details",
                            body: rosterDetails);
                    }

                    public static class ChangeIcon
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="changeIconRequest"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashChangeIconRequest changeIconRequest) => session.SendRequestAsync<dynamic>(
                            "POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/roster/change-icon",
                            body: changeIconRequest);
                    }

                    public static class ChangeName
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="changeNameRequest"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashChangeNameRequest changeNameRequest) => session.SendRequestAsync<dynamic>(
                            "POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/roster/change-name",
                            body: changeNameRequest);
                    }

                    public static class ChangeShortName
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="changeNameRequest"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashChangeNameRequest changeNameRequest) => session.SendRequestAsync<dynamic>(
                            "POST",
                            $"/lol-clash/v1/tournament/{tournamentId}/roster/change-short-name",
                            body: changeNameRequest);
                    }

                    public static class Disband
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/disband");
                    }

                    public static class Invite
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<FailedInvite[]> Post(LeagueClientSession session, long tournamentId,
                            long[] summonerIds) =>
                            session.SendRequestAsync<FailedInvite[]>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/invite", body: summonerIds);
                    }

                    public static class Kick
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="kickRequest"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashKickRequest kickRequest) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/kick", body: kickRequest);
                    }

                    public static class Leave
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/leave");
                    }

                    public static class Lockin
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/lockin");
                    }

                    public static class SetBid
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="setTicketRequest"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashSetTicketRequest setTicketRequest) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/set-bid", body: setTicketRequest);
                    }

                    public static class SetPosition
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="setPositionRequest"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            LolClashSetPositionRequest setPositionRequest) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/set-position",
                                body: setPositionRequest);
                    }

                    public static class Substitute
                    {
                        public static class Accept
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="tournamentId"></param>
                            /// <param name="rosterId"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session, long tournamentId, string rosterId) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-clash/v1/tournament/{tournamentId}/roster/{rosterId}/substitute/accept");
                        }

                        public static class Decline
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="tournamentId"></param>
                            /// <param name="rosterId"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session, long tournamentId, string rosterId) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-clash/v1/tournament/{tournamentId}/roster/{rosterId}/substitute/decline");
                        }

                        public static class Invite
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="inviteSubRequest"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                                LolClashInviteSubRequest inviteSubRequest) => session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/substitute/invite",
                                body: inviteSubRequest);
                        }

                        public static class Reclaim
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="tournamentId"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-clash/v1/tournament/{tournamentId}/roster/substitute/reclaim");
                        }

                        public static class Revoke
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="tournamentId"></param>
                            /// <param name="summonerId"></param>
                            /// <returns></returns>
                            public static Task<dynamic> Post(LeagueClientSession session, long tournamentId, long summonerId) =>
                                session.SendRequestAsync<dynamic>("POST",
                                    $"/lol-clash/v1/tournament/{tournamentId}/roster/substitute/{summonerId}/revoke");
                        }
                    }

                    public static class TransferCaptain
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="newCaptainSummonerId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId,
                            long newCaptainSummonerId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/transfer-captain",
                                body: newCaptainSummonerId);
                    }

                    public static class Unwithdraw
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/unwithdraw");
                    }

                    public static class Unlockin
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/unlockin");
                    }

                    public static class Winners
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<LolClashTournamentWinnerHistory>
                            Get(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<LolClashTournamentWinnerHistory>("GET",
                                $"/lol-clash/v1/tournament/{tournamentId}/winners");
                    }

                    public static class Withdraw
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session, long tournamentId) =>
                            session.SendRequestAsync<dynamic>("POST",
                                $"/lol-clash/v1/tournament/{tournamentId}/roster/withdraw");
                    }

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="tournamentId"></param>
                    /// <param name="rosterId"></param>
                    /// <returns></returns>
                    public static Task<LolClashRoster> Get(LeagueClientSession session, long tournamentId,
                        string rosterId) => session.SendRequestAsync<LolClashRoster>("GET",
                        $"/lol-clash/v1/tournament/{tournamentId}/roster/{rosterId}");

                    public static class Accept
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="rosterId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Get(LeagueClientSession session, long tournamentId,
                            string rosterId) => session.SendRequestAsync<dynamic>("GET",
                            $"/lol-clash/v1/tournament/{tournamentId}/roster/{rosterId}/accept");
                    }

                    public static class Decline
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="tournamentId"></param>
                        /// <param name="rosterId"></param>
                        /// <returns></returns>
                        public static Task<dynamic> Get(LeagueClientSession session, long tournamentId,
                            string rosterId) => session.SendRequestAsync<dynamic>("GET",
                            $"/lol-clash/v1/tournament/{tournamentId}/roster/{rosterId}/decline");
                    }
                }

                public static class StateInfo
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolClashTournamentStateInfo>
                        Get(LeagueClientSession session, long tournamentId) =>
                        session.SendRequestAsync<LolClashTournamentStateInfo>("GET",
                            $"/lol-clash/v1/tournament/{tournamentId}/stateInfo");
                }
            }

            public static class TournamentIds
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<int[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<int[]>("GET", "/lol-clash/v1/tournamentIds");
            }

            public static class TournamentStateInfo
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashTournamentStateInfo[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashTournamentStateInfo[]>("GET",
                        "/lol-clash/v1/tournament-state-info");
            }

            public static class TournamentSummary
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashTournamentSummary[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashTournamentSummary[]>("GET", "/lol-clash/v1/tournament-summary");
            }

            public static class Visible
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-clash/v1/visible");
            }
        }

        public static class V2
        {
            public static class PlaymodeRestricted
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolClashPlaymodeRestrictedInfo> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolClashPlaymodeRestrictedInfo>("GET",
                        "/lol-clash/v2/playmode-restricted");
            }
        }
    }
}