using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPurchaseWidget
    {
        public static class V1
        {
            public static class Configuration
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPurchaseWidgetPurchaseWidgetConfig> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPurchaseWidgetPurchaseWidgetConfig>("GET",
                        "/lol-purchase-widget/v1/configuration");
            }

            public static class PurchaseItems
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="purchaseRequest"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolPurchaseWidgetPurchaseRequest purchaseRequest) => session.SendRequestAsync<dynamic>("POST",
                    "/lol-purchase-widget/v1/purchaseItems", body: purchaseRequest);
            }

            public static class ValidateItems
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="validationRequest"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session,
                    LolPurchaseWidgetValidationRequest validationRequest) => session.SendRequestAsync<dynamic>("POST",
                    "/lol-purchase-widget/v1/validateItems", body: validationRequest);
            }
        }
    }
}