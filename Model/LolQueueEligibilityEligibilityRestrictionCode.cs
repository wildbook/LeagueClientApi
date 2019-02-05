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
    /// Defines LolQueueEligibilityEligibilityRestrictionCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolQueueEligibilityEligibilityRestrictionCode
    {
        
        /// <summary>
        /// Enum QueueDisabled for "QueueDisabled"
        /// </summary>
        [EnumMember(Value = "QueueDisabled")]
        QueueDisabled,
        
        /// <summary>
        /// Enum QueueUnsupported for "QueueUnsupported"
        /// </summary>
        [EnumMember(Value = "QueueUnsupported")]
        QueueUnsupported,
        
        /// <summary>
        /// Enum PlayerLevelRestriction for "PlayerLevelRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerLevelRestriction")]
        PlayerLevelRestriction,
        
        /// <summary>
        /// Enum PlayerTimedRestriction for "PlayerTimedRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerTimedRestriction")]
        PlayerTimedRestriction,
        
        /// <summary>
        /// Enum PlayerBannedRestriction for "PlayerBannedRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerBannedRestriction")]
        PlayerBannedRestriction,
        
        /// <summary>
        /// Enum PlayerAvailableChampionRestriction for "PlayerAvailableChampionRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerAvailableChampionRestriction")]
        PlayerAvailableChampionRestriction,
        
        /// <summary>
        /// Enum TeamDivisionRestriction for "TeamDivisionRestriction"
        /// </summary>
        [EnumMember(Value = "TeamDivisionRestriction")]
        TeamDivisionRestriction,
        
        /// <summary>
        /// Enum TeamMaxSizeRestriction for "TeamMaxSizeRestriction"
        /// </summary>
        [EnumMember(Value = "TeamMaxSizeRestriction")]
        TeamMaxSizeRestriction,
        
        /// <summary>
        /// Enum TeamMinSizeRestriction for "TeamMinSizeRestriction"
        /// </summary>
        [EnumMember(Value = "TeamMinSizeRestriction")]
        TeamMinSizeRestriction,
        
        /// <summary>
        /// Enum PlayerBingeRestriction for "PlayerBingeRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerBingeRestriction")]
        PlayerBingeRestriction,
        
        /// <summary>
        /// Enum PlayerDodgeRestriction for "PlayerDodgeRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerDodgeRestriction")]
        PlayerDodgeRestriction,
        
        /// <summary>
        /// Enum PlayerInGameRestriction for "PlayerInGameRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerInGameRestriction")]
        PlayerInGameRestriction,
        
        /// <summary>
        /// Enum PlayerLeaverBustedRestriction for "PlayerLeaverBustedRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerLeaverBustedRestriction")]
        PlayerLeaverBustedRestriction,
        
        /// <summary>
        /// Enum PlayerLeaverTaintedWarningRestriction for "PlayerLeaverTaintedWarningRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerLeaverTaintedWarningRestriction")]
        PlayerLeaverTaintedWarningRestriction,
        
        /// <summary>
        /// Enum PlayerMaxLevelRestriction for "PlayerMaxLevelRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerMaxLevelRestriction")]
        PlayerMaxLevelRestriction,
        
        /// <summary>
        /// Enum PlayerMinLevelRestriction for "PlayerMinLevelRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerMinLevelRestriction")]
        PlayerMinLevelRestriction,
        
        /// <summary>
        /// Enum PlayerMinorRestriction for "PlayerMinorRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerMinorRestriction")]
        PlayerMinorRestriction,
        
        /// <summary>
        /// Enum PlayerRankedSuspensionRestriction for "PlayerRankedSuspensionRestriction"
        /// </summary>
        [EnumMember(Value = "PlayerRankedSuspensionRestriction")]
        PlayerRankedSuspensionRestriction,
        
        /// <summary>
        /// Enum TeamHighMMRMaxSizeRestriction for "TeamHighMMRMaxSizeRestriction"
        /// </summary>
        [EnumMember(Value = "TeamHighMMRMaxSizeRestriction")]
        TeamHighMMRMaxSizeRestriction,
        
        /// <summary>
        /// Enum PrerequisiteQueuesNotPlayedRestriction for "PrerequisiteQueuesNotPlayedRestriction"
        /// </summary>
        [EnumMember(Value = "PrerequisiteQueuesNotPlayedRestriction")]
        PrerequisiteQueuesNotPlayedRestriction,
        
        /// <summary>
        /// Enum UnknownRestriction for "UnknownRestriction"
        /// </summary>
        [EnumMember(Value = "UnknownRestriction")]
        UnknownRestriction
    }

}
