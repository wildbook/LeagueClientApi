using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolGeoinfo
    {
        public static class V1
        {
            public static class GetLocation
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ip_address"></param>
                /// <returns></returns>
                public static Task<LolGeoinfoGeoInfo> Get(LeagueClientSession session, string ip_address) =>
                    session.SendRequestAsync<LolGeoinfoGeoInfo>("GET", "/lol-geoinfo/v1/getlocation",
                        query: new Dictionary<string, string> {{"ip_address", ip_address}});
            }

            public static class WhereAmI
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGeoinfoGeoInfoResponse> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGeoinfoGeoInfoResponse>("GET", "/lol-geoinfo/v1/whereami");
            }
        }
    }
}