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
    /// Defines MetricPriority
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricPriority
    {
        
        /// <summary>
        /// Enum Low for "low"
        /// </summary>
        [EnumMember(Value = "low")]
        Low,
        
        /// <summary>
        /// Enum Medium for "medium"
        /// </summary>
        [EnumMember(Value = "medium")]
        Medium,
        
        /// <summary>
        /// Enum High for "high"
        /// </summary>
        [EnumMember(Value = "high")]
        High
    }

}
