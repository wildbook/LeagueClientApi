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
    /// Help format for remoting functions and types.
    /// </summary>
    /// <value>Help format for remoting functions and types.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RemotingHelpFormat
    {
        
        /// <summary>
        /// Enum Full for "Full"
        /// </summary>
        [EnumMember(Value = "Full")]
        Full,
        
        /// <summary>
        /// Enum Epytext for "Epytext"
        /// </summary>
        [EnumMember(Value = "Epytext")]
        Epytext,
        
        /// <summary>
        /// Enum Brief for "Brief"
        /// </summary>
        [EnumMember(Value = "Brief")]
        Brief,
        
        /// <summary>
        /// Enum Console for "Console"
        /// </summary>
        [EnumMember(Value = "Console")]
        Console
    }

}
