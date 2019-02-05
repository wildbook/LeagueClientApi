using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolAccountVerification
    {
        public static class V1
        {
            public static class Device
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolAccountVerificationDeviceResponse> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolAccountVerificationDeviceResponse>("GET",
                        "/lol-account-verification/v1/device");
            }

            public static class Invalidate
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolAccountVerificationInvalidateResponse> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<LolAccountVerificationInvalidateResponse>("POST",
                        "/lol-account-verification/v1/invalidate");
            }

            public static class IsVerified
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolAccountVerificationIsVerifiedResponse> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolAccountVerificationIsVerifiedResponse>("GET",
                        "/lol-account-verification/v1/is-verified");
            }

            public static class SendToken
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="SendTokenRequest"></param>
                /// <returns></returns>
                public static Task<LolAccountVerificationSendTokenResponse> Post(LeagueClientSession session,
                    LolAccountVerificationSendTokenRequest SendTokenRequest) =>
                    session.SendRequestAsync<LolAccountVerificationSendTokenResponse>("POST",
                        "/lol-account-verification/v1/send-token", body: SendTokenRequest);
            }

            public static class Verify
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="VerifyRequest"></param>
                /// <returns></returns>
                public static Task<LolAccountVerificationVerifyResponse> Post(LeagueClientSession session,
                    LolAccountVerificationVerifyRequest VerifyRequest) =>
                    session.SendRequestAsync<LolAccountVerificationVerifyResponse>("POST",
                        "/lol-account-verification/v1/verify", body: VerifyRequest);
            }
        }
    }
}