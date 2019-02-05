using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolEmailVerification
    {
        public static class V1
        {
            public static class ConfirmEmail
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-email-verification/v1/confirm-email");
            }

            public static class Email
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolEmailVerificationEmailVerificationSession> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolEmailVerificationEmailVerificationSession>("GET",
                        "/lol-email-verification/v1/email");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="EmailUpdate"></param>
                /// <returns></returns>
                public static Task<dynamic> Put(LeagueClientSession session,
                    LolEmailVerificationEmailUpdate EmailUpdate) =>
                    session.SendRequestAsync<dynamic>("PUT", "/lol-email-verification/v1/email", body: EmailUpdate);
            }
        }
    }
}