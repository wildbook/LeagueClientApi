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
    /// Defines LolFeaturedModesGameflowAvailabilityState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolFeaturedModesGameflowAvailabilityState
    {
        
        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,
        
        /// <summary>
        /// Enum Initializing for "Initializing"
        /// </summary>
        [EnumMember(Value = "Initializing")]
        Initializing,
        
        /// <summary>
        /// Enum Patching for "Patching"
        /// </summary>
        [EnumMember(Value = "Patching")]
        Patching,
        
        /// <summary>
        /// Enum PlayerBanned for "PlayerBanned"
        /// </summary>
        [EnumMember(Value = "PlayerBanned")]
        PlayerBanned,
        
        /// <summary>
        /// Enum InGameFlow for "InGameFlow"
        /// </summary>
        [EnumMember(Value = "InGameFlow")]
        InGameFlow,
        
        /// <summary>
        /// Enum Configuration for "Configuration"
        /// </summary>
        [EnumMember(Value = "Configuration")]
        Configuration
    }

}