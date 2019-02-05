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
    /// RankedLeagueItemDTO
    /// </summary>
    [DataContract]
    public partial class RankedLeagueItemDTO :  IEquatable<RankedLeagueItemDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RankedLeagueItemDTO" /> class.
        /// </summary>
        /// <param name="ApexDaysUntilDecay">ApexDaysUntilDecay.</param>
        /// <param name="Inactive">Inactive.</param>
        /// <param name="LeagueName">LeagueName.</param>
        /// <param name="LeaguePoints">LeaguePoints.</param>
        /// <param name="Loses">Loses.</param>
        /// <param name="MiniSeries">MiniSeries.</param>
        /// <param name="PlayerOrTeamId">PlayerOrTeamId.</param>
        /// <param name="PlayerOrTeamName">PlayerOrTeamName.</param>
        /// <param name="QueueType">QueueType.</param>
        /// <param name="Rank">Rank.</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="Wins">Wins.</param>
        public RankedLeagueItemDTO(int? ApexDaysUntilDecay = default(int?), bool? Inactive = default(bool?), string LeagueName = default(string), int? LeaguePoints = default(int?), int? Loses = default(int?), RankedLeagueMiniSeriesDTO MiniSeries = default(RankedLeagueMiniSeriesDTO), string PlayerOrTeamId = default(string), string PlayerOrTeamName = default(string), LolRankedStatsRankedQueue QueueType = default(LolRankedStatsRankedQueue), RankedDivision Rank = default(RankedDivision), LolRankedStatsRankedTier Tier = default(LolRankedStatsRankedTier), int? Wins = default(int?))
        {
            this.ApexDaysUntilDecay = ApexDaysUntilDecay;
            this.Inactive = Inactive;
            this.LeagueName = LeagueName;
            this.LeaguePoints = LeaguePoints;
            this.Loses = Loses;
            this.MiniSeries = MiniSeries;
            this.PlayerOrTeamId = PlayerOrTeamId;
            this.PlayerOrTeamName = PlayerOrTeamName;
            this.QueueType = QueueType;
            this.Rank = Rank;
            this.Tier = Tier;
            this.Wins = Wins;
        }
        
        /// <summary>
        /// Gets or Sets ApexDaysUntilDecay
        /// </summary>
        [DataMember(Name="apexDaysUntilDecay", EmitDefaultValue=false)]
        public int? ApexDaysUntilDecay { get; set; }

        /// <summary>
        /// Gets or Sets Inactive
        /// </summary>
        [DataMember(Name="inactive", EmitDefaultValue=false)]
        public bool? Inactive { get; set; }

        /// <summary>
        /// Gets or Sets LeagueName
        /// </summary>
        [DataMember(Name="leagueName", EmitDefaultValue=false)]
        public string LeagueName { get; set; }

        /// <summary>
        /// Gets or Sets LeaguePoints
        /// </summary>
        [DataMember(Name="leaguePoints", EmitDefaultValue=false)]
        public int? LeaguePoints { get; set; }

        /// <summary>
        /// Gets or Sets Loses
        /// </summary>
        [DataMember(Name="loses", EmitDefaultValue=false)]
        public int? Loses { get; set; }

        /// <summary>
        /// Gets or Sets MiniSeries
        /// </summary>
        [DataMember(Name="miniSeries", EmitDefaultValue=false)]
        public RankedLeagueMiniSeriesDTO MiniSeries { get; set; }

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
        public LolRankedStatsRankedQueue QueueType { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public RankedDivision Rank { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public LolRankedStatsRankedTier Tier { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RankedLeagueItemDTO {\n");
            sb.Append("  ApexDaysUntilDecay: ").Append(ApexDaysUntilDecay).Append("\n");
            sb.Append("  Inactive: ").Append(Inactive).Append("\n");
            sb.Append("  LeagueName: ").Append(LeagueName).Append("\n");
            sb.Append("  LeaguePoints: ").Append(LeaguePoints).Append("\n");
            sb.Append("  Loses: ").Append(Loses).Append("\n");
            sb.Append("  MiniSeries: ").Append(MiniSeries).Append("\n");
            sb.Append("  PlayerOrTeamId: ").Append(PlayerOrTeamId).Append("\n");
            sb.Append("  PlayerOrTeamName: ").Append(PlayerOrTeamName).Append("\n");
            sb.Append("  QueueType: ").Append(QueueType).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
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
            return this.Equals(obj as RankedLeagueItemDTO);
        }

        /// <summary>
        /// Returns true if RankedLeagueItemDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of RankedLeagueItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RankedLeagueItemDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApexDaysUntilDecay == other.ApexDaysUntilDecay ||
                    this.ApexDaysUntilDecay != null &&
                    this.ApexDaysUntilDecay.Equals(other.ApexDaysUntilDecay)
                ) && 
                (
                    this.Inactive == other.Inactive ||
                    this.Inactive != null &&
                    this.Inactive.Equals(other.Inactive)
                ) && 
                (
                    this.LeagueName == other.LeagueName ||
                    this.LeagueName != null &&
                    this.LeagueName.Equals(other.LeagueName)
                ) && 
                (
                    this.LeaguePoints == other.LeaguePoints ||
                    this.LeaguePoints != null &&
                    this.LeaguePoints.Equals(other.LeaguePoints)
                ) && 
                (
                    this.Loses == other.Loses ||
                    this.Loses != null &&
                    this.Loses.Equals(other.Loses)
                ) && 
                (
                    this.MiniSeries == other.MiniSeries ||
                    this.MiniSeries != null &&
                    this.MiniSeries.Equals(other.MiniSeries)
                ) && 
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
                ) && 
                (
                    this.Wins == other.Wins ||
                    this.Wins != null &&
                    this.Wins.Equals(other.Wins)
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
                if (this.ApexDaysUntilDecay != null)
                    hash = hash * 59 + this.ApexDaysUntilDecay.GetHashCode();
                if (this.Inactive != null)
                    hash = hash * 59 + this.Inactive.GetHashCode();
                if (this.LeagueName != null)
                    hash = hash * 59 + this.LeagueName.GetHashCode();
                if (this.LeaguePoints != null)
                    hash = hash * 59 + this.LeaguePoints.GetHashCode();
                if (this.Loses != null)
                    hash = hash * 59 + this.Loses.GetHashCode();
                if (this.MiniSeries != null)
                    hash = hash * 59 + this.MiniSeries.GetHashCode();
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
                if (this.Wins != null)
                    hash = hash * 59 + this.Wins.GetHashCode();
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
