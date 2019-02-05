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
    /// Defines LolRankedStatsRankedTier
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolRankedStatsRankedTier
    {
        
        /// <summary>
        /// Enum NOTRANKED for "NOT_RANKED"
        /// </summary>
        [EnumMember(Value = "NOT_RANKED")]
        NOTRANKED,
        
        /// <summary>
        /// Enum PROVISIONAL for "PROVISIONAL"
        /// </summary>
        [EnumMember(Value = "PROVISIONAL")]
        PROVISIONAL,
        
        /// <summary>
        /// Enum BRONZE for "BRONZE"
        /// </summary>
        [EnumMember(Value = "BRONZE")]
        BRONZE,
        
        /// <summary>
        /// Enum SILVER for "SILVER"
        /// </summary>
        [EnumMember(Value = "SILVER")]
        SILVER,
        
        /// <summary>
        /// Enum GOLD for "GOLD"
        /// </summary>
        [EnumMember(Value = "GOLD")]
        GOLD,
        
        /// <summary>
        /// Enum PLATINUM for "PLATINUM"
        /// </summary>
        [EnumMember(Value = "PLATINUM")]
        PLATINUM,
        
        /// <summary>
        /// Enum DIAMOND for "DIAMOND"
        /// </summary>
        [EnumMember(Value = "DIAMOND")]
        DIAMOND,
        
        /// <summary>
        /// Enum MASTER for "MASTER"
        /// </summary>
        [EnumMember(Value = "MASTER")]
        MASTER,
        
        /// <summary>
        /// Enum CHALLENGER for "CHALLENGER"
        /// </summary>
        [EnumMember(Value = "CHALLENGER")]
        CHALLENGER
    }

}
