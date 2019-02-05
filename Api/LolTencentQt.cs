using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolTencentQt
    {
        public static class V1
        {
            public static class UiStates
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-tencent-qt/v1/ui-states");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<TencentQTNotification> Get(LeagueClientSession session, string feature) =>
                    session.SendRequestAsync<TencentQTNotification>("GET", $"/lol-tencent-qt/v1/ui-states/{feature}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="state"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, string feature,
                    TencentQTNotification state) =>
                    session.SendRequestAsync<dynamic>("POST", $"/lol-tencent-qt/v1/ui-states/{feature}", body: state);
            }
        }
    }
}