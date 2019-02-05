using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolTeamBoosts
    {
        public static class V1
        {
            public static class TeamBoost
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<Model.TeamBoost> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<Model.TeamBoost>("GET", "/lol-team-boosts/v1/team-boost");

                public static class Purchase
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-team-boosts/v1/team-boost/purchase");
                }
            }
        }
    }
}