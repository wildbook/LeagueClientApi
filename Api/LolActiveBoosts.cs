using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolActiveBoosts
    {
        public static class ActiveBoosts
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<Model.ActiveBoosts> Get(LeagueClientSession session) =>
                session.SendRequestAsync<Model.ActiveBoosts>("GET", "/lol-active-boosts/v1/active-boosts");
        }
    }
}