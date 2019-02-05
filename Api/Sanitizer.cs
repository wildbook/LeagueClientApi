using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Sanitizer
    {
        public static class V1
        {
            public static class ContainsSanitized
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="request"></param>
                /// <returns></returns>
                public static Task<SanitizerContainsSanitizedResponse> Post(LeagueClientSession session,
                    SanitizerContainsSanitizedRequest request) =>
                    session.SendRequestAsync<SanitizerContainsSanitizedResponse>("POST",
                        "/sanitizer/v1/containsSanitized",
                        body: request);
            }

            public static class Sanitize
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="request"></param>
                /// <returns></returns>
                public static Task<SanitizerSanitizeResponse> Post(LeagueClientSession session,
                    SanitizerSanitizeRequest request) =>
                    session.SendRequestAsync<SanitizerSanitizeResponse>("POST", "/sanitizer/v1/sanitize",
                        body: request);
            }

            public static class Status
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<SanitizerSanitizerStatus> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<SanitizerSanitizerStatus>("GET", "/sanitizer/v1/status");
            }
        }
    }
}