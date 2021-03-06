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
    /// Defines PatcherInjectedPatcherError
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PatcherInjectedPatcherError
    {
        
        /// <summary>
        /// Enum UnspecifiedError for "UnspecifiedError"
        /// </summary>
        [EnumMember(Value = "UnspecifiedError")]
        UnspecifiedError,
        
        /// <summary>
        /// Enum FailedToFindFile for "FailedToFindFile"
        /// </summary>
        [EnumMember(Value = "FailedToFindFile")]
        FailedToFindFile,
        
        /// <summary>
        /// Enum FailedToResolveHostName for "FailedToResolveHostName"
        /// </summary>
        [EnumMember(Value = "FailedToResolveHostName")]
        FailedToResolveHostName,
        
        /// <summary>
        /// Enum FailedFailedToWriteFile for "FailedFailedToWriteFile"
        /// </summary>
        [EnumMember(Value = "FailedFailedToWriteFile")]
        FailedFailedToWriteFile
    }

}
