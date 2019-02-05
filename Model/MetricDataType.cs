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
    /// Defines MetricDataType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricDataType
    {
        
        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        
        /// <summary>
        /// Enum Int for "int"
        /// </summary>
        [EnumMember(Value = "int")]
        Int,
        
        /// <summary>
        /// Enum Uint for "uint"
        /// </summary>
        [EnumMember(Value = "uint")]
        Uint,
        
        /// <summary>
        /// Enum Float for "float"
        /// </summary>
        [EnumMember(Value = "float")]
        Float,
        
        /// <summary>
        /// Enum Bool for "bool"
        /// </summary>
        [EnumMember(Value = "bool")]
        Bool,
        
        /// <summary>
        /// Enum String for "string"
        /// </summary>
        [EnumMember(Value = "string")]
        String
    }

}
