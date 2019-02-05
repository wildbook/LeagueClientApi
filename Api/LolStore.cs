using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;
using Newtonsoft.Json;

namespace LeagueClientApi.Api
{
    public static class LolStore
    {
        public static class V1
        {
            public static class Catalog
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="inventoryType"></param>
                /// <param name="itemId"></param>
                /// <returns></returns>
                public static Task<LolStoreCatalogItem[]> Get(LeagueClientSession session,
                    string[] inventoryType = null, int[] itemId = null)
                {
                    var query = new Dictionary<string, string>();
                    if (inventoryType != null) query.Add("inventoryType", JsonConvert.SerializeObject(inventoryType));
                    if (itemId != null) query.Add("itemId", JsonConvert.SerializeObject(itemId));
                    return session.SendRequestAsync<LolStoreCatalogItem[]>("GET", "/lol-store/v1/catalog", query);
                }
            }

            public static class GetLcuConfigs
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-store/v1/getLCUConfigs");
            }

            public static class GetStoreUrl
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string>("GET", "/lol-store/v1/getStoreUrl");
            }

            public static class LastPage
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string>("GET", "/lol-store/v1/lastPage");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="pageType"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string pageType) =>
                    session.SendRequestAsync("POST", "/lol-store/v1/lastPage", body: pageType);
            }

            public static class Login
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-store/v1/login");
            }

            public static class Notifications
            {
                public static class Acknowledge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string id) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-store/v1/notifications/acknowledge", body: id);
                }
            }

            public static class OrderNotifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolStoreOrderNotificationResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolStoreOrderNotificationResource[]>("GET",
                        "/lol-store/v1/order-notifications");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/lol-store/v1/order-notifications/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolStoreOrderNotificationResource> Get(LeagueClientSession session, long id) =>
                    session.SendRequestAsync<LolStoreOrderNotificationResource>("GET",
                        $"/lol-store/v1/order-notifications/{id}");
            }

            public static class PaymentDetails
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="action"></param>
                /// <param name="giftRecipientAccountId"></param>
                /// <param name="giftMessage"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string action,
                    long? giftRecipientAccountId = null, string giftMessage = null)
                {
                    var query = new Dictionary<string, string> {{"action", action}};
                    if (giftRecipientAccountId.HasValue)
                        query.Add("giftRecipientAccountId", giftRecipientAccountId.ToString());
                    if (giftMessage != null) query.Add("giftMessage", giftMessage);

                    return session.SendRequestAsync<dynamic>("GET", "/lol-store/v1/paymentDetails", query);
                }
            }

            public static class Skins
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="skinId"></param>
                /// <returns></returns>
                public static Task<LolStoreCatalogItem> Get(LeagueClientSession session, int skinId) =>
                    session.SendRequestAsync<LolStoreCatalogItem>("GET", $"/lol-store/v1/skins/{skinId}");

                public static class Purchase
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="skinId"></param>
                    /// <param name="cost"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, int skinId, LolStoreItemCost cost) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-store/v1/skins/{skinId}/purchase", body: cost);
                }
            }

            public static class Wallet
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolStoreWallet> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolStoreWallet>("GET", "/lol-store/v1/wallet");
            }

            /// <summary>
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="pageType"></param>
            /// <returns></returns>
            public static Task<dynamic> Get(LeagueClientSession session, string pageType) =>
                session.SendRequestAsync<dynamic>("GET", $"/lol-store/v1/{pageType}");
        }
    }
}