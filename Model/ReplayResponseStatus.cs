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
    /// Defines ReplayResponseStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReplayResponseStatus
    {
        
        /// <summary>
        /// Enum OK for "OK"
        /// </summary>
        [EnumMember(Value = "OK")]
        OK,
        
        /// <summary>
        /// Enum NOTFOUND for "NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND,
        
        /// <summary>
        /// Enum EXPIRED for "EXPIRED"
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED,
        
        /// <summary>
        /// Enum BADREQUEST for "BAD_REQUEST"
        /// </summary>
        [EnumMember(Value = "BAD_REQUEST")]
        BADREQUEST,
        
        /// <summary>
        /// Enum INTERNALSERVERERROR for "INTERNAL_SERVER_ERROR"
        /// </summary>
        [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
        INTERNALSERVERERROR
    }

}