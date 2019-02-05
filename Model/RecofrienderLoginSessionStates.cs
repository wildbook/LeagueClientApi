/* 
 * LeagueClient
 *
 * 7.23.209.3517
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// Defines RecofrienderLoginSessionStates
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecofrienderLoginSessionStates
    {
        
        /// <summary>
        /// Enum INPROGRESS for "IN_PROGRESS"
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS,
        
        /// <summary>
        /// Enum SUCCEEDED for "SUCCEEDED"
        /// </summary>
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED,
        
        /// <summary>
        /// Enum LOGGINGOUT for "LOGGING_OUT"
        /// </summary>
        [EnumMember(Value = "LOGGING_OUT")]
        LOGGINGOUT,
        
        /// <summary>
        /// Enum ERROR for "ERROR"
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR
    }

}
