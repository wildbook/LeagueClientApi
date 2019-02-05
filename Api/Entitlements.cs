using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Entitlements
    {
        public static class Assets
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<EntitlementsToken> Get(LeagueClientSession session) =>
                session.SendRequestAsync<EntitlementsToken>("GET", "/entitlements/v1/token");
        }
    }
}