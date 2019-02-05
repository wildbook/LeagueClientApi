using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPreEndOfGame
    {
        public static class V1
        {
            public static class Complete
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="sequenceEventName"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string sequenceEventName) =>
                    session.SendRequestAsync("POST",
                        $"/lol-pre-end-of-game/v1/complete/{sequenceEventName}");
            }

            public static class CurrentSequenceEvent
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPreEndOfGameSequenceEvent> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolPreEndOfGameSequenceEvent>("GET", "/lol-pre-end-of-game/v1/currentSequenceEvent");
            }

            public static class Registration
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="sequenceEventName"></param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session, string sequenceEventName) =>
                    session.SendRequestAsync("DELETE",
                        $"/lol-pre-end-of-game/v1/registration/{sequenceEventName}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="sequenceEventName"></param>
                /// <param name="priority"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string sequenceEventName, int priority) =>
                    session.SendRequestAsync("POST",
                        $"/lol-pre-end-of-game/v1/registration/{sequenceEventName}/{priority}");
            }
        }
    }
}