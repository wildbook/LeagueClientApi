using System;
using Newtonsoft.Json;

namespace LeagueClientApi.Errors
{
    // TODO: Look up the "correct" way of bundling error data with an exception. (override 'Data'?)

    // Officially called LolLobbyAmbassadorMessage?
    [JsonObject(MemberSerialization.OptIn)]
    public class RiotException : Exception
    {
        public string ErrorCode { get; }
        public int? HttpStatus { get; }
        public object ImplementationDetails { get; }
        public object Payload { get; }

        [JsonConstructor]
        public RiotException(string errorCode, int? httpStatus, object implementationDetails, string message,
            object payload) : base(message)
        {
            ErrorCode = errorCode;
            HttpStatus = httpStatus;
            ImplementationDetails = implementationDetails;
            Payload = payload;
        }
    }
}