using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class Performance
    {
        public static class V1
        {
            public static class Memory
            {
                /// <summary>
                /// Returns process memory status
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/performance/v1/memory");
            }

            public static class Process
            {
                /// <summary>
                /// Registers the process and includes it with the performance information.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="processId">Id of the process to track performance information.</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, int processId) =>
                    session.SendRequestAsync("POST", $"/performance/v1/process/{processId}");
            }

            public static class Report
            {
                /// <summary>
                /// Returns the various performance information for the cef processes
                /// </summary>
                /// <param name="session">The session object</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session) =>
                    session.SendRequestAsync<dynamic>("GET", "/performance/v1/report");

                public static class Restart
                {
                    /// <summary>
                    /// Restarts the CPU timing information and returns the results from PerfReportProcesses
                    /// </summary>
                    /// <param name="session">The session object</param>
                    /// <param name="sampleLength">Time in seconds for each CPU timing sample.</param>
                    /// <param name="sampleCount">Number of samples to record.</param>
                    /// <returns></returns>
                    public static Task<dynamic> Post(LeagueClientSession session, int? sampleLength = null,
                        int? sampleCount = null)
                    {
                        var query = new Dictionary<string, string>();
                        if (sampleLength.HasValue) query.Add("sampleLength", sampleLength.ToString());
                        if (sampleCount.HasValue) query.Add("sampleCount", sampleCount.ToString());
                        return session.SendRequestAsync<dynamic>("POST", "/performance/v1/report/restart", query);
                    }
                }
            }

            public static class SystemInfo
            {
                /// <summary>
                /// Restarts the CPU timing information and returns the results from PerfReportProcesses
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="full">Returns all available system information</param>
                /// <returns></returns>
                public static Task<dynamic> Get(LeagueClientSession session, int? full = null)
                {
                    var query = new Dictionary<string, string>();
                    if (full.HasValue) query.Add("sampleLength", full.ToString());
                    return session.SendRequestAsync<dynamic>("POST", "/performance/v1/system-info", query);
                }
            }
        }
    }
}