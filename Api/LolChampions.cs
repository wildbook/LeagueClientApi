using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolChampions
    {
        public static class V1
        {
            public static class Inventories
            {
                public static class Champions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampion[]> Get(LeagueClientSession session,
                        long summonerId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampion[]>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/champions");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <param name="championId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampion> Get(LeagueClientSession session,
                        long summonerId, int championId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampion>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}");

                    public static class Skins
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerId"></param>
                        /// <param name="championId"></param>
                        /// <param name="championSkinId"></param>
                        /// <returns></returns>
                        public static Task<LolChampionsCollectionsChampionSkin> Get(LeagueClientSession session,
                            long summonerId, int championId, int championSkinId) =>
                            session.SendRequestAsync<LolChampionsCollectionsChampionSkin>("GET",
                                $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins/{championSkinId}");

                        public static class Chromas
                        {
                            /// <summary>
                            /// </summary>
                            /// <param name="session">The session object</param>
                            /// <param name="summonerId"></param>
                            /// <param name="championId"></param>
                            /// <param name="skinId"></param>
                            /// <returns></returns>
                            public static Task<LolChampionsCollectionsChampionChroma[]> Get(
                                LeagueClientSession session, long summonerId, int championId, int skinId) =>
                                session.SendRequestAsync<LolChampionsCollectionsChampionChroma[]>("GET",
                                    $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins/{skinId}/chromas");
                        }
                    }
                }

                public static class ChampionsMinimal
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampionMinimal[]> Get(
                        LeagueClientSession session, long summonerId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampionMinimal[]>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/champions-minimal");
                }

                public static class ChampionsPlayableCount
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampionPlayableCounts> Get(
                        LeagueClientSession session, long summonerId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampionPlayableCounts>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/champions-playable-count");
                }

                public static class ChampionsSkins
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <param name="championId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampionSkin[]> Get(LeagueClientSession session,
                        long summonerId, int championId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampionSkin[]>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <param name="championId"></param>
                    /// <param name="championSkinId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampionSkin> Get(LeagueClientSession session,
                        long summonerId, int championId, int championSkinId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampionSkin>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/champions/{championId}/skins/{championSkinId}");
                }

                public static class SkinsMinimal
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolChampionsCollectionsChampionSkinMinimal[]> Get(
                        LeagueClientSession session, long summonerId) =>
                        session.SendRequestAsync<LolChampionsCollectionsChampionSkinMinimal[]>("GET",
                            $"/lol-champions/v1/inventories/{summonerId}/skins-minimal");
                }
            }
        }
    }
}