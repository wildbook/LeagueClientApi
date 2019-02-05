using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolGameflow
    {
        public static class V1
        {
            public static class AckFailedToLaunch
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name=""></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-gameflow/v1/ack-failed-to-launch");
            }

            public static class ActivePatcherLock
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-gameflow/v1/active-patcher-lock");
            }

            public static class Availability
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGameflowGameflowAvailability> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGameflowGameflowAvailability>("GET", "/lol-gameflow/v1/availability");
            }

            public static class BasicTutorial
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-gameflow/v1/basic-tutorial");

                public static class Start
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name=""></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/basic-tutorial/start");
                }
            }

            public static class BattleTraining
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-gameflow/v1/battle-training");

                public static class Start
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name=""></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/battle-training/start");
                }

                public static class Stop
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name=""></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/battle-training/stop");
                }
            }

            public static class ClientReceivedMessage
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="messsage"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string messsage) =>
                    session.SendRequestAsync("POST", "/lol-gameflow/v1/client-received-message", body: messsage);
            }

            public static class ExtraGameClientArgs
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string[]>("GET", "/lol-gameflow/v1/extra-game-client-args");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="extraGameClientArgs"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string[] extraGameClientArgs) =>
                    session.SendRequestAsync("POST", "/lol-gameflow/v1/extra-game-client-args",
                        body: extraGameClientArgs);
            }

            public static class GameflowMetadata
            {
                public static class PlayerStatus
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolGameflowPlayerStatus> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolGameflowPlayerStatus>("GET",
                            "/lol-gameflow/v1/gameflow-metadata/player-status");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="playerStatus"></param>
                    /// <returns></returns>
                    public static Task
                        Post(LeagueClientSession session, LolGameflowPlayerStatus playerStatus) =>
                        session.SendRequestAsync("POST", "/lol-gameflow/v1/gameflow-metadata/player-status",
                            body: playerStatus);
                }
            }

            public static class PreEndGameTransition
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="enabled"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, bool enabled) =>
                    session.SendRequestAsync("POST", "/lol-gameflow/v1/pre-end-game-transition",
                        new Dictionary<string, string> {{"enabled", enabled.ToString()}});
            }

            public static class Reconnect
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name=""></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/reconnect");
            }

            public static class Session
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGameflowGameflowSession> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGameflowGameflowSession>("GET", "/lol-gameflow/v1/session");

                public static class Dodge
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="dodgeData"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, LolGameflowGameflowGameDodge dodgeData) =>
                        session.SendRequestAsync("POST", "/lol-gameflow/v1/session/dodge", body: dodgeData);
                }

                public static class Event
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="_session"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, string _session) =>
                        session.SendRequestAsync("POST", "/lol-gameflow/v1/session/event", body: _session);
                }

                public static class GameConfiguration
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="queue"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, LolGameflowQueue queue) =>
                        session.SendRequestAsync("POST", "/lol-gameflow/v1/session/game-configuration",
                            body: queue);
                }

                public static class RequestLobby
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name=""></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/session/request-lobby");
                }

                public static class RequestTournamentCheckin
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<bool> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<bool>("POST", "/lol-gameflow/v1/session/request-tournament-checkin");
                }

                public static class TournamentEnded
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) =>
                        session.SendRequestAsync("POST", "/lol-gameflow/v1/session/tournament-ended");
                }
            }

            public static class Spectate
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/lol-gameflow/v1/spectate");

                public static class DelayedLaunch
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Get(LeagueClientSession session) =>
                        session.SendRequestAsync("GET", "/lol-gameflow/v1/spectate/delayed-launch");
                }

                public static class Launch
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="summonerName"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string summonerName) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/spectate/launch",
                            body: summonerName);
                }

                public static class Quit
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name=""></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/spectate/quit");
                }
            }

            public static class Tick
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name=""></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session) =>
                    session.SendRequestAsync("POST", "/lol-gameflow/v1/tick");
            }

            public static class Watch
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolGameflowGameflowWatchPhase> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolGameflowGameflowWatchPhase>("GET", "/lol-gameflow/v1/watch");

                public static class Launch
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="args"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, string[] args) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-gameflow/v1/watch/launch", body: args);
                }
            }
        }
    }
}