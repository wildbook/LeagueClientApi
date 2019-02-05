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
    /// LolPersonalizedOffersUIOffer
    /// </summary>
    [DataContract]
    public partial class LolPersonalizedOffersUIOffer :  IEquatable<LolPersonalizedOffersUIOffer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPersonalizedOffersUIOffer" /> class.
        /// </summary>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="DiscountPrice">DiscountPrice.</param>
        /// <param name="ExpirationDate">ExpirationDate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="OriginalPrice">OriginalPrice.</param>
        /// <param name="Owned">Owned.</param>
        /// <param name="Revealed">Revealed.</param>
        /// <param name="SkinId">SkinId.</param>
        /// <param name="SkinName">SkinName.</param>
        /// <param name="Type">Type.</param>
        public LolPersonalizedOffersUIOffer(int? ChampionId = default(int?), long? DiscountPrice = default(long?), string ExpirationDate = default(string), string Id = default(string), long? OriginalPrice = default(long?), bool? Owned = default(bool?), bool? Revealed = default(bool?), int? SkinId = default(int?), string SkinName = default(string), string Type = default(string))
        {
            this.ChampionId = ChampionId;
            this.DiscountPrice = DiscountPrice;
            this.ExpirationDate = ExpirationDate;
            this.Id = Id;
            this.OriginalPrice = OriginalPrice;
            this.Owned = Owned;
            this.Revealed = Revealed;
            this.SkinId = SkinId;
            this.SkinName = SkinName;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets DiscountPrice
        /// </summary>
        [DataMember(Name="discountPrice", EmitDefaultValue=false)]
        public long? DiscountPrice { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPrice
        /// </summary>
        [DataMember(Name="originalPrice", EmitDefaultValue=false)]
        public long? OriginalPrice { get; set; }

        /// <summary>
        /// Gets or Sets Owned
        /// </summary>
        [DataMember(Name="owned", EmitDefaultValue=false)]
        public bool? Owned { get; set; }

        /// <summary>
        /// Gets or Sets Revealed
        /// </summary>
        [DataMember(Name="revealed", EmitDefaultValue=false)]
        public bool? Revealed { get; set; }

        /// <summary>
        /// Gets or Sets SkinId
        /// </summary>
        [DataMember(Name="skinId", EmitDefaultValue=false)]
        public int? SkinId { get; set; }

        /// <summary>
        /// Gets or Sets SkinName
        /// </summary>
        [DataMember(Name="skinName", EmitDefaultValue=false)]
        public string SkinName { get; set; }

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
            sb.Append("class LolPersonalizedOffersUIOffer {\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  DiscountPrice: ").Append(DiscountPrice).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  Owned: ").Append(Owned).Append("\n");
            sb.Append("  Revealed: ").Append(Revealed).Append("\n");
            sb.Append("  SkinId: ").Append(SkinId).Append("\n");
            sb.Append("  SkinName: ").Append(SkinName).Append("\n");
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
            return this.Equals(obj as LolPersonalizedOffersUIOffer);
        }

        /// <summary>
        /// Returns true if LolPersonalizedOffersUIOffer instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPersonalizedOffersUIOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPersonalizedOffersUIOffer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.DiscountPrice == other.DiscountPrice ||
                    this.DiscountPrice != null &&
                    this.DiscountPrice.Equals(other.DiscountPrice)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.OriginalPrice == other.OriginalPrice ||
                    this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(other.OriginalPrice)
                ) && 
                (
                    this.Owned == other.Owned ||
                    this.Owned != null &&
                    this.Owned.Equals(other.Owned)
                ) && 
                (
                    this.Revealed == other.Revealed ||
                    this.Revealed != null &&
                    this.Revealed.Equals(other.Revealed)
                ) && 
                (
                    this.SkinId == other.SkinId ||
                    this.SkinId != null &&
                    this.SkinId.Equals(other.SkinId)
                ) && 
                (
                    this.SkinName == other.SkinName ||
                    this.SkinName != null &&
                    this.SkinName.Equals(other.SkinName)
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
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.DiscountPrice != null)
                    hash = hash * 59 + this.DiscountPrice.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.OriginalPrice != null)
                    hash = hash * 59 + this.OriginalPrice.GetHashCode();
                if (this.Owned != null)
                    hash = hash * 59 + this.Owned.GetHashCode();
                if (this.Revealed != null)
                    hash = hash * 59 + this.Revealed.GetHashCode();
                if (this.SkinId != null)
                    hash = hash * 59 + this.SkinId.GetHashCode();
                if (this.SkinName != null)
                    hash = hash * 59 + this.SkinName.GetHashCode();
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
