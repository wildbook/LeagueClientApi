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
    /// Defines LeaverBusterNotificationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LeaverBusterNotificationType
    {
        
        /// <summary>
        /// Enum Invalid for "Invalid"
        /// </summary>
        [EnumMember(Value = "Invalid")]
        Invalid,
        
        /// <summary>
        /// Enum TaintedWarning for "TaintedWarning"
        /// </summary>
        [EnumMember(Value = "TaintedWarning")]
        TaintedWarning,
        
        /// <summary>
        /// Enum PunishmentIncurred for "PunishmentIncurred"
        /// </summary>
        [EnumMember(Value = "PunishmentIncurred")]
        PunishmentIncurred,
        
        /// <summary>
        /// Enum PunishedGamesRemaining for "PunishedGamesRemaining"
        /// </summary>
        [EnumMember(Value = "PunishedGamesRemaining")]
        PunishedGamesRemaining,
        
        /// <summary>
        /// Enum Reforming for "Reforming"
        /// </summary>
        [EnumMember(Value = "Reforming")]
        Reforming
    }

}
