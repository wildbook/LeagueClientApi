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
    /// Defines LolGameQueuesQueueCustomGameSpectatorPolicy
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolGameQueuesQueueCustomGameSpectatorPolicy
    {
        
        /// <summary>
        /// Enum NotAllowed for "NotAllowed"
        /// </summary>
        [EnumMember(Value = "NotAllowed")]
        NotAllowed,
        
        /// <summary>
        /// Enum LobbyAllowed for "LobbyAllowed"
        /// </summary>
        [EnumMember(Value = "LobbyAllowed")]
        LobbyAllowed,
        
        /// <summary>
        /// Enum FriendsAllowed for "FriendsAllowed"
        /// </summary>
        [EnumMember(Value = "FriendsAllowed")]
        FriendsAllowed,
        
        /// <summary>
        /// Enum AllAllowed for "AllAllowed"
        /// </summary>
        [EnumMember(Value = "AllAllowed")]
        AllAllowed
    }

}
