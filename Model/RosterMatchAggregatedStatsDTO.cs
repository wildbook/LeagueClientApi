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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// RosterMatchAggregatedStatsDTO
    /// </summary>
    [DataContract]
    public partial class RosterMatchAggregatedStatsDTO :  IEquatable<RosterMatchAggregatedStatsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RosterMatchAggregatedStatsDTO" /> class.
        /// </summary>
        /// <param name="Duration">Duration.</param>
        /// <param name="GameId">GameId.</param>
        /// <param name="LoserBracket">LoserBracket.</param>
        /// <param name="OpponentLogo">OpponentLogo.</param>
        /// <param name="OpponentLogoColor">OpponentLogoColor.</param>
        /// <param name="OpponentShortName">OpponentShortName.</param>
        /// <param name="PlayerChampionIds">PlayerChampionIds.</param>
        /// <param name="Round">Round.</param>
        /// <param name="Win">Win.</param>
        public RosterMatchAggregatedStatsDTO(long? Duration = default(long?), long? GameId = default(long?), bool? LoserBracket = default(bool?), int? OpponentLogo = default(int?), int? OpponentLogoColor = default(int?), string OpponentShortName = default(string), Dictionary<string, int?> PlayerChampionIds = default(Dictionary<string, int?>), int? Round = default(int?), bool? Win = default(bool?))
        {
            this.Duration = Duration;
            this.GameId = GameId;
            this.LoserBracket = LoserBracket;
            this.OpponentLogo = OpponentLogo;
            this.OpponentLogoColor = OpponentLogoColor;
            this.OpponentShortName = OpponentShortName;
            this.PlayerChampionIds = PlayerChampionIds;
            this.Round = Round;
            this.Win = Win;
        }
        
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets LoserBracket
        /// </summary>
        [DataMember(Name="loserBracket", EmitDefaultValue=false)]
        public bool? LoserBracket { get; set; }

        /// <summary>
        /// Gets or Sets OpponentLogo
        /// </summary>
        [DataMember(Name="opponentLogo", EmitDefaultValue=false)]
        public int? OpponentLogo { get; set; }

        /// <summary>
        /// Gets or Sets OpponentLogoColor
        /// </summary>
        [DataMember(Name="opponentLogoColor", EmitDefaultValue=false)]
        public int? OpponentLogoColor { get; set; }

        /// <summary>
        /// Gets or Sets OpponentShortName
        /// </summary>
        [DataMember(Name="opponentShortName", EmitDefaultValue=false)]
        public string OpponentShortName { get; set; }

        /// <summary>
        /// Gets or Sets PlayerChampionIds
        /// </summary>
        [DataMember(Name="playerChampionIds", EmitDefaultValue=false)]
        public Dictionary<string, int?> PlayerChampionIds { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public int? Round { get; set; }

        /// <summary>
        /// Gets or Sets Win
        /// </summary>
        [DataMember(Name="win", EmitDefaultValue=false)]
        public bool? Win { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RosterMatchAggregatedStatsDTO {\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  LoserBracket: ").Append(LoserBracket).Append("\n");
            sb.Append("  OpponentLogo: ").Append(OpponentLogo).Append("\n");
            sb.Append("  OpponentLogoColor: ").Append(OpponentLogoColor).Append("\n");
            sb.Append("  OpponentShortName: ").Append(OpponentShortName).Append("\n");
            sb.Append("  PlayerChampionIds: ").Append(PlayerChampionIds).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  Win: ").Append(Win).Append("\n");
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
            return this.Equals(obj as RosterMatchAggregatedStatsDTO);
        }

        /// <summary>
        /// Returns true if RosterMatchAggregatedStatsDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of RosterMatchAggregatedStatsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RosterMatchAggregatedStatsDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.LoserBracket == other.LoserBracket ||
                    this.LoserBracket != null &&
                    this.LoserBracket.Equals(other.LoserBracket)
                ) && 
                (
                    this.OpponentLogo == other.OpponentLogo ||
                    this.OpponentLogo != null &&
                    this.OpponentLogo.Equals(other.OpponentLogo)
                ) && 
                (
                    this.OpponentLogoColor == other.OpponentLogoColor ||
                    this.OpponentLogoColor != null &&
                    this.OpponentLogoColor.Equals(other.OpponentLogoColor)
                ) && 
                (
                    this.OpponentShortName == other.OpponentShortName ||
                    this.OpponentShortName != null &&
                    this.OpponentShortName.Equals(other.OpponentShortName)
                ) && 
                (
                    this.PlayerChampionIds == other.PlayerChampionIds ||
                    this.PlayerChampionIds != null &&
                    this.PlayerChampionIds.SequenceEqual(other.PlayerChampionIds)
                ) && 
                (
                    this.Round == other.Round ||
                    this.Round != null &&
                    this.Round.Equals(other.Round)
                ) && 
                (
                    this.Win == other.Win ||
                    this.Win != null &&
                    this.Win.Equals(other.Win)
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
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.LoserBracket != null)
                    hash = hash * 59 + this.LoserBracket.GetHashCode();
                if (this.OpponentLogo != null)
                    hash = hash * 59 + this.OpponentLogo.GetHashCode();
                if (this.OpponentLogoColor != null)
                    hash = hash * 59 + this.OpponentLogoColor.GetHashCode();
                if (this.OpponentShortName != null)
                    hash = hash * 59 + this.OpponentShortName.GetHashCode();
                if (this.PlayerChampionIds != null)
                    hash = hash * 59 + this.PlayerChampionIds.GetHashCode();
                if (this.Round != null)
                    hash = hash * 59 + this.Round.GetHashCode();
                if (this.Win != null)
                    hash = hash * 59 + this.Win.GetHashCode();
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
