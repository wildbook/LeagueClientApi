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
    /// LolLootRecipeSlot
    /// </summary>
    [DataContract]
    public partial class LolLootRecipeSlot :  IEquatable<LolLootRecipeSlot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLootRecipeSlot" /> class.
        /// </summary>
        /// <param name="LootIds">LootIds.</param>
        /// <param name="Quantity">Quantity.</param>
        /// <param name="SlotNumber">SlotNumber.</param>
        /// <param name="Tags">Tags.</param>
        public LolLootRecipeSlot(List<string> LootIds = default(List<string>), int? Quantity = default(int?), int? SlotNumber = default(int?), string Tags = default(string))
        {
            this.LootIds = LootIds;
            this.Quantity = Quantity;
            this.SlotNumber = SlotNumber;
            this.Tags = Tags;
        }
        
        /// <summary>
        /// Gets or Sets LootIds
        /// </summary>
        [DataMember(Name="lootIds", EmitDefaultValue=false)]
        public List<string> LootIds { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets SlotNumber
        /// </summary>
        [DataMember(Name="slotNumber", EmitDefaultValue=false)]
        public int? SlotNumber { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public string Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLootRecipeSlot {\n");
            sb.Append("  LootIds: ").Append(LootIds).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SlotNumber: ").Append(SlotNumber).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(obj as LolLootRecipeSlot);
        }

        /// <summary>
        /// Returns true if LolLootRecipeSlot instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLootRecipeSlot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLootRecipeSlot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LootIds == other.LootIds ||
                    this.LootIds != null &&
                    this.LootIds.SequenceEqual(other.LootIds)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.SlotNumber == other.SlotNumber ||
                    this.SlotNumber != null &&
                    this.SlotNumber.Equals(other.SlotNumber)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
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
                if (this.LootIds != null)
                    hash = hash * 59 + this.LootIds.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.SlotNumber != null)
                    hash = hash * 59 + this.SlotNumber.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
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
