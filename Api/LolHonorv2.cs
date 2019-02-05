using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolHonorV2
    {
        public static class V1
        {
            public static class Ballot
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2Ballot> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2Ballot>("GET", "/lol-honor-v2/v1/ballot");
            }

            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2HonorConfig> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2HonorConfig>("GET", "/lol-honor-v2/v1/config");
            }

            public static class FullTeamVote
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2FullTeamVote> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2FullTeamVote>("GET", "/lol-honor-v2/v1/full-team-vote");
            }

            public static class HonorPlayer
            {
                //TODO: string?
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="honorPlayerRequest"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, LolHonorV2ApiHonorPlayerServerRequest honorPlayerRequest) => session.SendRequestAsync<dynamic>("POST", "/lol-honor-v2/v1/honor-player", body: honorPlayerRequest);
            }

            public static class LateRecognition
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2Honor[]> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2Honor[]>("GET", "/lol-honor-v2/v1/late-recognition");

                public static class Ack
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) => session.SendRequestAsync("POST", "/lol-honor-v2/v1/late-recognition/ack");
                }
            }

            public static class LatestEligibleGame
            {
                //TODO: int?
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) => session.SendRequestAsync<dynamic>("GET", "/lol-honor-v2/v1/latest-eligible-game");
            }

            public static class LevelChange
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2VendedHonorChange> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2VendedHonorChange>("GET", "/lol-honor-v2/v1/level-change");


                public static class Ack
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) => session.SendRequestAsync("POST", "/lol-honor-v2/v1/level-change/ack");
                }
            }

            public static class Profile
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2ProfileInfo> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2ProfileInfo>("GET", "/lol-honor-v2/v1/profile");
            }

            public static class Recognition
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2Honor[]> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2Honor[]>("GET", "/lol-honor-v2/v1/recognition");
            }

            public static class RewardGranted
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2Reward> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2Reward>("GET", "/lol-honor-v2/v1/reward-granted");

                public static class Ack
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session) => session.SendRequestAsync("POST", "/lol-honor-v2/v1/reward-granted/ack");
                }
            }

            public static class TeamChoices
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<int[]> Get(LeagueClientSession session) => session.SendRequestAsync<int[]>("GET", "/lol-honor-v2/v1/team-choices");
            }

            public static class VoteCompletion
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolHonorV2VoteCompletion> Get(LeagueClientSession session) => session.SendRequestAsync<LolHonorV2VoteCompletion>("GET", "/lol-honor-v2/v1/vote-completion");
            }
        }
    }
}