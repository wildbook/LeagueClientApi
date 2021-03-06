/* 
 * LeagueClient
 *
 * 7.23.209.3517
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// LolLobbyTeamBuilderTbLobbyStateResource
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderTbLobbyStateResource :  IEquatable<LolLobbyTeamBuilderTbLobbyStateResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderTbLobbyStateResource" /> class.
        /// </summary>
        /// <param name="AfkCheckState">AfkCheckState.</param>
        /// <param name="ChampionSelectState">ChampionSelectState.</param>
        /// <param name="Counter">Counter.</param>
        /// <param name="MatchmakingState">MatchmakingState.</param>
        /// <param name="PhaseName">PhaseName.</param>
        /// <param name="PremadeState">PremadeState.</param>
        /// <param name="QueueId">QueueId.</param>
        public LolLobbyTeamBuilderTbLobbyStateResource(LolLobbyTeamBuilderAfkCheckStateV1 AfkCheckState = default(LolLobbyTeamBuilderAfkCheckStateV1), LolLobbyTeamBuilderChampionSelectStateV1 ChampionSelectState = default(LolLobbyTeamBuilderChampionSelectStateV1), int? Counter = default(int?), LolLobbyTeamBuilderTBDMatchmakingState MatchmakingState = default(LolLobbyTeamBuilderTBDMatchmakingState), string PhaseName = default(string), LolLobbyTeamBuilderTbLobbyPremadeStateResource PremadeState = default(LolLobbyTeamBuilderTbLobbyPremadeStateResource), int? QueueId = default(int?))
        {
            this.AfkCheckState = AfkCheckState;
            this.ChampionSelectState = ChampionSelectState;
            this.Counter = Counter;
            this.MatchmakingState = MatchmakingState;
            this.PhaseName = PhaseName;
            this.PremadeState = PremadeState;
            this.QueueId = QueueId;
        }
        
        /// <summary>
        /// Gets or Sets AfkCheckState
        /// </summary>
        [DataMember(Name="afkCheckState", EmitDefaultValue=false)]
        public LolLobbyTeamBuilderAfkCheckStateV1 AfkCheckState { get; set; }

        /// <summary>
        /// Gets or Sets ChampionSelectState
        /// </summary>
        [DataMember(Name="championSelectState", EmitDefaultValue=false)]
        public LolLobbyTeamBuilderChampionSelectStateV1 ChampionSelectState { get; set; }

        /// <summary>
        /// Gets or Sets Counter
        /// </summary>
        [DataMember(Name="counter", EmitDefaultValue=false)]
        public int? Counter { get; set; }

        /// <summary>
        /// Gets or Sets MatchmakingState
        /// </summary>
        [DataMember(Name="matchmakingState", EmitDefaultValue=false)]
        public LolLobbyTeamBuilderTBDMatchmakingState MatchmakingState { get; set; }

        /// <summary>
        /// Gets or Sets PhaseName
        /// </summary>
        [DataMember(Name="phaseName", EmitDefaultValue=false)]
        public string PhaseName { get; set; }

        /// <summary>
        /// Gets or Sets PremadeState
        /// </summary>
        [DataMember(Name="premadeState", EmitDefaultValue=false)]
        public LolLobbyTeamBuilderTbLobbyPremadeStateResource PremadeState { get; set; }

        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public int? QueueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderTbLobbyStateResource {\n");
            sb.Append("  AfkCheckState: ").Append(AfkCheckState).Append("\n");
            sb.Append("  ChampionSelectState: ").Append(ChampionSelectState).Append("\n");
            sb.Append("  Counter: ").Append(Counter).Append("\n");
            sb.Append("  MatchmakingState: ").Append(MatchmakingState).Append("\n");
            sb.Append("  PhaseName: ").Append(PhaseName).Append("\n");
            sb.Append("  PremadeState: ").Append(PremadeState).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as LolLobbyTeamBuilderTbLobbyStateResource);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderTbLobbyStateResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderTbLobbyStateResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderTbLobbyStateResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AfkCheckState == other.AfkCheckState ||
                    this.AfkCheckState != null &&
                    this.AfkCheckState.Equals(other.AfkCheckState)
                ) && 
                (
                    this.ChampionSelectState == other.ChampionSelectState ||
                    this.ChampionSelectState != null &&
                    this.ChampionSelectState.Equals(other.ChampionSelectState)
                ) && 
                (
                    this.Counter == other.Counter ||
                    this.Counter != null &&
                    this.Counter.Equals(other.Counter)
                ) && 
                (
                    this.MatchmakingState == other.MatchmakingState ||
                    this.MatchmakingState != null &&
                    this.MatchmakingState.Equals(other.MatchmakingState)
                ) && 
                (
                    this.PhaseName == other.PhaseName ||
                    this.PhaseName != null &&
                    this.PhaseName.Equals(other.PhaseName)
                ) && 
                (
                    this.PremadeState == other.PremadeState ||
                    this.PremadeState != null &&
                    this.PremadeState.Equals(other.PremadeState)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AfkCheckState != null)
                    hash = hash * 59 + this.AfkCheckState.GetHashCode();
                if (this.ChampionSelectState != null)
                    hash = hash * 59 + this.ChampionSelectState.GetHashCode();
                if (this.Counter != null)
                    hash = hash * 59 + this.Counter.GetHashCode();
                if (this.MatchmakingState != null)
                    hash = hash * 59 + this.MatchmakingState.GetHashCode();
                if (this.PhaseName != null)
                    hash = hash * 59 + this.PhaseName.GetHashCode();
                if (this.PremadeState != null)
                    hash = hash * 59 + this.PremadeState.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
