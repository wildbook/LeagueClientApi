using LeagueClientApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolChat
    {
        public static class V1
        {
            public static class BlockedPlayers
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-chat/v1/blocked-players/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatBlockedPlayerResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatBlockedPlayerResource[]>("GET", "/lol-chat/v1/blocked-players");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolChatBlockedPlayerResource[]>
                    Get(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<LolChatBlockedPlayerResource[]>("GET",
                        $"/lol-chat/v1/blocked-players/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="blocked"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolChatBlockedPlayerResource blocked) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-chat/v1/blocked-players", body: blocked);
            }

            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatChatServiceDynamicClientConfig>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatChatServiceDynamicClientConfig>("GET", "/lol-chat/v1/config");
            }

            public static class Conversations
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatConversationResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatConversationResource[]>("GET", "/lol-chat/v1/conversations");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="conversation"></param>
                /// <returns></returns>
                public static Task<LolChatConversationResource> Post(LeagueClientSession session,
                    LolChatConversationResource conversation) =>
                    session.SendRequestAsync<LolChatConversationResource>("POST", "/lol-chat/v1/conversations",
                        body: conversation);

                public static class Active
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolChatActiveConversationResource> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolChatActiveConversationResource>("GET",
                            "/lol-chat/v1/conversations/active");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="activeConversation"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Put(LeagueClientSession session,
                        LolChatActiveConversationResource activeConversation) => session.SendRequestAsync<dynamic>(
                        "PUT",
                        "/lol-chat/v1/conversations/active", body: activeConversation);
                }

                public static class Closed
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-chat/v1/conversations/{id}/closed");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Put(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("PUT", $"/lol-chat/v1/conversations/{id}/closed");
                }

                public static class DeleteActive
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Conversations(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("DELETE", "/lol-chat/v1/conversations/active");
                }

                public static class Messages
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Delete(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("PUT", $"/lol-chat/v1/conversations/{id}/messages");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChatConversationMessageResource[]>
                        Get(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<LolChatConversationMessageResource[]>("GET",
                            $"/lol-chat/v1/conversations/{id}/messages");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <param name="body"></param>
                    /// <returns></returns>
                    public static Task<LolChatConversationMessageResource> Post(LeagueClientSession session,
                        string id, LolChatConversationMessageResource body) =>
                        session.SendRequestAsync<LolChatConversationMessageResource>("POST",
                            $"/lol-chat/v1/conversations/{id}/messages", body: body);
                }

                public static class Notify
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("GET", "/lol-chat/v1/conversations/notify");
                }

                public static class Participants
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChatUserResource[]> Get(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<LolChatUserResource[]>("GET",
                            $"/lol-chat/v1/conversations/{id}/participants");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <param name="invitee"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id,
                        LolChatUserResource invitee) => session.SendRequestAsync<dynamic>("POST",
                        $"/lol-chat/v1/conversations/{id}/participants", body: invitee);
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-chat/v1/conversations/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolChatConversationResource> Get(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<LolChatConversationResource>("GET", $"/lol-chat/v1/conversations/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="updatedConversation"></param>
                /// <returns></returns>
                public static Task<LolChatConversationResource> Put(LeagueClientSession session, string id,
                    LolChatConversationResource updatedConversation) =>
                    session.SendRequestAsync<LolChatConversationResource>("PUT", $"/lol-chat/v1/conversations/{id}",
                        body: updatedConversation);
            }

            public static class Errors
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatErrorResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatErrorResource[]>("GET", "/lol-chat/v1/errors");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-chat/v1/errors/{id}");
            }

            public static class FriendGroups
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatGroupResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatGroupResource>("GET", "/lol-chat/v1/friend-groups");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="group"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, LolChatGroupResource group) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-chat/v1/friend-groups", body: group);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-chat/v1/friend-groups/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolChatGroupResource> Get(LeagueClientSession session, int id) =>
                    session.SendRequestAsync<LolChatGroupResource>("GET", $"/lol-chat/v1/friend-groups/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="group"></param>
                /// <returns></returns>
                public static Task<dynamic>
                    Put(LeagueClientSession session, int id, LolChatGroupResource group) =>
                    session.SendRequestAsync<dynamic>("PUT", $"/lol-chat/v1/friend-groups/{id}", body: group);

                public static class Friends
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChatFriendResource[]> Get(LeagueClientSession session, int id) =>
                        session.SendRequestAsync<LolChatFriendResource[]>("GET",
                            $"/lol-chat/v1/friend-groups/{id}/friends");
                }
            }

            public static class FriendRequests
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatFriendRequestResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatFriendRequestResource>("GET", "/lol-chat/v1/friend-requests");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="request"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolChatFriendRequestResource request) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-chat/v1/friend-requests", body: request);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-chat/v1/friend-requests/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="request"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, long id,
                    LolChatFriendRequestResource request) =>
                    session.SendRequestAsync<dynamic>("PUT", $"/lol-chat/v1/friend-requests/{id}", body: request);
            }

            public static class Friends
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatFriendResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatFriendResource[]>("GET", "/lol-chat/v1/friends");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-chat/v1/friends/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolChatFriendResource> Get(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<LolChatFriendResource>("GET", $"/lol-chat/v1/friends/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <param name="contact"></param>
                /// <returns></returns>
                public static Task<LolChatFriendResource> Put(LeagueClientSession session, long id,
                    LolChatFriendResource contact) =>
                    session.SendRequestAsync<LolChatFriendResource>("GET", $"/lol-chat/v1/friends/{id}", body: contact);
            }

            public static class Me
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatUserResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatUserResource>("GET", "/lol-chat/v1/me");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="me"></param>
                /// <returns></returns>
                public static Task<LolChatUserResource> Put(LeagueClientSession session, LolChatUserResource me) =>
                    session.SendRequestAsync<LolChatUserResource>("PUT", "/lol-chat/v1/me", body: me);
            }

            public static class Session
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/lol-chat/v1/session");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChatSessionResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChatSessionResource>("GET", "/lol-chat/v1/session");

                public static class Plain
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="auth"></param>
                    /// <returns></returns>
                    public static Task<LolChatSessionResource> Post(LeagueClientSession session,
                        LolChatAuthResourcePlain auth) =>
                        session.SendRequestAsync<LolChatSessionResource>("POST", "/lol-chat/v1/session/plain",
                            body: auth);
                }

                public static class Rso
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="auth"></param>
                    /// <returns></returns>
                    public static Task<LolChatSessionResource> Post(LeagueClientSession session,
                        LolChatAuthResourceRsoAccessToken auth) =>
                        session.SendRequestAsync<LolChatSessionResource>("POST", "/lol-chat/v1/session/rso",
                            body: auth);
                }
            }

            public static class Settings
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-chat/v1/settings");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="data"></param>
                /// <param name="doAsync"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, dynamic data, bool? doAsync = null)
                {
                    var query = new Dictionary<string, string>();
                    if (doAsync.HasValue) query.Add("doAsync", doAsync.ToString());
                    return session.SendRequestAsync<dynamic>("PUT", "/lol-chat/v1/settings", body: data, query: query);
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="key"></param>
                /// <param name="doAsync"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string key, bool? doAsync = null)
                {
                    var query = new Dictionary<string, string>();
                    if (doAsync.HasValue) query.Add("doAsync", doAsync.ToString());
                    return session.SendRequestAsync<dynamic>("PUT", $"/lol-chat/v1/settings/{key}", query);
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="key"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string key) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-chat/v1/settings/{key}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="key"></param>
                /// <param name="value"></param>
                /// <param name="doAsync"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session, string key, dynamic value,
                    bool? doAsync = null)
                {
                    var query = new Dictionary<string, string>();
                    if (doAsync.HasValue) query.Add("doAsync", doAsync.ToString());
                    return session.SendRequestAsync<dynamic>("PUT", $"/lol-chat/v1/settings/{key}", query, body: value);
                }
            }
        }
    }
}