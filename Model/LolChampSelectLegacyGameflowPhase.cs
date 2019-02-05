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
    /// Defines LolChampSelectLegacyGameflowPhase
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LolChampSelectLegacyGameflowPhase
    {
        
        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,
        
        /// <summary>
        /// Enum Lobby for "Lobby"
        /// </summary>
        [EnumMember(Value = "Lobby")]
        Lobby,
        
        /// <summary>
        /// Enum Matchmaking for "Matchmaking"
        /// </summary>
        [EnumMember(Value = "Matchmaking")]
        Matchmaking,
        
        /// <summary>
        /// Enum CheckedIntoTournament for "CheckedIntoTournament"
        /// </summary>
        [EnumMember(Value = "CheckedIntoTournament")]
        CheckedIntoTournament,
        
        /// <summary>
        /// Enum ReadyCheck for "ReadyCheck"
        /// </summary>
        [EnumMember(Value = "ReadyCheck")]
        ReadyCheck,
        
        /// <summary>
        /// Enum ChampSelect for "ChampSelect"
        /// </summary>
        [EnumMember(Value = "ChampSelect")]
        ChampSelect,
        
        /// <summary>
        /// Enum GameStart for "GameStart"
        /// </summary>
        [EnumMember(Value = "GameStart")]
        GameStart,
        
        /// <summary>
        /// Enum FailedToLaunch for "FailedToLaunch"
        /// </summary>
        [EnumMember(Value = "FailedToLaunch")]
        FailedToLaunch,
        
        /// <summary>
        /// Enum InProgress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress,
        
        /// <summary>
        /// Enum Reconnect for "Reconnect"
        /// </summary>
        [EnumMember(Value = "Reconnect")]
        Reconnect,
        
        /// <summary>
        /// Enum WaitingForStats for "WaitingForStats"
        /// </summary>
        [EnumMember(Value = "WaitingForStats")]
        WaitingForStats,
        
        /// <summary>
        /// Enum PreEndOfGame for "PreEndOfGame"
        /// </summary>
        [EnumMember(Value = "PreEndOfGame")]
        PreEndOfGame,
        
        /// <summary>
        /// Enum EndOfGame for "EndOfGame"
        /// </summary>
        [EnumMember(Value = "EndOfGame")]
        EndOfGame,
        
        /// <summary>
        /// Enum TerminatedInError for "TerminatedInError"
        /// </summary>
        [EnumMember(Value = "TerminatedInError")]
        TerminatedInError
    }

}
