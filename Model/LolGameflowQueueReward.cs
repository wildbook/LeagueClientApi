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
    /// LolGameflowQueueReward
    /// </summary>
    [DataContract]
    public partial class LolGameflowQueueReward :  IEquatable<LolGameflowQueueReward>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolGameflowQueueReward" /> class.
        /// </summary>
        /// <param name="IsChampionPointsEnabled">IsChampionPointsEnabled.</param>
        /// <param name="IsIpEnabled">IsIpEnabled.</param>
        /// <param name="IsXpEnabled">IsXpEnabled.</param>
        /// <param name="PartySizeIpRewards">PartySizeIpRewards.</param>
        public LolGameflowQueueReward(bool? IsChampionPointsEnabled = default(bool?), bool? IsIpEnabled = default(bool?), bool? IsXpEnabled = default(bool?), List<int?> PartySizeIpRewards = default(List<int?>))
        {
            this.IsChampionPointsEnabled = IsChampionPointsEnabled;
            this.IsIpEnabled = IsIpEnabled;
            this.IsXpEnabled = IsXpEnabled;
            this.PartySizeIpRewards = PartySizeIpRewards;
        }
        
        /// <summary>
        /// Gets or Sets IsChampionPointsEnabled
        /// </summary>
        [DataMember(Name="isChampionPointsEnabled", EmitDefaultValue=false)]
        public bool? IsChampionPointsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsIpEnabled
        /// </summary>
        [DataMember(Name="isIpEnabled", EmitDefaultValue=false)]
        public bool? IsIpEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsXpEnabled
        /// </summary>
        [DataMember(Name="isXpEnabled", EmitDefaultValue=false)]
        public bool? IsXpEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PartySizeIpRewards
        /// </summary>
        [DataMember(Name="partySizeIpRewards", EmitDefaultValue=false)]
        public List<int?> PartySizeIpRewards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolGameflowQueueReward {\n");
            sb.Append("  IsChampionPointsEnabled: ").Append(IsChampionPointsEnabled).Append("\n");
            sb.Append("  IsIpEnabled: ").Append(IsIpEnabled).Append("\n");
            sb.Append("  IsXpEnabled: ").Append(IsXpEnabled).Append("\n");
            sb.Append("  PartySizeIpRewards: ").Append(PartySizeIpRewards).Append("\n");
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
            return this.Equals(obj as LolGameflowQueueReward);
        }

        /// <summary>
        /// Returns true if LolGameflowQueueReward instances are equal
        /// </summary>
        /// <param name="other">Instance of LolGameflowQueueReward to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolGameflowQueueReward other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsChampionPointsEnabled == other.IsChampionPointsEnabled ||
                    this.IsChampionPointsEnabled != null &&
                    this.IsChampionPointsEnabled.Equals(other.IsChampionPointsEnabled)
                ) && 
                (
                    this.IsIpEnabled == other.IsIpEnabled ||
                    this.IsIpEnabled != null &&
                    this.IsIpEnabled.Equals(other.IsIpEnabled)
                ) && 
                (
                    this.IsXpEnabled == other.IsXpEnabled ||
                    this.IsXpEnabled != null &&
                    this.IsXpEnabled.Equals(other.IsXpEnabled)
                ) && 
                (
                    this.PartySizeIpRewards == other.PartySizeIpRewards ||
                    this.PartySizeIpRewards != null &&
                    this.PartySizeIpRewards.SequenceEqual(other.PartySizeIpRewards)
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
                if (this.IsChampionPointsEnabled != null)
                    hash = hash * 59 + this.IsChampionPointsEnabled.GetHashCode();
                if (this.IsIpEnabled != null)
                    hash = hash * 59 + this.IsIpEnabled.GetHashCode();
                if (this.IsXpEnabled != null)
                    hash = hash * 59 + this.IsXpEnabled.GetHashCode();
                if (this.PartySizeIpRewards != null)
                    hash = hash * 59 + this.PartySizeIpRewards.GetHashCode();
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
