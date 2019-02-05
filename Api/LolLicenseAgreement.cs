using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolLicenseAgreement
    {
        public static class V1
        {
            public static class Agreements
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLicenseAgreementLicenseAgreement[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLicenseAgreementLicenseAgreement[]>("GET",
                        "/lol-license-agreement/v1/agreements");

                public static class Accept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-license-agreement/v1/agreements/{id}/accept");
                }

                public static class Decline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-license-agreement/v1/agreements/{id}/decline");
                }
            }

            public static class AllAgreements
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolLicenseAgreementLicenseAgreement[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolLicenseAgreementLicenseAgreement[]>("GET",
                        "/lol-license-agreement/v1/all-agreements");
            }
        }
    }
}