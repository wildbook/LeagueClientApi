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
    /// LolClashRosterStats
    /// </summary>
    [DataContract]
    public partial class LolClashRosterStats :  IEquatable<LolClashRosterStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashRosterStats" /> class.
        /// </summary>
        /// <param name="PeriodStats">PeriodStats.</param>
        /// <param name="PlayerStats">PlayerStats.</param>
        /// <param name="RosterIconColorId">RosterIconColorId.</param>
        /// <param name="RosterIconId">RosterIconId.</param>
        /// <param name="RosterId">RosterId.</param>
        /// <param name="RosterName">RosterName.</param>
        /// <param name="RosterShortName">RosterShortName.</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="TournamentNameLocKey">TournamentNameLocKey.</param>
        /// <param name="TournamentPeriods">TournamentPeriods.</param>
        /// <param name="TournamentThemeId">TournamentThemeId.</param>
        public LolClashRosterStats(List<LolClashRosterPeriodAggregatedStats> PeriodStats = default(List<LolClashRosterPeriodAggregatedStats>), Dictionary<string, LolClashRosterPlayerAggregatedStats> PlayerStats = default(Dictionary<string, LolClashRosterPlayerAggregatedStats>), int? RosterIconColorId = default(int?), int? RosterIconId = default(int?), long? RosterId = default(long?), string RosterName = default(string), string RosterShortName = default(string), int? Tier = default(int?), string TournamentNameLocKey = default(string), int? TournamentPeriods = default(int?), int? TournamentThemeId = default(int?))
        {
            this.PeriodStats = PeriodStats;
            this.PlayerStats = PlayerStats;
            this.RosterIconColorId = RosterIconColorId;
            this.RosterIconId = RosterIconId;
            this.RosterId = RosterId;
            this.RosterName = RosterName;
            this.RosterShortName = RosterShortName;
            this.Tier = Tier;
            this.TournamentNameLocKey = TournamentNameLocKey;
            this.TournamentPeriods = TournamentPeriods;
            this.TournamentThemeId = TournamentThemeId;
        }
        
        /// <summary>
        /// Gets or Sets PeriodStats
        /// </summary>
        [DataMember(Name="periodStats", EmitDefaultValue=false)]
        public List<LolClashRosterPeriodAggregatedStats> PeriodStats { get; set; }

        /// <summary>
        /// Gets or Sets PlayerStats
        /// </summary>
        [DataMember(Name="playerStats", EmitDefaultValue=false)]
        public Dictionary<string, LolClashRosterPlayerAggregatedStats> PlayerStats { get; set; }

        /// <summary>
        /// Gets or Sets RosterIconColorId
        /// </summary>
        [DataMember(Name="rosterIconColorId", EmitDefaultValue=false)]
        public int? RosterIconColorId { get; set; }

        /// <summary>
        /// Gets or Sets RosterIconId
        /// </summary>
        [DataMember(Name="rosterIconId", EmitDefaultValue=false)]
        public int? RosterIconId { get; set; }

        /// <summary>
        /// Gets or Sets RosterId
        /// </summary>
        [DataMember(Name="rosterId", EmitDefaultValue=false)]
        public long? RosterId { get; set; }

        /// <summary>
        /// Gets or Sets RosterName
        /// </summary>
        [DataMember(Name="rosterName", EmitDefaultValue=false)]
        public string RosterName { get; set; }

        /// <summary>
        /// Gets or Sets RosterShortName
        /// </summary>
        [DataMember(Name="rosterShortName", EmitDefaultValue=false)]
        public string RosterShortName { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }

        /// <summary>
        /// Gets or Sets TournamentNameLocKey
        /// </summary>
        [DataMember(Name="tournamentNameLocKey", EmitDefaultValue=false)]
        public string TournamentNameLocKey { get; set; }

        /// <summary>
        /// Gets or Sets TournamentPeriods
        /// </summary>
        [DataMember(Name="tournamentPeriods", EmitDefaultValue=false)]
        public int? TournamentPeriods { get; set; }

        /// <summary>
        /// Gets or Sets TournamentThemeId
        /// </summary>
        [DataMember(Name="tournamentThemeId", EmitDefaultValue=false)]
        public int? TournamentThemeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashRosterStats {\n");
            sb.Append("  PeriodStats: ").Append(PeriodStats).Append("\n");
            sb.Append("  PlayerStats: ").Append(PlayerStats).Append("\n");
            sb.Append("  RosterIconColorId: ").Append(RosterIconColorId).Append("\n");
            sb.Append("  RosterIconId: ").Append(RosterIconId).Append("\n");
            sb.Append("  RosterId: ").Append(RosterId).Append("\n");
            sb.Append("  RosterName: ").Append(RosterName).Append("\n");
            sb.Append("  RosterShortName: ").Append(RosterShortName).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  TournamentNameLocKey: ").Append(TournamentNameLocKey).Append("\n");
            sb.Append("  TournamentPeriods: ").Append(TournamentPeriods).Append("\n");
            sb.Append("  TournamentThemeId: ").Append(TournamentThemeId).Append("\n");
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
            return this.Equals(obj as LolClashRosterStats);
        }

        /// <summary>
        /// Returns true if LolClashRosterStats instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashRosterStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashRosterStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PeriodStats == other.PeriodStats ||
                    this.PeriodStats != null &&
                    this.PeriodStats.SequenceEqual(other.PeriodStats)
                ) && 
                (
                    this.PlayerStats == other.PlayerStats ||
                    this.PlayerStats != null &&
                    this.PlayerStats.SequenceEqual(other.PlayerStats)
                ) && 
                (
                    this.RosterIconColorId == other.RosterIconColorId ||
                    this.RosterIconColorId != null &&
                    this.RosterIconColorId.Equals(other.RosterIconColorId)
                ) && 
                (
                    this.RosterIconId == other.RosterIconId ||
                    this.RosterIconId != null &&
                    this.RosterIconId.Equals(other.RosterIconId)
                ) && 
                (
                    this.RosterId == other.RosterId ||
                    this.RosterId != null &&
                    this.RosterId.Equals(other.RosterId)
                ) && 
                (
                    this.RosterName == other.RosterName ||
                    this.RosterName != null &&
                    this.RosterName.Equals(other.RosterName)
                ) && 
                (
                    this.RosterShortName == other.RosterShortName ||
                    this.RosterShortName != null &&
                    this.RosterShortName.Equals(other.RosterShortName)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) && 
                (
                    this.TournamentNameLocKey == other.TournamentNameLocKey ||
                    this.TournamentNameLocKey != null &&
                    this.TournamentNameLocKey.Equals(other.TournamentNameLocKey)
                ) && 
                (
                    this.TournamentPeriods == other.TournamentPeriods ||
                    this.TournamentPeriods != null &&
                    this.TournamentPeriods.Equals(other.TournamentPeriods)
                ) && 
                (
                    this.TournamentThemeId == other.TournamentThemeId ||
                    this.TournamentThemeId != null &&
                    this.TournamentThemeId.Equals(other.TournamentThemeId)
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
                if (this.PeriodStats != null)
                    hash = hash * 59 + this.PeriodStats.GetHashCode();
                if (this.PlayerStats != null)
                    hash = hash * 59 + this.PlayerStats.GetHashCode();
                if (this.RosterIconColorId != null)
                    hash = hash * 59 + this.RosterIconColorId.GetHashCode();
                if (this.RosterIconId != null)
                    hash = hash * 59 + this.RosterIconId.GetHashCode();
                if (this.RosterId != null)
                    hash = hash * 59 + this.RosterId.GetHashCode();
                if (this.RosterName != null)
                    hash = hash * 59 + this.RosterName.GetHashCode();
                if (this.RosterShortName != null)
                    hash = hash * 59 + this.RosterShortName.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                if (this.TournamentNameLocKey != null)
                    hash = hash * 59 + this.TournamentNameLocKey.GetHashCode();
                if (this.TournamentPeriods != null)
                    hash = hash * 59 + this.TournamentPeriods.GetHashCode();
                if (this.TournamentThemeId != null)
                    hash = hash * 59 + this.TournamentThemeId.GetHashCode();
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
