using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolCollections
    {
        public static class V1
        {
            public static class Inventories
            {
                public static class Backdrop
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsSummonerBackdrop> Get(LeagueClientSession session,
                        long summonerId)
                        => session.SendRequestAsync<LolCollectionsCollectionsSummonerBackdrop>("GET",
                            $"/lol-collections/v1/inventories/{summonerId}/backdrop");
                }

                public static class ChampionMastery
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsChampionMastery> Get(
                        LeagueClientSession session, long summonerId)
                        => session.SendRequestAsync<LolCollectionsCollectionsChampionMastery>("GET",
                            $"/lol-collections/v1/inventories/{summonerId}/champion-mastery");

                    public static class Top
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsTopChampionMasteries> Get(
                            LeagueClientSession session, long summonerId, long limit, string sortRule = null)
                        {
                            var query = new Dictionary<string, string> { { "limit", limit.ToString() } };
                            if (!string.IsNullOrEmpty(sortRule)) query.Add("sortRule", sortRule);
                            return session.SendRequestAsync<LolCollectionsCollectionsTopChampionMasteries>("GET",
                                $"/lol-collections/v1/inventories/{summonerId}/champion-mastery/top", query);
                        }
                    }
                }

                public static class ChestEligibility
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsChestEligibility> Get(LeagueClientSession session)
                        => session.SendRequestAsync<LolCollectionsCollectionsChestEligibility>("GET",
                            "/lol-collections/v1/inventories/chest-eligibility");
                }
                public static class MasteryBook
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsMasteryBook> Get(LeagueClientSession session,
                        long summonerId)
                        => session.SendRequestAsync<LolCollectionsCollectionsMasteryBook>("GET",
                            $"/lol-collections/v1/inventories/{summonerId}/mastery-book");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsMasteryBook> Put(LeagueClientSession session,
                        long summonerId, LolCollectionsCollectionsMasteryBook resource)
                        => session.SendRequestAsync<LolCollectionsCollectionsMasteryBook>("PUT",
                            $"/lol-collections/v1/inventories/{summonerId}/mastery-book", body: resource);

                    public static class Pages
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="resource"></param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsMasteryPage> Put(LeagueClientSession session,
                            long summonerId, LolCollectionsCollectionsMasteryPage resource) =>
                            session.SendRequestAsync<LolCollectionsCollectionsMasteryPage>("PUT",
                                $"/lol-collections/v1/inventories/{summonerId}/mastery-book/pages", body: resource);

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="pageId"></param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsMasteryPage> Delete(LeagueClientSession session,
                            long summonerId, int pageId) =>
                            session.SendRequestAsync<LolCollectionsCollectionsMasteryPage>("DELETE",
                                $"/lol-collections/v1/inventories/{summonerId}/mastery-book/pages/{pageId}");
                    }
                }

                public static class RuneBook
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsRuneBook>
                        Get(LeagueClientSession session, long summonerId) =>
                        session.SendRequestAsync<LolCollectionsCollectionsRuneBook>("GET",
                            $"/lol-collections/v1/inventories/{summonerId}/rune-book");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="resource"></param>
                    /// <returns></returns>
                    public static Task<LolCollectionsCollectionsRuneBook> Put(LeagueClientSession session,
                        long summonerId, LolCollectionsCollectionsRuneBook resource) =>
                        session.SendRequestAsync<LolCollectionsCollectionsRuneBook>("PUT",
                            $"/lol-collections/v1/inventories/{summonerId}/rune-book", body: resource);

                    public static class Pages
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="resource"></param>
                        /// <returns></returns>
                        public static Task<LolPerksCollectionsRuneBook> Put(LeagueClientSession session,
                            long summonerId, int pageId, LolCollectionsCollectionsRuneBook resource) =>
                            session.SendRequestAsync<LolPerksCollectionsRuneBook>("PUT",
                                $"/lol-collections/v1/inventories/{summonerId}/rune-book/pages/{pageId}",
                                body: resource);

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolPerksCollectionsRuneBook>
                            Put(LeagueClientSession session, long summonerId, int pageId) =>
                            session.SendRequestAsync<LolPerksCollectionsRuneBook>("PUT",
                                $"/lol-collections/v1/inventories/{summonerId}/rune-book/select-page/{pageId}");
                    }

                    public static class Runes
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsRuneQuantities>
                            Get(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<LolCollectionsCollectionsRuneQuantities>("GET",
                                $"/lol-collections/v1/inventories/{summonerId}/runes");
                    }

                    public static class Spells
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsSummonerSpells>
                            Get(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<LolCollectionsCollectionsSummonerSpells>("GET",
                                $"/lol-collections/v1/inventories/{summonerId}/spells");
                    }

                    public static class SummonerIcons
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsSummonerIcons>
                            Get(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<LolCollectionsCollectionsSummonerIcons>("GET",
                                $"/lol-collections/v1/inventories/{summonerId}/summoner-icons");

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsSummonerIcon> Get(
                            LeagueClientSession session, long summonerId, int summonerIconId)
                            => session.SendRequestAsync<LolCollectionsCollectionsSummonerIcon>("GET",
                                $"/lol-collections/v2/inventories/{summonerId}/summoner-icons/{summonerIconId}");
                    }

                    public static class WardSkins
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsWardSkin[]> Get(LeagueClientSession session,
                            long summonerId)
                            => session.SendRequestAsync<LolCollectionsCollectionsWardSkin[]>("GET",
                                $"/lol-collections/v1/inventories/{summonerId}/ward-skins");

                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolCollectionsCollectionsWardSkin> Get(LeagueClientSession session,
                            long summonerId, long wardSkinId)
                            => session.SendRequestAsync<LolCollectionsCollectionsWardSkin>("GET",
                                $"/lol-collections/v1/inventories/{summonerId}/ward-skins/{wardSkinId}");
                    }
                }
            }
        }
    }
}