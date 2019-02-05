using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolKickout
    {
        public static class V1
        {
            public static class Notification
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<KickoutMessage> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<KickoutMessage>("GET", "/lol-kickout/v1/notification");
            }
        }
    }
}