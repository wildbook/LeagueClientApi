using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolGameSettings
    {
        public static class V1
        {
            public static class DidReset
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-game-settings/v1/didreset");
            }

            public static class GameSettings
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-game-settings/v1/game-settings");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Patch(LeagueClientSession session, dynamic settingsResource) =>
                    session.SendRequestAsync<dynamic>("PATCH", "/lol-game-settings/v1/game-settings",
                        body: settingsResource);
            }

            public static class GameSettingsSchema
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-game-settings/v1/game-settings-schema");
            }

            public static class InputSettings
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-game-settings/v1/input-settings");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="settingsResource"></param>
                /// <returns></returns>
                public static Task<dynamic> Patch(LeagueClientSession session, dynamic settingsResource) =>
                    session.SendRequestAsync<dynamic>("PATCH", "/lol-game-settings/v1/input-settings",
                        body: settingsResource);
            }

            public static class InputSettingsSchema
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-game-settings/v1/input-settings-schema");
            }

            public static class Ready
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-game-settings/v1/ready");
            }

            public static class ReloadPostGame
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-game-settings/v1/reload-post-game");
            }

            public static class Save
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-game-settings/v1/save");
            }
        }
    }
}