using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolPft
    {
        public static class V2
        {
            public static class Events
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="pftEvent"></param>
                /// <returns></returns>
                public static Task<dynamic> Post(LeagueClientSession session, LolPftPFTEvent pftEvent) => session.SendRequestAsync<dynamic>("POST", "/lol-pft/v2/events", body: pftEvent);
            }

            public static class Survey
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolPftPFTSurvey> Get(LeagueClientSession session) => session.SendRequestAsync<LolPftPFTSurvey>("GET", "/lol-pft/v2/survey");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="survey"></param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, LolPftPFTSurvey survey) => session.SendRequestAsync("POST", "/lol-pft/v2/survey", body: survey);
            }
        }
    }
}