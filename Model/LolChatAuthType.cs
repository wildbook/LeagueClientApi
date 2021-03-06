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
    /// Defines LolChatAuthType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolChatAuthType
    {
        
        /// <summary>
        /// Enum Plain for "plain"
        /// </summary>
        [EnumMember(Value = "plain")]
        Plain,
        
        /// <summary>
        /// Enum RsoCreate for "rsoCreate"
        /// </summary>
        [EnumMember(Value = "rsoCreate")]
        RsoCreate,
        
        /// <summary>
        /// Enum RsoRefresh for "rsoRefresh"
        /// </summary>
        [EnumMember(Value = "rsoRefresh")]
        RsoRefresh
    }

}
