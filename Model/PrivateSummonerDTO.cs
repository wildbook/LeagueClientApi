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
    /// PrivateSummonerDTO
    /// </summary>
    [DataContract]
    public partial class PrivateSummonerDTO :  IEquatable<PrivateSummonerDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateSummonerDTO" /> class.
        /// </summary>
        /// <param name="AcctId">AcctId.</param>
        /// <param name="AdvancedTutorialFlag">AdvancedTutorialFlag.</param>
        /// <param name="DisplayEloQuestionaire">DisplayEloQuestionaire.</param>
        /// <param name="InternalName">InternalName.</param>
        /// <param name="Name">Name.</param>
        /// <param name="NameChangeFlag">NameChangeFlag.</param>
        /// <param name="PreviousSeasonHighestTier">PreviousSeasonHighestTier.</param>
        /// <param name="ProfileIconId">ProfileIconId.</param>
        /// <param name="SumId">SumId.</param>
        /// <param name="TutorialFlag">TutorialFlag.</param>
        public PrivateSummonerDTO(long? AcctId = default(long?), bool? AdvancedTutorialFlag = default(bool?), bool? DisplayEloQuestionaire = default(bool?), string InternalName = default(string), string Name = default(string), bool? NameChangeFlag = default(bool?), string PreviousSeasonHighestTier = default(string), int? ProfileIconId = default(int?), long? SumId = default(long?), bool? TutorialFlag = default(bool?))
        {
            this.AcctId = AcctId;
            this.AdvancedTutorialFlag = AdvancedTutorialFlag;
            this.DisplayEloQuestionaire = DisplayEloQuestionaire;
            this.InternalName = InternalName;
            this.Name = Name;
            this.NameChangeFlag = NameChangeFlag;
            this.PreviousSeasonHighestTier = PreviousSeasonHighestTier;
            this.ProfileIconId = ProfileIconId;
            this.SumId = SumId;
            this.TutorialFlag = TutorialFlag;
        }
        
        /// <summary>
        /// Gets or Sets AcctId
        /// </summary>
        [DataMember(Name="acctId", EmitDefaultValue=false)]
        public long? AcctId { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedTutorialFlag
        /// </summary>
        [DataMember(Name="advancedTutorialFlag", EmitDefaultValue=false)]
        public bool? AdvancedTutorialFlag { get; set; }

        /// <summary>
        /// Gets or Sets DisplayEloQuestionaire
        /// </summary>
        [DataMember(Name="displayEloQuestionaire", EmitDefaultValue=false)]
        public bool? DisplayEloQuestionaire { get; set; }

        /// <summary>
        /// Gets or Sets InternalName
        /// </summary>
        [DataMember(Name="internalName", EmitDefaultValue=false)]
        public string InternalName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NameChangeFlag
        /// </summary>
        [DataMember(Name="nameChangeFlag", EmitDefaultValue=false)]
        public bool? NameChangeFlag { get; set; }

        /// <summary>
        /// Gets or Sets PreviousSeasonHighestTier
        /// </summary>
        [DataMember(Name="previousSeasonHighestTier", EmitDefaultValue=false)]
        public string PreviousSeasonHighestTier { get; set; }

        /// <summary>
        /// Gets or Sets ProfileIconId
        /// </summary>
        [DataMember(Name="profileIconId", EmitDefaultValue=false)]
        public int? ProfileIconId { get; set; }

        /// <summary>
        /// Gets or Sets SumId
        /// </summary>
        [DataMember(Name="sumId", EmitDefaultValue=false)]
        public long? SumId { get; set; }

        /// <summary>
        /// Gets or Sets TutorialFlag
        /// </summary>
        [DataMember(Name="tutorialFlag", EmitDefaultValue=false)]
        public bool? TutorialFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateSummonerDTO {\n");
            sb.Append("  AcctId: ").Append(AcctId).Append("\n");
            sb.Append("  AdvancedTutorialFlag: ").Append(AdvancedTutorialFlag).Append("\n");
            sb.Append("  DisplayEloQuestionaire: ").Append(DisplayEloQuestionaire).Append("\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameChangeFlag: ").Append(NameChangeFlag).Append("\n");
            sb.Append("  PreviousSeasonHighestTier: ").Append(PreviousSeasonHighestTier).Append("\n");
            sb.Append("  ProfileIconId: ").Append(ProfileIconId).Append("\n");
            sb.Append("  SumId: ").Append(SumId).Append("\n");
            sb.Append("  TutorialFlag: ").Append(TutorialFlag).Append("\n");
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
            return this.Equals(obj as PrivateSummonerDTO);
        }

        /// <summary>
        /// Returns true if PrivateSummonerDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of PrivateSummonerDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrivateSummonerDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcctId == other.AcctId ||
                    this.AcctId != null &&
                    this.AcctId.Equals(other.AcctId)
                ) && 
                (
                    this.AdvancedTutorialFlag == other.AdvancedTutorialFlag ||
                    this.AdvancedTutorialFlag != null &&
                    this.AdvancedTutorialFlag.Equals(other.AdvancedTutorialFlag)
                ) && 
                (
                    this.DisplayEloQuestionaire == other.DisplayEloQuestionaire ||
                    this.DisplayEloQuestionaire != null &&
                    this.DisplayEloQuestionaire.Equals(other.DisplayEloQuestionaire)
                ) && 
                (
                    this.InternalName == other.InternalName ||
                    this.InternalName != null &&
                    this.InternalName.Equals(other.InternalName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NameChangeFlag == other.NameChangeFlag ||
                    this.NameChangeFlag != null &&
                    this.NameChangeFlag.Equals(other.NameChangeFlag)
                ) && 
                (
                    this.PreviousSeasonHighestTier == other.PreviousSeasonHighestTier ||
                    this.PreviousSeasonHighestTier != null &&
                    this.PreviousSeasonHighestTier.Equals(other.PreviousSeasonHighestTier)
                ) && 
                (
                    this.ProfileIconId == other.ProfileIconId ||
                    this.ProfileIconId != null &&
                    this.ProfileIconId.Equals(other.ProfileIconId)
                ) && 
                (
                    this.SumId == other.SumId ||
                    this.SumId != null &&
                    this.SumId.Equals(other.SumId)
                ) && 
                (
                    this.TutorialFlag == other.TutorialFlag ||
                    this.TutorialFlag != null &&
                    this.TutorialFlag.Equals(other.TutorialFlag)
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
                if (this.AcctId != null)
                    hash = hash * 59 + this.AcctId.GetHashCode();
                if (this.AdvancedTutorialFlag != null)
                    hash = hash * 59 + this.AdvancedTutorialFlag.GetHashCode();
                if (this.DisplayEloQuestionaire != null)
                    hash = hash * 59 + this.DisplayEloQuestionaire.GetHashCode();
                if (this.InternalName != null)
                    hash = hash * 59 + this.InternalName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NameChangeFlag != null)
                    hash = hash * 59 + this.NameChangeFlag.GetHashCode();
                if (this.PreviousSeasonHighestTier != null)
                    hash = hash * 59 + this.PreviousSeasonHighestTier.GetHashCode();
                if (this.ProfileIconId != null)
                    hash = hash * 59 + this.ProfileIconId.GetHashCode();
                if (this.SumId != null)
                    hash = hash * 59 + this.SumId.GetHashCode();
                if (this.TutorialFlag != null)
                    hash = hash * 59 + this.TutorialFlag.GetHashCode();
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