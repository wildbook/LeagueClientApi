using LeagueClientApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class LolRecofriender
    {
        public static class V1
        {
            public static class Config
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RecofrienderConfig> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RecofrienderConfig>("GET", "/recofriender/v1/config");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="network"></param>
                /// <returns></returns>
                public static Task<RecofrienderNetworkConfig> Get(LeagueClientSession session, string network) =>
                    session.SendRequestAsync<RecofrienderNetworkConfig>("GET", $"/recofriender/v1/config/{network}");
            }

            public static class Contacts
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <param name="source"></param>
                /// <param name="friendState"></param>
                /// <returns></returns>
                public static Task<RecofrienderContactResource[]> Get(LeagueClientSession session,
                    long? accountId = null, string source = null, string friendState = null)
                {
                    var query = new Dictionary<string, string>();
                    if (accountId.HasValue) query.Add("accountId", accountId.ToString());
                    if (source != null) query.Add("source", source);
                    if (friendState != null) query.Add("friendState", friendState);

                    return session.SendRequestAsync<RecofrienderContactResource[]>("GET", "/recofriender/v1/contacts",
                        query);
                }

                public static class Available
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="accountId"></param>
                    /// <param name="retainInCache"></param>
                    /// <returns></returns>
                    public static Task<RecofrienderContactStateResource>
                        Post(LeagueClientSession session, long accountId, bool? retainInCache = null)
                    {
                        var query = new Dictionary<string, string>();
                        if (retainInCache.HasValue) query.Add("retainInCache", retainInCache.ToString());

                        return session.SendRequestAsync<RecofrienderContactStateResource>("POST",
                            $"/recofriender/v1/contacts/{accountId}/available", query);
                    }
                }

                public static class Dismissed
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="accountId"></param>
                    /// <param name="retainInCache"></param>
                    /// <returns></returns>
                    public static Task<RecofrienderContactStateResource>
                        Post(LeagueClientSession session, long accountId, bool? retainInCache = null)
                    {
                        var query = new Dictionary<string, string>();
                        if (retainInCache.HasValue) query.Add("retainInCache", retainInCache.ToString());

                        return session.SendRequestAsync<RecofrienderContactStateResource>("POST",
                            $"/recofriender/v1/contacts/{accountId}/dismissed", query);
                    }
                }

                public static class Invited
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="accountId"></param>
                    /// <param name="retainInCache"></param>
                    /// <returns></returns>
                    public static Task<RecofrienderContactStateResource>
                        Post(LeagueClientSession session, long accountId, bool? retainInCache = null)
                    {
                        var query = new Dictionary<string, string>();
                        if (retainInCache.HasValue) query.Add("retainInCache", retainInCache.ToString());

                        return session.SendRequestAsync<RecofrienderContactStateResource>("POST",
                            $"/recofriender/v1/contacts/{accountId}/invited", query);
                    }
                }
            }

            public static class Debug
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RecofrienderDebugConfig> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RecofrienderDebugConfig>("GET", "/recofriender/v1/debug");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="debugConfiguration"></param>
                /// <returns></returns>
                public static Task<RecofrienderDebugConfig> Put(LeagueClientSession session,
                    RecofrienderDebugConfig debugConfiguration) =>
                    session.SendRequestAsync<RecofrienderDebugConfig>("PUT", "/recofriender/v1/debug",
                        body: debugConfiguration);
            }

            public static class FaqUrl
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RecofrienderUrlResource> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RecofrienderUrlResource>("GET", "/recofriender/v1/faq-url");
            }

            public static class Registrations
            {
                //TODO: Decide how to handle multiple methods with identical signatures
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="cb"></param>
                /// <returns></returns>
                public static Task<RecofrienderLinkResource[]> Get(LeagueClientSession session, string cb = null)
                {
                    var query = new Dictionary<string, string>();
                    if (cb != null) query.Add("cb", cb);

                    return session.SendRequestAsync<RecofrienderLinkResource[]>("GET",
                        "/recofriender/v1/registrations", query);
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="network"></param>
                /// <returns></returns>
                public static Task<dynamic> Delete(LeagueClientSession session, string network) =>
                    session.SendRequestAsync<dynamic>("DELETE", $"/recofriender/v1/registrations/{network}");


                // This is called GetByNetwork as Get was already taken. For now this is a solution.
                // If it becomes more common that this is an issue, the standard probably has to change.
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RecofrienderLinkResource>
                    GetByNetwork(LeagueClientSession session, string network) =>
                    session.SendRequestAsync<RecofrienderLinkResource>("GET",
                        $"/recofriender/v1/registrations/{network}");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="network"></param>
                /// <returns></returns>
                public static Task<RecofrienderUrlResource> Post(LeagueClientSession session, string network) =>
                    session.SendRequestAsync<RecofrienderUrlResource>("POST",
                        $"/recofriender/v1/registrations/{network}");
            }
        }

        public static class V2
        {
            public static class Contacts
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/recofriender/v2/contacts");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RecofrienderContactResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RecofrienderContactResource[]>("GET", "/recofriender/v2/contacts");

                public static class Page
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="start"></param>
                    /// <param name="limit"></param>
                    /// <returns></returns>
                    public static Task<RecofrienderContactPaginationResource> Get(LeagueClientSession session,
                        long start, long limit) =>
                        session.SendRequestAsync<RecofrienderContactPaginationResource>("GET",
                            "/recofriender/v2/contacts/page",
                            new Dictionary<string, string> {{"start", start.ToString()}, {"limit", limit.ToString()}});
                }

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="accountId"></param>
                /// <returns></returns>
                public static Task<RecofrienderContactResource> Get(LeagueClientSession session, long accountId) =>
                    session.SendRequestAsync<RecofrienderContactResource>("GET",
                        $"/recofriender/v2/contacts/{accountId}");
            }


            public static class Dismissed
            {
                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task Delete(LeagueClientSession session) =>
                    session.SendRequestAsync("DELETE", "/recofriender/v2/dismissed");

                /// <summary>
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<RecofrienderContactResource[]> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<RecofrienderContactResource[]>("GET", "/recofriender/v2/dismissed");

                public static class Page
                {
                    /// <summary>
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="start"></param>
                    /// <param name="limit"></param>
                    /// <returns></returns>
                    public static Task<RecofrienderContactPaginationResource> Get(LeagueClientSession session,
                        long start, long limit) =>
                        session.SendRequestAsync<RecofrienderContactPaginationResource>("GET",
                            "/recofriender/v2/dismissed/page",
                            new Dictionary<string, string> {{"start", start.ToString()}, {"limit", limit.ToString()}});
                }
            }
        }
    }
}