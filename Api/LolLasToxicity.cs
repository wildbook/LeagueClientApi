using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolLasToxicity
    {
        public static class V1
        {
            public static class Accounts
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, long accountId) =>
                    session.SendRequestAsync<dynamic>("GET",
                        $"/lol-las-toxicity/v1/accounts/{accountId}");
            }

            public static class Summoners
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="summonerId"></param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, long summonerId) =>
                    session.SendRequestAsync<dynamic>("GET",
                        $"/lol-las-toxicity/v1/summoners/{summonerId}");
            }
        }
    }
}