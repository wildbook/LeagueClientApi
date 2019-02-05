using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;
using Newtonsoft.Json;

namespace LeagueClientApi.Api
{
    public static class LolQueueEligibility
    {
        public static class V1
        {
            public static class InitialConfigurationComplete
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-queue-eligibility/v1/initial-configuration-complete");
            }

            public static class Eligibility
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="eligibilityQueryParam"></param>
                /// <returns></returns>
                public static Task<LolQueueEligibilityEligibility[]> Post(LeagueClientSession session,
                    LolQueueEligibilityEligibilityQueryParams eligibilityQueryParam) =>
                    session.SendRequestAsync<LolQueueEligibilityEligibility[]>("POST",
                        "/lol-queue-eligibility/v1/eligibility", body: eligibilityQueryParam);
            }
        }

        public static class V2
        {
            public static class Eligibility
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="eligibilityQueryParam"></param>
                /// <returns></returns>
                public static Task<LolQueueEligibilityEligibility[]> Post(LeagueClientSession session,
                    LolQueueEligibilityEligibilityQueryParams eligibilityQueryParam) =>
                    session.SendRequestAsync<LolQueueEligibilityEligibility[]>("POST",
                        "/lol-queue-eligibility/v1/eligibility", body: eligibilityQueryParam);
            }
        }

        public static class V3
        {
            public static class Custom
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="teamSize"></param>
                /// <param name="pickMode"></param>
                /// <returns></returns>
                public static Task<LolQueueEligibilityEligibility[]> Get(LeagueClientSession session, int teamSize,
                    string pickMode) =>
                    session.SendRequestAsync<LolQueueEligibilityEligibility[]>("GET",
                        "/lol-queue-eligibility/v3/custom",
                        new Dictionary<string, string> {{"teamSize", teamSize.ToString()}, {"pickMode", pickMode}});
            }

            public static class Eligibility
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerIds"></param>
                /// <param name="queueIds"></param>
                /// <returns></returns>
                public static Task<LolQueueEligibilityEligibility[]> Get(LeagueClientSession session,
                    long[] summonerIds, int[] queueIds) =>
                    session.SendRequestAsync<LolQueueEligibilityEligibility[]>("GET",
                        "/lol-queue-eligibility/v3/eligibility",
                        new Dictionary<string, string>
                        {
                            {"summonerIds", JsonConvert.SerializeObject(summonerIds)},
                            {"queueIds", JsonConvert.SerializeObject(queueIds)}
                        });
            }
        }
    }
}