using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolBanners
    {
        public static class V1
        {
            public static class CurrentSummoner
            {
                public static class Flags
                {
                    public static class Equipped
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<LolBannersBannerFlag> Get(LeagueClientSession session) =>
                            session.SendRequestAsync<LolBannersBannerFlag>("GET",
                                "/lol-banners/v1/current-summoner/flags/equipped");
                    }
                }
            }
        }
    }
}