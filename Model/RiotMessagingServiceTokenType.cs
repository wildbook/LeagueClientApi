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
    /// Defines RiotMessagingServiceTokenType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RiotMessagingServiceTokenType
    {
        
        /// <summary>
        /// Enum Unavailable for "Unavailable"
        /// </summary>
        [EnumMember(Value = "Unavailable")]
        Unavailable,
        
        /// <summary>
        /// Enum Access for "Access"
        /// </summary>
        [EnumMember(Value = "Access")]
        Access,
        
        /// <summary>
        /// Enum Identity for "Identity"
        /// </summary>
        [EnumMember(Value = "Identity")]
        Identity
    }

}
