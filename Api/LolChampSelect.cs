using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class LolChampSelect
    {
        public static class V1
        {
            public static class BannableChampions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectChampSelectBannableChampions>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectChampSelectBannableChampions>("GET",
                        "/lol-champ-select/v1/bannable-champions");
            }

            public static class BattleTraining
            {
                public static class Launch
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-champ-select/v1/battle-training/launch");
                }
            }

            public static class DisabledChampions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectChampSelectDisabledChampions> Get(
                    LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectChampSelectDisabledChampions>("GET",
                        "/lol-champ-select/v1/disabled-champions");
            }

            public static class PickableChampions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectChampSelectPickableChampions> Get(
                    LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectChampSelectPickableChampions>("GET",
                        "/lol-champ-select/v1/pickable-champions");
            }

            public static class PickableSkins
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectChampSelectPickableSkins> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectChampSelectPickableSkins>("GET",
                        "/lol-champ-select/v1/pickable-skins");
            }

            public static class Session
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectChampSelectSession> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectChampSelectSession>("GET", "/lol-champ-select/v1/session");

                public static class Actions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <param name="data"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Patch(LeagueClientSession session,
                        long id, LolChampSelectChampSelectAction data) =>
                        session.SendRequestAsync<dynamic>("PATCH",
                            $"/lol-champ-select/v1/session/actions/{id}", body: data);
                }

                public static class ActionsComplete
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/lol-champ-select/v1/session/actions/{id}/complete");
                }

                public static class MySelection
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="selection"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Patch(LeagueClientSession session,
                        LolChampSelectChampSelectMySelection selection) =>
                        session.SendRequestAsync<dynamic>("PATCH", "/lol-champ-select/v1/session/my-selection",
                            body: selection);

                    public static class Reroll
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session) =>
                            session.SendRequestAsync<dynamic>("POST",
                                "/lol-champ-select/v1/session/my-selection/reroll");
                    }
                }

                public static class Timer
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolChampSelectChampSelectTimer> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolChampSelectChampSelectTimer>("GET",
                            "/lol-champ-select/v1/session/timer");
                }

                public static class Trades
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolChampSelectChampSelectTradeContract[]> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolChampSelectChampSelectTradeContract[]>("GET",
                            "/lol-champ-select/v1/session/trades");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChampSelectChampSelectTradeContract> Get(LeagueClientSession session,
                        long id) =>
                        session.SendRequestAsync<LolChampSelectChampSelectTradeContract>("GET",
                            $"/lol-champ-select/v1/session/trades/{id}");
                }
                public static class TradesAccept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-champ-select/v1/session/trades/{id}/accept");
                }

                public static class TradesCancel
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-champ-select/v1/session/trades/{id}/cancel");
                }

                public static class TradesDecline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST", $"/lol-champ-select/v1/session/trades/{id}/decline");
                }

                public static class TradesRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChampSelectChampSelectTradeContract> Post(
                        LeagueClientSession session, long id) =>
                        session.SendRequestAsync<LolChampSelectChampSelectTradeContract>("POST",
                            $"/lol-champ-select/v1/session/trades/{id}/request");
                }
            }

            public static class TeamBoost
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectTeamBoost> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectTeamBoost>("GET",
                        "/lol-champ-select/v1/team-boost");

                public static class Purchase
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-champ-select/v1/team-boost/purchase");
                }
            }
        }
    }
}