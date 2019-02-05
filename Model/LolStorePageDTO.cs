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
    /// LolStorePageDTO
    /// </summary>
    [DataContract]
    public partial class LolStorePageDTO :  IEquatable<LolStorePageDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolStorePageDTO" /> class.
        /// </summary>
        /// <param name="Player">Player.</param>
        /// <param name="Catalog">Catalog.</param>
        /// <param name="GroupOrder">GroupOrder.</param>
        /// <param name="ItemGroups">ItemGroups.</param>
        public LolStorePageDTO(LolStorePlayer Player = default(LolStorePlayer), List<LolStoreCatalogItem> Catalog = default(List<LolStoreCatalogItem>), List<string> GroupOrder = default(List<string>), Dictionary<string, LolStorePageGroupingDTO> ItemGroups = default(Dictionary<string, LolStorePageGroupingDTO>))
        {
            this.Player = Player;
            this.Catalog = Catalog;
            this.GroupOrder = GroupOrder;
            this.ItemGroups = ItemGroups;
        }
        
        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name="Player", EmitDefaultValue=false)]
        public LolStorePlayer Player { get; set; }

        /// <summary>
        /// Gets or Sets Catalog
        /// </summary>
        [DataMember(Name="catalog", EmitDefaultValue=false)]
        public List<LolStoreCatalogItem> Catalog { get; set; }

        /// <summary>
        /// Gets or Sets GroupOrder
        /// </summary>
        [DataMember(Name="groupOrder", EmitDefaultValue=false)]
        public List<string> GroupOrder { get; set; }

        /// <summary>
        /// Gets or Sets ItemGroups
        /// </summary>
        [DataMember(Name="itemGroups", EmitDefaultValue=false)]
        public Dictionary<string, LolStorePageGroupingDTO> ItemGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolStorePageDTO {\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  Catalog: ").Append(Catalog).Append("\n");
            sb.Append("  GroupOrder: ").Append(GroupOrder).Append("\n");
            sb.Append("  ItemGroups: ").Append(ItemGroups).Append("\n");
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
            return this.Equals(obj as LolStorePageDTO);
        }

        /// <summary>
        /// Returns true if LolStorePageDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LolStorePageDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolStorePageDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Player == other.Player ||
                    this.Player != null &&
                    this.Player.Equals(other.Player)
                ) && 
                (
                    this.Catalog == other.Catalog ||
                    this.Catalog != null &&
                    this.Catalog.SequenceEqual(other.Catalog)
                ) && 
                (
                    this.GroupOrder == other.GroupOrder ||
                    this.GroupOrder != null &&
                    this.GroupOrder.SequenceEqual(other.GroupOrder)
                ) && 
                (
                    this.ItemGroups == other.ItemGroups ||
                    this.ItemGroups != null &&
                    this.ItemGroups.SequenceEqual(other.ItemGroups)
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
                if (this.Player != null)
                    hash = hash * 59 + this.Player.GetHashCode();
                if (this.Catalog != null)
                    hash = hash * 59 + this.Catalog.GetHashCode();
                if (this.GroupOrder != null)
                    hash = hash * 59 + this.GroupOrder.GetHashCode();
                if (this.ItemGroups != null)
                    hash = hash * 59 + this.ItemGroups.GetHashCode();
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
