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
    /// LolClashTournament
    /// </summary>
    [DataContract]
    public partial class LolClashTournament :  IEquatable<LolClashTournament>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashTournament" /> class.
        /// </summary>
        /// <param name="AllowRosterCreation">AllowRosterCreation.</param>
        /// <param name="AllowRosterDisband">AllowRosterDisband.</param>
        /// <param name="BuyInOptions">BuyInOptions.</param>
        /// <param name="EndTimeMs">EndTimeMs.</param>
        /// <param name="EntryFee">EntryFee.</param>
        /// <param name="Id">Id.</param>
        /// <param name="MaxSubstitutes">MaxSubstitutes.</param>
        /// <param name="NameLocKey">NameLocKey.</param>
        /// <param name="Phases">Phases.</param>
        /// <param name="RewardConfig">RewardConfig.</param>
        /// <param name="RosterSize">RosterSize.</param>
        /// <param name="ScoutingDurationMs">ScoutingDurationMs.</param>
        /// <param name="StartTimeMs">StartTimeMs.</param>
        /// <param name="ThemeId">ThemeId.</param>
        public LolClashTournament(bool? AllowRosterCreation = default(bool?), bool? AllowRosterDisband = default(bool?), List<int?> BuyInOptions = default(List<int?>), long? EndTimeMs = default(long?), int? EntryFee = default(int?), long? Id = default(long?), int? MaxSubstitutes = default(int?), string NameLocKey = default(string), List<LolClashTournamentPhase> Phases = default(List<LolClashTournamentPhase>), List<ClashRewardConfigClient> RewardConfig = default(List<ClashRewardConfigClient>), int? RosterSize = default(int?), long? ScoutingDurationMs = default(long?), long? StartTimeMs = default(long?), int? ThemeId = default(int?))
        {
            this.AllowRosterCreation = AllowRosterCreation;
            this.AllowRosterDisband = AllowRosterDisband;
            this.BuyInOptions = BuyInOptions;
            this.EndTimeMs = EndTimeMs;
            this.EntryFee = EntryFee;
            this.Id = Id;
            this.MaxSubstitutes = MaxSubstitutes;
            this.NameLocKey = NameLocKey;
            this.Phases = Phases;
            this.RewardConfig = RewardConfig;
            this.RosterSize = RosterSize;
            this.ScoutingDurationMs = ScoutingDurationMs;
            this.StartTimeMs = StartTimeMs;
            this.ThemeId = ThemeId;
        }
        
        /// <summary>
        /// Gets or Sets AllowRosterCreation
        /// </summary>
        [DataMember(Name="allowRosterCreation", EmitDefaultValue=false)]
        public bool? AllowRosterCreation { get; set; }

        /// <summary>
        /// Gets or Sets AllowRosterDisband
        /// </summary>
        [DataMember(Name="allowRosterDisband", EmitDefaultValue=false)]
        public bool? AllowRosterDisband { get; set; }

        /// <summary>
        /// Gets or Sets BuyInOptions
        /// </summary>
        [DataMember(Name="buyInOptions", EmitDefaultValue=false)]
        public List<int?> BuyInOptions { get; set; }

        /// <summary>
        /// Gets or Sets EndTimeMs
        /// </summary>
        [DataMember(Name="endTimeMs", EmitDefaultValue=false)]
        public long? EndTimeMs { get; set; }

        /// <summary>
        /// Gets or Sets EntryFee
        /// </summary>
        [DataMember(Name="entryFee", EmitDefaultValue=false)]
        public int? EntryFee { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets MaxSubstitutes
        /// </summary>
        [DataMember(Name="maxSubstitutes", EmitDefaultValue=false)]
        public int? MaxSubstitutes { get; set; }

        /// <summary>
        /// Gets or Sets NameLocKey
        /// </summary>
        [DataMember(Name="nameLocKey", EmitDefaultValue=false)]
        public string NameLocKey { get; set; }

        /// <summary>
        /// Gets or Sets Phases
        /// </summary>
        [DataMember(Name="phases", EmitDefaultValue=false)]
        public List<LolClashTournamentPhase> Phases { get; set; }

        /// <summary>
        /// Gets or Sets RewardConfig
        /// </summary>
        [DataMember(Name="rewardConfig", EmitDefaultValue=false)]
        public List<ClashRewardConfigClient> RewardConfig { get; set; }

        /// <summary>
        /// Gets or Sets RosterSize
        /// </summary>
        [DataMember(Name="rosterSize", EmitDefaultValue=false)]
        public int? RosterSize { get; set; }

        /// <summary>
        /// Gets or Sets ScoutingDurationMs
        /// </summary>
        [DataMember(Name="scoutingDurationMs", EmitDefaultValue=false)]
        public long? ScoutingDurationMs { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeMs
        /// </summary>
        [DataMember(Name="startTimeMs", EmitDefaultValue=false)]
        public long? StartTimeMs { get; set; }

        /// <summary>
        /// Gets or Sets ThemeId
        /// </summary>
        [DataMember(Name="themeId", EmitDefaultValue=false)]
        public int? ThemeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashTournament {\n");
            sb.Append("  AllowRosterCreation: ").Append(AllowRosterCreation).Append("\n");
            sb.Append("  AllowRosterDisband: ").Append(AllowRosterDisband).Append("\n");
            sb.Append("  BuyInOptions: ").Append(BuyInOptions).Append("\n");
            sb.Append("  EndTimeMs: ").Append(EndTimeMs).Append("\n");
            sb.Append("  EntryFee: ").Append(EntryFee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaxSubstitutes: ").Append(MaxSubstitutes).Append("\n");
            sb.Append("  NameLocKey: ").Append(NameLocKey).Append("\n");
            sb.Append("  Phases: ").Append(Phases).Append("\n");
            sb.Append("  RewardConfig: ").Append(RewardConfig).Append("\n");
            sb.Append("  RosterSize: ").Append(RosterSize).Append("\n");
            sb.Append("  ScoutingDurationMs: ").Append(ScoutingDurationMs).Append("\n");
            sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
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
            return this.Equals(obj as LolClashTournament);
        }

        /// <summary>
        /// Returns true if LolClashTournament instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashTournament to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashTournament other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowRosterCreation == other.AllowRosterCreation ||
                    this.AllowRosterCreation != null &&
                    this.AllowRosterCreation.Equals(other.AllowRosterCreation)
                ) && 
                (
                    this.AllowRosterDisband == other.AllowRosterDisband ||
                    this.AllowRosterDisband != null &&
                    this.AllowRosterDisband.Equals(other.AllowRosterDisband)
                ) && 
                (
                    this.BuyInOptions == other.BuyInOptions ||
                    this.BuyInOptions != null &&
                    this.BuyInOptions.SequenceEqual(other.BuyInOptions)
                ) && 
                (
                    this.EndTimeMs == other.EndTimeMs ||
                    this.EndTimeMs != null &&
                    this.EndTimeMs.Equals(other.EndTimeMs)
                ) && 
                (
                    this.EntryFee == other.EntryFee ||
                    this.EntryFee != null &&
                    this.EntryFee.Equals(other.EntryFee)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.MaxSubstitutes == other.MaxSubstitutes ||
                    this.MaxSubstitutes != null &&
                    this.MaxSubstitutes.Equals(other.MaxSubstitutes)
                ) && 
                (
                    this.NameLocKey == other.NameLocKey ||
                    this.NameLocKey != null &&
                    this.NameLocKey.Equals(other.NameLocKey)
                ) && 
                (
                    this.Phases == other.Phases ||
                    this.Phases != null &&
                    this.Phases.SequenceEqual(other.Phases)
                ) && 
                (
                    this.RewardConfig == other.RewardConfig ||
                    this.RewardConfig != null &&
                    this.RewardConfig.SequenceEqual(other.RewardConfig)
                ) && 
                (
                    this.RosterSize == other.RosterSize ||
                    this.RosterSize != null &&
                    this.RosterSize.Equals(other.RosterSize)
                ) && 
                (
                    this.ScoutingDurationMs == other.ScoutingDurationMs ||
                    this.ScoutingDurationMs != null &&
                    this.ScoutingDurationMs.Equals(other.ScoutingDurationMs)
                ) && 
                (
                    this.StartTimeMs == other.StartTimeMs ||
                    this.StartTimeMs != null &&
                    this.StartTimeMs.Equals(other.StartTimeMs)
                ) && 
                (
                    this.ThemeId == other.ThemeId ||
                    this.ThemeId != null &&
                    this.ThemeId.Equals(other.ThemeId)
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
                if (this.AllowRosterCreation != null)
                    hash = hash * 59 + this.AllowRosterCreation.GetHashCode();
                if (this.AllowRosterDisband != null)
                    hash = hash * 59 + this.AllowRosterDisband.GetHashCode();
                if (this.BuyInOptions != null)
                    hash = hash * 59 + this.BuyInOptions.GetHashCode();
                if (this.EndTimeMs != null)
                    hash = hash * 59 + this.EndTimeMs.GetHashCode();
                if (this.EntryFee != null)
                    hash = hash * 59 + this.EntryFee.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.MaxSubstitutes != null)
                    hash = hash * 59 + this.MaxSubstitutes.GetHashCode();
                if (this.NameLocKey != null)
                    hash = hash * 59 + this.NameLocKey.GetHashCode();
                if (this.Phases != null)
                    hash = hash * 59 + this.Phases.GetHashCode();
                if (this.RewardConfig != null)
                    hash = hash * 59 + this.RewardConfig.GetHashCode();
                if (this.RosterSize != null)
                    hash = hash * 59 + this.RosterSize.GetHashCode();
                if (this.ScoutingDurationMs != null)
                    hash = hash * 59 + this.ScoutingDurationMs.GetHashCode();
                if (this.StartTimeMs != null)
                    hash = hash * 59 + this.StartTimeMs.GetHashCode();
                if (this.ThemeId != null)
                    hash = hash * 59 + this.ThemeId.GetHashCode();
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
