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
    /// Defines LolLobbyQueueGameCategory
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolLobbyQueueGameCategory
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom,
        
        /// <summary>
        /// Enum PvP for "PvP"
        /// </summary>
        [EnumMember(Value = "PvP")]
        PvP,
        
        /// <summary>
        /// Enum VersusAi for "VersusAi"
        /// </summary>
        [EnumMember(Value = "VersusAi")]
        VersusAi
    }

}
