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
    /// LolPurchaseWidgetTransaction
    /// </summary>
    [DataContract]
    public partial class LolPurchaseWidgetTransaction :  IEquatable<LolPurchaseWidgetTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPurchaseWidgetTransaction" /> class.
        /// </summary>
        /// <param name="IconUrl">IconUrl.</param>
        /// <param name="ItemKey">ItemKey.</param>
        /// <param name="ItemName">ItemName.</param>
        /// <param name="TransactionId">TransactionId.</param>
        public LolPurchaseWidgetTransaction(string IconUrl = default(string), LolPurchaseWidgetItemKey ItemKey = default(LolPurchaseWidgetItemKey), string ItemName = default(string), string TransactionId = default(string))
        {
            this.IconUrl = IconUrl;
            this.ItemKey = ItemKey;
            this.ItemName = ItemName;
            this.TransactionId = TransactionId;
        }
        
        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets ItemKey
        /// </summary>
        [DataMember(Name="itemKey", EmitDefaultValue=false)]
        public LolPurchaseWidgetItemKey ItemKey { get; set; }

        /// <summary>
        /// Gets or Sets ItemName
        /// </summary>
        [DataMember(Name="itemName", EmitDefaultValue=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPurchaseWidgetTransaction {\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  ItemKey: ").Append(ItemKey).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(obj as LolPurchaseWidgetTransaction);
        }

        /// <summary>
        /// Returns true if LolPurchaseWidgetTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPurchaseWidgetTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPurchaseWidgetTransaction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IconUrl == other.IconUrl ||
                    this.IconUrl != null &&
                    this.IconUrl.Equals(other.IconUrl)
                ) && 
                (
                    this.ItemKey == other.ItemKey ||
                    this.ItemKey != null &&
                    this.ItemKey.Equals(other.ItemKey)
                ) && 
                (
                    this.ItemName == other.ItemName ||
                    this.ItemName != null &&
                    this.ItemName.Equals(other.ItemName)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
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
                if (this.IconUrl != null)
                    hash = hash * 59 + this.IconUrl.GetHashCode();
                if (this.ItemKey != null)
                    hash = hash * 59 + this.ItemKey.GetHashCode();
                if (this.ItemName != null)
                    hash = hash * 59 + this.ItemName.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
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
