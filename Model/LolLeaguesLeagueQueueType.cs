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
    /// Defines LolLeaguesLeagueQueueType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolLeaguesLeagueQueueType
    {
        
        /// <summary>
        /// Enum NONE for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE,
        
        /// <summary>
        /// Enum SOLO5V5 for "SOLO5V5"
        /// </summary>
        [EnumMember(Value = "SOLO5V5")]
        SOLO5V5,
        
        /// <summary>
        /// Enum FLEXTT for "FLEXTT"
        /// </summary>
        [EnumMember(Value = "FLEXTT")]
        FLEXTT,
        
        /// <summary>
        /// Enum FLEXSR for "FLEXSR"
        /// </summary>
        [EnumMember(Value = "FLEXSR")]
        FLEXSR
    }

}
