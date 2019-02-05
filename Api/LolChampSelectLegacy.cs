using LeagueClientApi.Model;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolChampSelectLegacy
    {
        public static class V1
        {
            public static class BannableChampions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectLegacyChampSelectBannableChampions>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectLegacyChampSelectBannableChampions>("GET",
                        "/lol-champ-select-legacy/v1/bannable-champions");
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
                        session.SendRequestAsync<dynamic>("POST", "/lol-champ-select-legacy/v1/battle-training/launch");
                }
            }

            public static class ImplementationActive
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<bool> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<bool>("GET", "/lol-champ-select-legacy/v1/implementation-active");
            }

            public static class PickableChampions
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectLegacyChampSelectPickableChampions>
                    Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectLegacyChampSelectPickableChampions>("GET",
                        "/lol-champ-select-legacy/v1/pickable-champions");
            }

            public static class Session
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectLegacyChampSelectSession> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectLegacyChampSelectSession>("GET",
                        "/lol-champ-select-legacy/v1/session");

                public static class Actions
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <param name="data"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Patch(LeagueClientSession session,
                        long id, LolChampSelectLegacyChampSelectAction data) =>
                        session.SendRequestAsync<dynamic>("PATCH",
                            $"/lol-champ-select-legacy/v1/session/actions/{id}", body: data);
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
                            $"/lol-champ-select-legacy/v1/session/actions/{id}/complete");
                }

                public static class MySelection
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="selection"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Patch(LeagueClientSession session,
                        LolChampSelectLegacyChampSelectMySelection selection) =>
                        session.SendRequestAsync<dynamic>("PATCH", "/lol-champ-select-legacy/v1/session/my-selection",
                            body: selection);

                    public static class Reroll
                    {
                        /// <summary>
                        /// </summary>
                        /// <param name="session">The session object</param>
                        /// <returns></returns>
                        public static Task<dynamic> Post(LeagueClientSession session) =>
                            session.SendRequestAsync<dynamic>("POST",
                                "/lol-champ-select-legacy/v1/session/my-selection/reroll");
                    }
                }

                public static class Timer
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolChampSelectLegacyChampSelectTimer> Get(LeagueClientSession session) =>
                        session.SendRequestAsync<LolChampSelectLegacyChampSelectTimer>("GET",
                            "/lol-champ-select-legacy/v1/session/timer");
                }

                public static class Trades
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<LolChampSelectLegacyChampSelectTradeContract[]> Get(
                        LeagueClientSession session) =>
                        session.SendRequestAsync<LolChampSelectLegacyChampSelectTradeContract[]>("GET",
                            "/lol-champ-select-legacy/v1/session/trades");

                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChampSelectLegacyChampSelectTradeContract> Get(LeagueClientSession session,
                        long id) =>
                        session.SendRequestAsync<LolChampSelectLegacyChampSelectTradeContract>("GET",
                            $"/lol-champ-select-legacy/v1/session/trades/{id}");
                }

                public static class TradesAccept
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/lol-champ-select-legacy/v1/session/trades/{id}/accept");
                }

                public static class TradesCancel
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/lol-champ-select-legacy/v1/session/trades/{id}/cancel");
                }

                public static class TradesDecline
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, long id) =>
                        session.SendRequestAsync<dynamic>("POST",
                            $"/lol-champ-select-legacy/v1/session/trades/{id}/decline");
                }

                public static class TradesRequest
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="id"></param>
                    /// <returns></returns>
                    public static Task<LolChampSelectLegacyChampSelectTradeContract> Post(
                        LeagueClientSession session, long id) =>
                        session.SendRequestAsync<LolChampSelectLegacyChampSelectTradeContract>("POST",
                            $"/lol-champ-select-legacy/v1/session/trades/{id}/request");
                }
            }

            public static class TeamBoost
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<LolChampSelectLegacyTeamBoost> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<LolChampSelectLegacyTeamBoost>("GET",
                        "/lol-champ-select-legacy/v1/team-boost");

                public static class Purchase
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session) =>
                        session.SendRequestAsync<dynamic>("POST", "/lol-champ-select-legacy/v1/team-boost/purchase");
                }
            }
        }
    }
}