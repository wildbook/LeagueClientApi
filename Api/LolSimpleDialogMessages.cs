using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolSimpleDialogMessages
    {
        public static class V1
        {
            public static class Messages
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolSimpleDialogMessagesMessage[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolSimpleDialogMessagesMessage[]>("GET",
                        "/lol-simple-dialog-messages/v1/messages");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="messageRequest"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolSimpleDialogMessagesLocalMessageRequest messageRequest) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-simple-dialog-messages/v1/messages",
                        body: messageRequest);

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="messageId"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long messageId) =>
                    session.SendRequestAsync<dynamic>("DELETE", "/lol-simple-dialog-messages/v1/messages/{messageId}");
            }
        }
    }
}