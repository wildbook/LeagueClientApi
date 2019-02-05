using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Payments
    {
        public static class V1
        {
            public static class PmcStartUrl
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="options"></param>
                /// <returns></returns>
                public static Task<PaymentsFrontEndResult> Post(LeagueClientSession session,
                    PaymentsFrontEndRequest options) =>
                    session.SendRequestAsync<PaymentsFrontEndResult>("POST", "/payments/v1/pmc-start-url",
                        body: options);
            }
        }
    }
}