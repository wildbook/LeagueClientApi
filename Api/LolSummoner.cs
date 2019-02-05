using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;
using Newtonsoft.Json;

namespace LeagueClientApi.Api
{
    public static class LolSummoner
    {
        public static class V1
        {
            public static class CheckNameAvailability
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, string name) =>
                    session.SendRequestAsync<dynamic>("GET", $"/lol-summoner/v1/check-name-availability/{name}");
            }

            public static class CurrentSummoner
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="name"></param>
                /// <returns></returns>
                public static Task<LolSummonerSummoner> Get(LeagueClientSession session, string name) =>
                    session.SendRequestAsync<LolSummonerSummoner>("GET",
                        $"/lol-summoner/v1/check-name-availability/{name}");

                public static class Autofill
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolLobbyAutoFillDto> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolLobbyAutoFillDto>("GET",
                            "/lol-summoner/v1/current-summoner/autofill");
                }

                public static class Icon
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="body"></param>
                    /// <returns></returns>
                    public static Task<LolSummonerSummoner> Put(LeagueClientSession session,
                        LolSummonerSummonerIcon body) => session.SendRequestAsync<LolSummonerSummoner>("PUT",
                        "/lol-summoner/v1/current-summoner/icon", body: body);
                }

                public static class Name
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="name"></param>
                    /// <returns></returns>
                    public static Task<LolSummonerSummoner> Post(LeagueClientSession session, string name) =>
                        session.SendRequestAsync<LolSummonerSummoner>("POST", "/lol-summoner/v1/current-summoner/name",
                            body: name);
                }

                public static class RerollPoints
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolPerksSummonerRerollPoints> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolPerksSummonerRerollPoints>("GET",
                            "/lol-summoner/v1/current-summoner/rerollPoints");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="points"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, LolSummonerEndOfGamePoints points) =>
                        session.SendRequestAsync("POST", "/lol-summoner/v1/current-summoner/rerollPoints",
                            body: points);

                    public static class Decrement
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task Post(LeagueClientSession session) => session.SendRequestAsync("POST",
                            "/lol-summoner/v1/current-summoner/rerollPoints/decrement");
                    }

                    public static class Reset
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task Post(LeagueClientSession session) => session.SendRequestAsync("POST",
                            "/lol-summoner/v1/current-summoner/rerollPoints/reset");
                    }
                }

                public static class TbRerollPoints
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="points"></param>
                    /// <returns></returns>
                    public static Task Post(LeagueClientSession session, LolSummonerEndOfGamePoints points) =>
                        session.SendRequestAsync("POST", "/lol-summoner/v1/current-summoner/tbRerollPoints",
                            body: points);
                }

                public static class XpInfo
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolSummonerSummoner> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<LolSummonerSummoner>("POST",
                            "/lol-summoner/v1/current-summoner/xpInfo");
                }

                public static class Summoners
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="name"></param>
                    /// <returns></returns>
                    public static Task<LolSummonerSummoner> Get(LeagueClientSession session, string name) =>
                        session.SendRequestAsync<LolSummonerSummoner>("GET", "/lol-summoner/v1/summoners",
                            new Dictionary<string, string> {{"name", name}});

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="name"></param>
                    /// <returns></returns>
                    public static Task<LolSummonerInternalSummoner> Post(LeagueClientSession session,
                        LolSummonerSummonerRequestedName name) =>
                        session.SendRequestAsync<LolSummonerInternalSummoner>("POST", "/lol-summoner/v1/summoners",
                            body: name);

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolSummonerSummoner> Get(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<LolSummonerSummoner>("GET", $"/lol-summoner/v1/summoners/{id}");
                }
            }
        }

        public static class V2
        {
            public static class SummonerIcons
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ids"></param>
                /// <returns></returns>
                public static Task<LolSummonerSummonerIdAndIcon[]>
                    Get(LeagueClientSession session, long[] ids) =>
                    session.SendRequestAsync<LolSummonerSummonerIdAndIcon[]>("GET",
                        "/lol-summoner/v2/summoner-icons",
                        new Dictionary<string, string>
                        {
                            {"ids", JsonConvert.SerializeObject(ids)}
                        });
            }

            public static class SummonerNames
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="ids"></param>
                /// <returns></returns>
                public static Task<LolSummonerSummonerIdAndName[]>
                    Get(LeagueClientSession session, long[] ids) =>
                    session.SendRequestAsync<LolSummonerSummonerIdAndName[]>("GET", "/plugin-name/endpoint",
                        new Dictionary<string, string>
                        {
                            {"ids", JsonConvert.SerializeObject(ids)}
                        });
            }

            public static class Summoners
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="name"></param>
                /// <param name="ids"></param>
                /// <returns></returns>
                public static Task<LolSummonerSummonerIdAndName[]> Get(LeagueClientSession session, string name = null, long[] ids = null)
                {
                    var query = new Dictionary<string, string>();

                    if (name != null) query.Add("name", name);
                    if (ids != null) query.Add("ids", JsonConvert.SerializeObject(ids));

                    return session.SendRequestAsync<LolSummonerSummonerIdAndName[]>("GET", "/plugin-name/endpoint",
                        query);
                }
            }
        }
    }
}