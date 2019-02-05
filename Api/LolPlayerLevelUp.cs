using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPlayerLevelUp
    {
        public static class V1
        {
            public static class LevelUp
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<PlayerLevelUpEvent> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<PlayerLevelUpEvent>("GET", "/lol-player-level-up/v1/level-up");
            }

            public static class LevelUpNotifications
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="pluginName"></param>
                /// <returns></returns>
                public static Task<PlayerLevelUpEventAck> Get(LeagueClientSession session, string pluginName) =>
                    session.SendRequestAsync<PlayerLevelUpEventAck>("GET",
                        $"/lol-player-level-up/v1/level-up-notifications/{pluginName}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="pluginName"></param>
                /// <param name="levelUpEventAck"></param>
                /// <returns></returns>
                public static Task<PlayerLevelUpEventAck> Post(LeagueClientSession session, string pluginName,
                    PlayerLevelUpEventAck levelUpEventAck) =>
                    session.SendRequestAsync<PlayerLevelUpEventAck>("POST",
                        $"/lol-player-level-up/v1/level-up-notifications/{pluginName}", body: levelUpEventAck);
            }
        }
    }
}