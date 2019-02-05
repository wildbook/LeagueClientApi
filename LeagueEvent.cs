namespace LeagueClientApi
{
    public class LeagueEvent
    {
        public dynamic Data;
        public string Uri;
        public LeagueEventType EventType;
        public dynamic RawEvent;

        public LeagueEvent(dynamic data, string uri, LeagueEventType eventType, dynamic rawEvent)
        {
            Data = data;
            Uri = uri;
            EventType = eventType;
            RawEvent = rawEvent;
        }
    }

    public enum LeagueEventType
    {
        Undefined,
        Create,
        Update,
        Delete,
        Any
    }
}