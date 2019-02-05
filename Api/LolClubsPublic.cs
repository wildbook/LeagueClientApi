using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolClubsPublic
    {
        public static class V1
        {
            public static class Clubs
            {
                public static class Public
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerNames"></param>
                    /// <returns></returns>
                    public static Task<LolClubsPublicClubsPublicData[]>
                        Get(LeagueClientSession session, string summonerNames) =>
                        session.SendRequestAsync<LolClubsPublicClubsPublicData[]>("GET",
                            "/lol-clubs-public/v1/clubs/public",
                            new Dictionary<string, string> {{"summonerNames", summonerNames}});

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerId"></param>
                    /// <returns></returns>
                    public static Task<LolClubsPublicClubsPublicData>
                        Get(LeagueClientSession session, long summonerId) =>
                        session.SendRequestAsync<LolClubsPublicClubsPublicData>("GET",
                            $"/lol-clubs-public/v1/clubs/public/{summonerId}");

                    public static class Tag
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <param name="summonerId"></param>
                        /// <returns></returns>
                        public static Task<LolClubsPublicClubTag>
                            Get(LeagueClientSession session, long summonerId) =>
                            session.SendRequestAsync<LolClubsPublicClubTag>("GET",
                                $"/lol-clubs-public/v1/clubs/public/{summonerId}/tag");
                    }
                }
            }
        }
    }
}