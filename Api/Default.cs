using System.Collections.Generic;
using System.Threading.Tasks;
using LeagueClientApi.Model;

namespace LeagueClientApi.Api
{
    public static class Default
    {
        public static class LoggingGetEntries
        {
            /// <summary>
            /// Gets all buffered log entries since the last call.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<LogEvent[]> Post(LeagueClientSession session) =>
                session.SendRequestAsync<LogEvent[]>("POST", "/LoggingGetEntries");
        }

        public static class LoggingMetrics
        {
            /// <summary>
            /// Returns all metrics
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session) =>
                session.SendRequestAsync<dynamic>("POST", "/LoggingMetrics");
        }

        public static class LoggingMetricsMetadata
        {
            /// <summary>
            /// Returns metadata for all metrics
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session) =>
                session.SendRequestAsync<dynamic>("POST", "/LoggingMetricsMetadata");
        }

        public static class LoggingStart
        {
            /// <summary>
            /// Initializes the logging system.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="buffered">Specifies whether logs will be buffered for LoggingGetEntries to work</param>
            /// <param name="severity">Minimum severity level to fire a log event</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, bool? buffered = null,
                LogSeverityLevels? severity = null)
            {
                var query = new Dictionary<string, string>();
                if (buffered.HasValue) query.Add("buffered", buffered.ToString());
                if (severity.HasValue) query.Add("severity", severity.ToString());
                return session.SendRequestAsync("POST", "/LoggingStart", query);
            }
        }

        public static class LoggingStop
        {
            /// <summary>
            /// Finalizes the logging system.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session) =>
                session.SendRequestAsync("POST", "/LoggingStop");
        }

        public static class MemoryFilterEnable
        {
            /// <summary>
            /// Memory filter prints to the log when memory is allocated or freed that matches the filter parameters set in MemoryFilterSet
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="enable">Enable/disable the memory filter</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, int? enable)
            {
                var query = new Dictionary<string, string>();
                if (enable.HasValue) query.Add("buffered", enable.ToString());
                return session.SendRequestAsync("POST", "/MemoryFilterEnable", query);
            }
        }

        public static class MemoryFilterSet
        {
            /// <summary>
            /// Sets the filter parameters for when to print to the log. Use MemoryFilterEnable to start/stop the print outs
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="minSize">Optional filter for minimum size to output</param>
            /// <param name="maxSize">Optional filter for maximum size to output</param>
            /// <param name="minAddress">Optional filter for minimum address in hex to output</param>
            /// <param name="maxAddress">Optional filter for maximum address in hex to output</param>
            /// <returns></returns>
            public static Task Post(LeagueClientSession session, int? minSize = null, int? maxSize = null,
                string minAddress = null, string maxAddress = null)
            {
                var query = new Dictionary<string, string>();
                if (minSize.HasValue) query.Add("minSize", minSize.ToString());
                if (minSize.HasValue) query.Add("maxSize", maxSize.ToString());
                if (minSize.HasValue) query.Add("minAddress", minAddress);
                if (minSize.HasValue) query.Add("maxAddress", maxAddress);
                return session.SendRequestAsync("POST", "/MemoryFilterSet", query);
            }
        }

        public static class MemoryPools
        {
            /// <summary>
            /// Returns current pool usage
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="contextName">Name of the context to find (optional)</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, string contextName = null)
            {
                var query = new Dictionary<string, string>();
                if (!string.IsNullOrEmpty(contextName)) query.Add("contextName", contextName);
                return session.SendRequestAsync<dynamic>("POST", "/MemoryPools", query);
            }
        }

        public static class MemoryStats
        {
            /// <summary>
            /// Returns aggregate information about memory usage
            /// 
            /// 'allocation_count' is deprecated, use 'allocated_count' instead.
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="contextName">Name of the context to find (optional)</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, string contextName = null)
            {
                var query = new Dictionary<string, string>();
                if (!string.IsNullOrEmpty(contextName)) query.Add("contextName", contextName);
                return session.SendRequestAsync<dynamic>("POST", "/MemoryStats", query);
            }
        }

        public static class MemoryUsage
        {
            /// <summary>
            /// Returns current memory usage by callstack site
            /// </summary>
            /// <param name="session">The session object</param>
            /// <param name="minSize">Minimum size of total allocations at call site in order to print (optional: MEMORYUSAGE_MINSIZE default)</param>
            /// <param name="minCount">Minimum count of total allocations at call site in order to print (optional: MEMORYUSAGE_MINCOUNT default)</param>
            /// <returns></returns>
            public static Task<dynamic> Post(LeagueClientSession session, int? minSize = null,
                int? minCount = null)
            {
                var query = new Dictionary<string, string>();
                if (minSize.HasValue) query.Add("minSize", minSize.ToString());
                if (minSize.HasValue) query.Add("minCount", minCount.ToString());
                return session.SendRequestAsync<dynamic>("POST", "/MemoryUsage", query);
            }
        }
    }
}