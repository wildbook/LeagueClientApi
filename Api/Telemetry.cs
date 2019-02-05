using System.Threading.Tasks;

namespace LeagueClientApi.Api
{
    public static class Telemetry
    {
        public static class V1
        {
            public static class CommonData
            {
                /// <summary>
                /// Adds/updates a common data key and value to be sent with every subsequent event.
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="key">The name of the common data key</param>
                /// <param name="value">The value of the common data key</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string key, string value) =>
                    session.SendRequestAsync("POST", $"/telemetry/v1/common-data/{key}", body: value);
            }

            public static class EventsWithPerfInfo
            {
                /// <summary>
                /// Adds a new event to be sent to Dradis and/or other analytics/monitoring data sinks.
                /// This will include current performance information along with the passed in data.
                /// Each call will record the performance counters then reset them for use in the next call.
                /// All events will have their eventType prefixed with ""
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="eventType">The name of the event type</param>
                /// <param name="eventData">A map of event data</param>
                /// <returns></returns>
                public static Task
                    Post(LeagueClientSession session, string eventType, dynamic eventData) =>
                    session.SendRequestAsync("POST", $"/telemetry/v1/events-with-perf-info/{eventType}",
                        body: eventData);
            }

            public static class Events
            {
                /// <summary>
                /// Adds a new event to be sent to Dradis and/or other analytics/monitoring data sinks.
                /// All events will have their eventType prefixed with ""
                /// </summary>
                /// <param name="session">The session object</param>
                /// <param name="eventType">The name of the event type</param>
                /// <param name="eventData">A map of event data</param>
                /// <returns></returns>
                public static Task Post(LeagueClientSession session, string eventType, dynamic eventData) =>
                    session.SendRequestAsync("POST", $"/telemetry/v1/events/{eventType}", body: eventData);
            }
        }
    }
}