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
    /// Defines LolMatchmakingMatchmakingReadyCheckResponse
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolMatchmakingMatchmakingReadyCheckResponse
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Accepted for "Accepted"
        /// </summary>
        [EnumMember(Value = "Accepted")]
        Accepted,
        
        /// <summary>
        /// Enum Declined for "Declined"
        /// </summary>
        [EnumMember(Value = "Declined")]
        Declined
    }

}
