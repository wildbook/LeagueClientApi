using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolEsportStreamNotifications
    {
        public static class V1
        {
            public static class LiveStreams
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolEsportStreamNotificationsESportsLiveStreams>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolEsportStreamNotificationsESportsLiveStreams>("GET",
                        "/lol-esport-stream-notifications/v1/live-streams");
            }

            public static class StreamUrl
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-esport-stream-notifications/v1/stream-url");
            }

            //TODO: Wait for Riot to fix the api call.
            public static class SendStats
            {
                /// <summary>
                /// Note:
                /// Both arguments are supposed to be sent as a part of the endpoint's path, but the path does not include any variables.
                /// This probably means that this API call doesn't work as it should. 
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="eventType"></param>
                /// <param name="matchId"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string eventType, string matchId) =>
                    session.SendRequestAsync("POST", "/lol-esport-stream-notifications/v1/send-stats");
            }
        }
    }
}