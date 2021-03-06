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
    /// Defines LcdsInviteeState
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LcdsInviteeState
    {
        
        /// <summary>
        /// Enum CREATOR for "CREATOR"
        /// </summary>
        [EnumMember(Value = "CREATOR")]
        CREATOR,
        
        /// <summary>
        /// Enum PENDING for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,
        
        /// <summary>
        /// Enum DECLINED for "DECLINED"
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        DECLINED,
        
        /// <summary>
        /// Enum ACCEPTED for "ACCEPTED"
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED,
        
        /// <summary>
        /// Enum ACCEPTFAILED for "ACCEPT_FAILED"
        /// </summary>
        [EnumMember(Value = "ACCEPT_FAILED")]
        ACCEPTFAILED,
        
        /// <summary>
        /// Enum JOINED for "JOINED"
        /// </summary>
        [EnumMember(Value = "JOINED")]
        JOINED,
        
        /// <summary>
        /// Enum QUIT for "QUIT"
        /// </summary>
        [EnumMember(Value = "QUIT")]
        QUIT,
        
        /// <summary>
        /// Enum KICKED for "KICKED"
        /// </summary>
        [EnumMember(Value = "KICKED")]
        KICKED,
        
        /// <summary>
        /// Enum BANNED for "BANNED"
        /// </summary>
        [EnumMember(Value = "BANNED")]
        BANNED
    }

}
