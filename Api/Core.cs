using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class Core
    {
        public static class RiotClient
        {
            public static class AddOrUpdateMetric
            {
                /// <summary>
                /// Adds or Updates a Metric
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="group">Name of metric group</param>
                /// <param name="object">Name of metric object</param>
                /// <param name="name">Name of metric item</param>
                /// <param name="value">Value to store</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string group, string @object,
                    string name, long value)
                {
                    var query = new Dictionary<string, string>
                {
                    {"group", group},
                    {"object", @object},
                    {"name", name},
                    {"value", value.ToString()}
                };

                    return session.SendRequestAsync("POST", "/riotclient/addorupdatemetric", query);
                }
            }
        }
    }
}