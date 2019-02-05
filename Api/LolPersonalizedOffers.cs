using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPersonalizedOffers
    {
        public static class V1
        {
            public static class Offers
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPersonalizedOffersUIOffer[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPersonalizedOffersUIOffer[]>("GET",
                        "/lol-personalized-offers/v1/offers");

                public static class Purchase
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="offerRequests"></param>
                    /// <returns></returns>
                    public static Task<LolPersonalizedOffersPurchaseResponse> Post(LeagueClientSession session,
                        LolPersonalizedOffersOfferRequests offerRequests) =>
                        session.SendRequestAsync<LolPersonalizedOffersPurchaseResponse>("POST",
                            "/lol-personalized-offers/v1/offers/purchase", body: offerRequests);

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolPersonalizedOffersPurchaseResponse> Post(LeagueClientSession session,
                        string id) =>
                        session.SendRequestAsync<LolPersonalizedOffersPurchaseResponse>("POST",
                            $"/lol-personalized-offers/v1/offers/{id}/purchase");
                }

                public static class Reveal
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="offerIds"></param>
                    /// <returns></returns>
                    public static Task<LolPersonalizedOffersUIOffer[]> Post(LeagueClientSession session,
                        LolPersonalizedOffersOfferIds offerIds) =>
                        session.SendRequestAsync<LolPersonalizedOffersUIOffer[]>("POST",
                            "/lol-personalized-offers/v1/offers/reveal", body: offerIds);

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolPersonalizedOffersUIOffer[]> Post(LeagueClientSession session,
                        string id) =>
                        session.SendRequestAsync<LolPersonalizedOffersUIOffer[]>("POST",
                            $"/lol-personalized-offers/v1/offers/{id}/reveal");
                }

                public static class Status
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("GET", "/lol-personalized-offers/v1/status");
                }
            }
        }
    }
}