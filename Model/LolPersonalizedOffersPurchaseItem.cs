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
    /// LolPersonalizedOffersPurchaseItem
    /// </summary>
    [DataContract]
    public partial class LolPersonalizedOffersPurchaseItem :  IEquatable<LolPersonalizedOffersPurchaseItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPersonalizedOffersPurchaseItem" /> class.
        /// </summary>
        /// <param name="InventoryType">InventoryType.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="PricePaid">PricePaid.</param>
        public LolPersonalizedOffersPurchaseItem(string InventoryType = default(string), int? ItemId = default(int?), long? PricePaid = default(long?))
        {
            this.InventoryType = InventoryType;
            this.ItemId = ItemId;
            this.PricePaid = PricePaid;
        }
        
        /// <summary>
        /// Gets or Sets InventoryType
        /// </summary>
        [DataMember(Name="inventoryType", EmitDefaultValue=false)]
        public string InventoryType { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public int? ItemId { get; set; }

        /// <summary>
        /// Gets or Sets PricePaid
        /// </summary>
        [DataMember(Name="pricePaid", EmitDefaultValue=false)]
        public long? PricePaid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPersonalizedOffersPurchaseItem {\n");
            sb.Append("  InventoryType: ").Append(InventoryType).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PricePaid: ").Append(PricePaid).Append("\n");
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
            return this.Equals(obj as LolPersonalizedOffersPurchaseItem);
        }

        /// <summary>
        /// Returns true if LolPersonalizedOffersPurchaseItem instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPersonalizedOffersPurchaseItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPersonalizedOffersPurchaseItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InventoryType == other.InventoryType ||
                    this.InventoryType != null &&
                    this.InventoryType.Equals(other.InventoryType)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.PricePaid == other.PricePaid ||
                    this.PricePaid != null &&
                    this.PricePaid.Equals(other.PricePaid)
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
                if (this.InventoryType != null)
                    hash = hash * 59 + this.InventoryType.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.PricePaid != null)
                    hash = hash * 59 + this.PricePaid.GetHashCode();
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
