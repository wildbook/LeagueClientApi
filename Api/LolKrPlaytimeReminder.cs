using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolKrPlaytimeReminder
    {
        public static class V1
        {
            public static class Message
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-kr-playtime-reminder/v1/message");
            }

            public static class Playtime
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlaytimeReminder> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlaytimeReminder>("GET", "/lol-kr-playtime-reminder/v1/playtime");
            }
        }
    }
}