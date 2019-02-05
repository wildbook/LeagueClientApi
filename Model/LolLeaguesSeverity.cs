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
    /// Defines LolLeaguesSeverity
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolLeaguesSeverity
    {
        
        /// <summary>
        /// Enum WARNING for "WARNING"
        /// </summary>
        [EnumMember(Value = "WARNING")]
        WARNING,
        
        /// <summary>
        /// Enum ALERT for "ALERT"
        /// </summary>
        [EnumMember(Value = "ALERT")]
        ALERT
    }

}
