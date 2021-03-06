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
    /// LolCollectionsCollectionsRuneQuantity
    /// </summary>
    [DataContract]
    public partial class LolCollectionsCollectionsRuneQuantity :  IEquatable<LolCollectionsCollectionsRuneQuantity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolCollectionsCollectionsRuneQuantity" /> class.
        /// </summary>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="RuneId">RuneId.</param>
        public LolCollectionsCollectionsRuneQuantity(int? Quantity = default(int?), int? RuneId = default(int?))
        {
            this.Quantity = Quantity;
            this.RuneId = RuneId;
        }
        
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets RuneId
        /// </summary>
        [DataMember(Name="runeId", EmitDefaultValue=false)]
        public int? RuneId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolCollectionsCollectionsRuneQuantity {\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RuneId: ").Append(RuneId).Append("\n");
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
            return this.Equals(obj as LolCollectionsCollectionsRuneQuantity);
        }

        /// <summary>
        /// Returns true if LolCollectionsCollectionsRuneQuantity instances are equal
        /// </summary>
        /// <param name="other">Instance of LolCollectionsCollectionsRuneQuantity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolCollectionsCollectionsRuneQuantity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.RuneId == other.RuneId ||
                    this.RuneId != null &&
                    this.RuneId.Equals(other.RuneId)
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
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.RuneId != null)
                    hash = hash * 59 + this.RuneId.GetHashCode();
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
