using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPlayerBehavior
    {
        public static class V1
        {
            public static class Ban
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorBanNotification> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPlayerBehaviorBanNotification>("GET", "/lol-player-behavior/v1/ban");
            }

            public static class ChatRestriction
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorRestrictionNotification> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPlayerBehaviorRestrictionNotification>("GET",
                        "/lol-player-behavior/v1/chat-restriction");
            }

            public static class RankedRestriction
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorRestrictionNotification> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPlayerBehaviorRestrictionNotification>("GET",
                        "/lol-player-behavior/v1/ranked-restriction");
            }

            public static class ReformCard
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorReformCard> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPlayerBehaviorReformCard>("GET", "/lol-player-behavior/v1/reform-card");
            }

            public static class ReporterFeedback
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorReporterFeedback[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPlayerBehaviorReporterFeedback[]>("GET",
                        "/lol-player-behavior/v1/reporter-feedback");


                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorReporterFeedback> Delete(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<LolPlayerBehaviorReporterFeedback>("DELETE",
                        $"/lol-player-behavior/v1/reporter-feedback/{id}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="id"></param>
                /// <returns></returns>
                public static Task<LolPlayerBehaviorReporterFeedback> Get(LeagueClientSession session, string id) =>
                    session.SendRequestAsync<LolPlayerBehaviorReporterFeedback>("GET",
                        $"/lol-player-behavior/v1/reporter-feedback/{id}");
            }
        }
    }
}