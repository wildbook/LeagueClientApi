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
    /// LolBannersTournamentFlagInventoryItem
    /// </summary>
    [DataContract]
    public partial class LolBannersTournamentFlagInventoryItem :  IEquatable<LolBannersTournamentFlagInventoryItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolBannersTournamentFlagInventoryItem" /> class.
        /// </summary>
        /// <param name="Payload">Payload.</param>
        /// <param name="PurchaseDate">PurchaseDate.</param>
        public LolBannersTournamentFlagInventoryItem(LolBannersCapClashFlagEntitlementPayload Payload = default(LolBannersCapClashFlagEntitlementPayload), string PurchaseDate = default(string))
        {
            this.Payload = Payload;
            this.PurchaseDate = PurchaseDate;
        }
        
        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public LolBannersCapClashFlagEntitlementPayload Payload { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDate
        /// </summary>
        [DataMember(Name="purchaseDate", EmitDefaultValue=false)]
        public string PurchaseDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolBannersTournamentFlagInventoryItem {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
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
            return this.Equals(obj as LolBannersTournamentFlagInventoryItem);
        }

        /// <summary>
        /// Returns true if LolBannersTournamentFlagInventoryItem instances are equal
        /// </summary>
        /// <param name="other">Instance of LolBannersTournamentFlagInventoryItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolBannersTournamentFlagInventoryItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) && 
                (
                    this.PurchaseDate == other.PurchaseDate ||
                    this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(other.PurchaseDate)
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
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                if (this.PurchaseDate != null)
                    hash = hash * 59 + this.PurchaseDate.GetHashCode();
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
