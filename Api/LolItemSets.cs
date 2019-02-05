using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolItemSets
    {
        public static class V1
        {
            public static class ItemSets
            {
                public static class Sets
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolItemSetsItemSets> Get(LeagueClientSession session, long summonerId) =>
                        session.SendRequestAsync<LolItemSetsItemSets>("GET",
                            $"/lol-item-sets/v1/item-sets/{summonerId}/sets");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <param name="itemSet"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, long summonerId, LolItemSetsItemSet itemSet) =>
                        session.SendRequestAsync("POST", $"/lol-item-sets/v1/item-sets/{summonerId}/sets",
                            body: itemSet);

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <param name="itemSets"></param>
                    /// <returns></returns>
                    public static Task
                        Put(LeagueClientSession session, long summonerId, LolItemSetsItemSets itemSets) =>
                        session.SendRequestAsync("PUT", $"/lol-item-sets/v1/item-sets/{summonerId}/sets",
                            body: itemSets);
                }
            }
        }
    }
}