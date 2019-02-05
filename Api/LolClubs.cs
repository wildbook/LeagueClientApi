using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolClubs
    {
        public static class V1
        {
            public static class Clubs
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlayerClub[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlayerClub[]>("GET", "/lol-clubs/v1/clubs");

                public static class Invitations
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<ClubInvite> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<ClubInvite>("GET", "/lol-clubs/v1/clubs/invitations");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="invitation"></param>
                    /// <returns></returns>
                    public static Task<PlayerClubMembership>
                        Patch(LeagueClientSession session, ClubInvite invitation) =>
                        session.SendRequestAsync<PlayerClubMembership>("PATCH", "/lol-clubs/v1/clubs/invitations",
                            body: invitation);

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <returns></returns>
                    public static Task<ClubMember[]> Get(LeagueClientSession session, string clubKey) =>
                        session.SendRequestAsync<ClubMember[]>("GET", $"/lol-clubs/v1/clubs/{clubKey}/invitations");


                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Delete(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("DELETE",
                        $"/lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Post(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("Post",
                        $"/lol-clubs/v1/clubs/{clubKey}/invitations/{summonerId}");
                }

                public static class Membership
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<PlayerClubMembership> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<PlayerClubMembership>("GET", "/lol-clubs/v1/clubs/membership");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="name"></param>
                    /// <returns></returns>
                    public static Task<PlayerClub> Post(LeagueClientSession session, ClubName name) =>
                        session.SendRequestAsync<PlayerClub>("POST", "/lol-clubs/v1/clubs/membership", body: name);

                    public static class Preferences
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<ClubPreferences> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<ClubPreferences>("GET",
                                "/lol-clubs/v1/clubs/membership/preferences");

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="preferences"></param>
                        /// <returns></returns>
                        public static Task<ClubPreferences>
                            Patch(LeagueClientSession session, ClubPreferences preferences) =>
                            session.SendRequestAsync<ClubPreferences>("PATCH",
                                "/lol-clubs/v1/clubs/membership/preferences", body: preferences);
                    }
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="clubKey"></param>
                /// <returns></returns>
                public static Task<PlayerClubMembership> Delete(LeagueClientSession session, string clubKey) =>
                    session.SendRequestAsync<PlayerClubMembership>("DELETE", $"/lol-clubs/v1/clubs/{clubKey}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="clubKey"></param>
                /// <returns></returns>
                public static Task<PlayerClub> Get(LeagueClientSession session, string clubKey) =>
                    session.SendRequestAsync<PlayerClub>("GET", $"/lol-clubs/v1/clubs/{clubKey}");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="clubKey"></param>
                /// <param name="tag"></param>
                /// <returns></returns>
                public static Task<PlayerClub> Post(LeagueClientSession session, string clubKey, ClubTag tag) =>
                    session.SendRequestAsync<PlayerClub>("POST", $"/lol-clubs/v1/clubs/{clubKey}", body: tag);

                public static class Members
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <returns></returns>
                    public static Task<ClubMember> Get(LeagueClientSession session, string clubKey) =>
                        session.SendRequestAsync<ClubMember>("GET", $"/lol-clubs/v1/clubs/{clubKey}/members");


                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Delete(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("DELETE",
                        $"/lol-clubs/v1/clubs/{clubKey}/members/{summonerId}");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<PlayerClub> Post(LeagueClientSession session, string clubKey, long summonerId) =>
                        session.SendRequestAsync<PlayerClub>("POST",
                            $"/lol-clubs/v1/clubs/{clubKey}/members/{summonerId}");
                }

                public static class Motd
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <returns></returns>
                    public static Task<string> Get(LeagueClientSession session, string clubKey) =>
                        session.SendRequestAsync<string>("GET", $"/lol-clubs/v1/clubs/{clubKey}/motd");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="motd"></param>
                    /// <returns></returns>
                    public static Task<string> Patch(LeagueClientSession session, string clubKey, ClubMOTD motd) =>
                        session.SendRequestAsync<string>("PATCH", $"/lol-clubs/v1/clubs/{clubKey}/motd", body: motd);
                }

                public static class Nominations
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <returns></returns>
                    public static Task<ClubMember> Get(LeagueClientSession session, string clubKey) =>
                        session.SendRequestAsync<ClubMember>("GET", $"/lol-clubs/v1/clubs/{clubKey}/nominations");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Delete(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("DELETE",
                        $"/lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Post(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("POST",
                        $"/lol-clubs/v1/clubs/{clubKey}/nominations/{summonerId}");
                }

                public static class Promotions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Delete(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("DELETE",
                        $"/lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<ClubMemberLists> Post(LeagueClientSession session, string clubKey,
                        long summonerId) => session.SendRequestAsync<ClubMemberLists>("POST",
                        $"/lol-clubs/v1/clubs/{clubKey}/promotions/{summonerId}");
                }

                public static class View
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="clubKey"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string clubKey) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-clubs/v1/clubs/{clubKey}/view");
                }
            }
        }
    }
}