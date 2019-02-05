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
    /// LeagueTierAndRankDTO
    /// </summary>
    [DataContract]
    public partial class LeagueTierAndRankDTO :  IEquatable<LeagueTierAndRankDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeagueTierAndRankDTO" /> class.
        /// </summary>
        /// <param name="PlayerOrTeamId">PlayerOrTeamId.</param>
        /// <param name="PlayerOrTeamName">PlayerOrTeamName.</param>
        /// <param name="QueueType">QueueType.</param>
        /// <param name="Rank">Rank.</param>
        /// <param name="Tier">Tier.</param>
        public LeagueTierAndRankDTO(string PlayerOrTeamId = default(string), string PlayerOrTeamName = default(string), LeaguesLcdsQueueType QueueType = default(LeaguesLcdsQueueType), LeaguesLcdsLeagueRank Rank = default(LeaguesLcdsLeagueRank), LeaguesLcdsLeagueTier Tier = default(LeaguesLcdsLeagueTier))
        {
            this.PlayerOrTeamId = PlayerOrTeamId;
            this.PlayerOrTeamName = PlayerOrTeamName;
            this.QueueType = QueueType;
            this.Rank = Rank;
            this.Tier = Tier;
        }
        
        /// <summary>
        /// Gets or Sets PlayerOrTeamId
        /// </summary>
        [DataMember(Name="playerOrTeamId", EmitDefaultValue=false)]
        public string PlayerOrTeamId { get; set; }

        /// <summary>
        /// Gets or Sets PlayerOrTeamName
        /// </summary>
        [DataMember(Name="playerOrTeamName", EmitDefaultValue=false)]
        public string PlayerOrTeamName { get; set; }

        /// <summary>
        /// Gets or Sets QueueType
        /// </summary>
        [DataMember(Name="queueType", EmitDefaultValue=false)]
        public LeaguesLcdsQueueType QueueType { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public LeaguesLcdsLeagueRank Rank { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public LeaguesLcdsLeagueTier Tier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeagueTierAndRankDTO {\n");
            sb.Append("  PlayerOrTeamId: ").Append(PlayerOrTeamId).Append("\n");
            sb.Append("  PlayerOrTeamName: ").Append(PlayerOrTeamName).Append("\n");
            sb.Append("  QueueType: ").Append(QueueType).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
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
            return this.Equals(obj as LeagueTierAndRankDTO);
        }

        /// <summary>
        /// Returns true if LeagueTierAndRankDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LeagueTierAndRankDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeagueTierAndRankDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlayerOrTeamId == other.PlayerOrTeamId ||
                    this.PlayerOrTeamId != null &&
                    this.PlayerOrTeamId.Equals(other.PlayerOrTeamId)
                ) && 
                (
                    this.PlayerOrTeamName == other.PlayerOrTeamName ||
                    this.PlayerOrTeamName != null &&
                    this.PlayerOrTeamName.Equals(other.PlayerOrTeamName)
                ) && 
                (
                    this.QueueType == other.QueueType ||
                    this.QueueType != null &&
                    this.QueueType.Equals(other.QueueType)
                ) && 
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
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
                if (this.PlayerOrTeamId != null)
                    hash = hash * 59 + this.PlayerOrTeamId.GetHashCode();
                if (this.PlayerOrTeamName != null)
                    hash = hash * 59 + this.PlayerOrTeamName.GetHashCode();
                if (this.QueueType != null)
                    hash = hash * 59 + this.QueueType.GetHashCode();
                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
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
