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
    /// LolPerksPerkSettingResource
    /// </summary>
    [DataContract]
    public partial class LolPerksPerkSettingResource :  IEquatable<LolPerksPerkSettingResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksPerkSettingResource" /> class.
        /// </summary>
        /// <param name="PerkIds">PerkIds.</param>
        /// <param name="PerkStyle">PerkStyle.</param>
        /// <param name="PerkSubStyle">PerkSubStyle.</param>
        public LolPerksPerkSettingResource(List<int?> PerkIds = default(List<int?>), int? PerkStyle = default(int?), int? PerkSubStyle = default(int?))
        {
            this.PerkIds = PerkIds;
            this.PerkStyle = PerkStyle;
            this.PerkSubStyle = PerkSubStyle;
        }
        
        /// <summary>
        /// Gets or Sets PerkIds
        /// </summary>
        [DataMember(Name="perkIds", EmitDefaultValue=false)]
        public List<int?> PerkIds { get; set; }

        /// <summary>
        /// Gets or Sets PerkStyle
        /// </summary>
        [DataMember(Name="perkStyle", EmitDefaultValue=false)]
        public int? PerkStyle { get; set; }

        /// <summary>
        /// Gets or Sets PerkSubStyle
        /// </summary>
        [DataMember(Name="perkSubStyle", EmitDefaultValue=false)]
        public int? PerkSubStyle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksPerkSettingResource {\n");
            sb.Append("  PerkIds: ").Append(PerkIds).Append("\n");
            sb.Append("  PerkStyle: ").Append(PerkStyle).Append("\n");
            sb.Append("  PerkSubStyle: ").Append(PerkSubStyle).Append("\n");
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
            return this.Equals(obj as LolPerksPerkSettingResource);
        }

        /// <summary>
        /// Returns true if LolPerksPerkSettingResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksPerkSettingResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksPerkSettingResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PerkIds == other.PerkIds ||
                    this.PerkIds != null &&
                    this.PerkIds.SequenceEqual(other.PerkIds)
                ) && 
                (
                    this.PerkStyle == other.PerkStyle ||
                    this.PerkStyle != null &&
                    this.PerkStyle.Equals(other.PerkStyle)
                ) && 
                (
                    this.PerkSubStyle == other.PerkSubStyle ||
                    this.PerkSubStyle != null &&
                    this.PerkSubStyle.Equals(other.PerkSubStyle)
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
                if (this.PerkIds != null)
                    hash = hash * 59 + this.PerkIds.GetHashCode();
                if (this.PerkStyle != null)
                    hash = hash * 59 + this.PerkStyle.GetHashCode();
                if (this.PerkSubStyle != null)
                    hash = hash * 59 + this.PerkSubStyle.GetHashCode();
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