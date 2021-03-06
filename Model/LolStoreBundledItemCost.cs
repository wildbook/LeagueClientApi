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
    /// LolStoreBundledItemCost
    /// </summary>
    [DataContract]
    public partial class LolStoreBundledItemCost :  IEquatable<LolStoreBundledItemCost>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolStoreBundledItemCost" /> class.
        /// </summary>
        /// <param name="Cost">Cost.</param>
        /// <param name="CostType">CostType.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Discount">Discount.</param>
        public LolStoreBundledItemCost(long? Cost = default(long?), string CostType = default(string), string Currency = default(string), float? Discount = default(float?))
        {
            this.Cost = Cost;
            this.CostType = CostType;
            this.Currency = Currency;
            this.Discount = Discount;
        }
        
        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name="cost", EmitDefaultValue=false)]
        public long? Cost { get; set; }

        /// <summary>
        /// Gets or Sets CostType
        /// </summary>
        [DataMember(Name="costType", EmitDefaultValue=false)]
        public string CostType { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public float? Discount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolStoreBundledItemCost {\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CostType: ").Append(CostType).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
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
            return this.Equals(obj as LolStoreBundledItemCost);
        }

        /// <summary>
        /// Returns true if LolStoreBundledItemCost instances are equal
        /// </summary>
        /// <param name="other">Instance of LolStoreBundledItemCost to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolStoreBundledItemCost other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cost == other.Cost ||
                    this.Cost != null &&
                    this.Cost.Equals(other.Cost)
                ) && 
                (
                    this.CostType == other.CostType ||
                    this.CostType != null &&
                    this.CostType.Equals(other.CostType)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
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
                if (this.Cost != null)
                    hash = hash * 59 + this.Cost.GetHashCode();
                if (this.CostType != null)
                    hash = hash * 59 + this.CostType.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
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
