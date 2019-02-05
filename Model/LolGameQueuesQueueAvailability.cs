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
    /// Defines LolGameQueuesQueueAvailability
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolGameQueuesQueueAvailability
    {
        
        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,
        
        /// <summary>
        /// Enum PlatformDisabled for "PlatformDisabled"
        /// </summary>
        [EnumMember(Value = "PlatformDisabled")]
        PlatformDisabled,
        
        /// <summary>
        /// Enum DoesntMeetRequirements for "DoesntMeetRequirements"
        /// </summary>
        [EnumMember(Value = "DoesntMeetRequirements")]
        DoesntMeetRequirements
    }

}
