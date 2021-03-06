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
    /// LolPerksPerkUISlot
    /// </summary>
    [DataContract]
    public partial class LolPerksPerkUISlot :  IEquatable<LolPerksPerkUISlot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksPerkUISlot" /> class.
        /// </summary>
        /// <param name="Perks">Perks.</param>
        /// <param name="SlotLabel">SlotLabel.</param>
        /// <param name="Type">Type.</param>
        public LolPerksPerkUISlot(List<int?> Perks = default(List<int?>), string SlotLabel = default(string), string Type = default(string))
        {
            this.Perks = Perks;
            this.SlotLabel = SlotLabel;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Perks
        /// </summary>
        [DataMember(Name="perks", EmitDefaultValue=false)]
        public List<int?> Perks { get; set; }

        /// <summary>
        /// Gets or Sets SlotLabel
        /// </summary>
        [DataMember(Name="slotLabel", EmitDefaultValue=false)]
        public string SlotLabel { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksPerkUISlot {\n");
            sb.Append("  Perks: ").Append(Perks).Append("\n");
            sb.Append("  SlotLabel: ").Append(SlotLabel).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LolPerksPerkUISlot);
        }

        /// <summary>
        /// Returns true if LolPerksPerkUISlot instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksPerkUISlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksPerkUISlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Perks == other.Perks ||
                    this.Perks != null &&
                    this.Perks.SequenceEqual(other.Perks)
                ) && 
                (
                    this.SlotLabel == other.SlotLabel ||
                    this.SlotLabel != null &&
                    this.SlotLabel.Equals(other.SlotLabel)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Perks != null)
                    hash = hash * 59 + this.Perks.GetHashCode();
                if (this.SlotLabel != null)
                    hash = hash * 59 + this.SlotLabel.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
