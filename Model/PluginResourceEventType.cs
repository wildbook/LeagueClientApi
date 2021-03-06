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
    /// Defines PluginResourceEventType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PluginResourceEventType
    {
        
        /// <summary>
        /// Enum Create for "Create"
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,
        
        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,
        
        /// <summary>
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete
    }

}
