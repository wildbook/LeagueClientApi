using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolGameClientChat
    {
        public static class V1
        {
            public static class Buddies
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string[]>("GET", "/lol-game-client-chat/v1/buddies");
            }

            public static class IgnoredSummoners
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session, string summonerName) =>
                    session.SendRequestAsync("DELETE", "/lol-game-client-chat/v1/ignored-summoners",
                        new Dictionary<string, string> {{"summonerName", summonerName}});

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<string[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<string[]>("GET", "/lol-game-client-chat/v1/ignored-summoners");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string summonerName) =>
                    session.SendRequestAsync("POST", "/lol-game-client-chat/v1/ignored-summoners",
                        new Dictionary<string, string> {{"summonerName", summonerName}});
            }

            public static class InstantMessages
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string summonerName, string message) =>
                    session.SendRequestAsync("POST", "/lol-game-client-chat/v1/instant-messages",
                        new Dictionary<string, string> {{"summonerName", summonerName}, {"message", message}});
            }

            public static class PartyMessages
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string message) =>
                    session.SendRequestAsync("POST", "/lol-game-client-chat/v1/party-messages",
                        new Dictionary<string, string> {{"message", message}});
            }
        }
    }
}