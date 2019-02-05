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
    /// LolLoadoutsGetItemsRequest
    /// </summary>
    [DataContract]
    public partial class LolLoadoutsGetItemsRequest :  IEquatable<LolLoadoutsGetItemsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLoadoutsGetItemsRequest" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="InventoryJWTs">InventoryJWTs.</param>
        /// <param name="InventoryTypes">InventoryTypes.</param>
        public LolLoadoutsGetItemsRequest(int? Id = default(int?), List<string> InventoryJWTs = default(List<string>), List<string> InventoryTypes = default(List<string>))
        {
            this.Id = Id;
            this.InventoryJWTs = InventoryJWTs;
            this.InventoryTypes = InventoryTypes;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets InventoryJWTs
        /// </summary>
        [DataMember(Name="inventoryJWTs", EmitDefaultValue=false)]
        public List<string> InventoryJWTs { get; set; }

        /// <summary>
        /// Gets or Sets InventoryTypes
        /// </summary>
        [DataMember(Name="inventoryTypes", EmitDefaultValue=false)]
        public List<string> InventoryTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLoadoutsGetItemsRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InventoryJWTs: ").Append(InventoryJWTs).Append("\n");
            sb.Append("  InventoryTypes: ").Append(InventoryTypes).Append("\n");
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
            return this.Equals(obj as LolLoadoutsGetItemsRequest);
        }

        /// <summary>
        /// Returns true if LolLoadoutsGetItemsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLoadoutsGetItemsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLoadoutsGetItemsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InventoryJWTs == other.InventoryJWTs ||
                    this.InventoryJWTs != null &&
                    this.InventoryJWTs.SequenceEqual(other.InventoryJWTs)
                ) && 
                (
                    this.InventoryTypes == other.InventoryTypes ||
                    this.InventoryTypes != null &&
                    this.InventoryTypes.SequenceEqual(other.InventoryTypes)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InventoryJWTs != null)
                    hash = hash * 59 + this.InventoryJWTs.GetHashCode();
                if (this.InventoryTypes != null)
                    hash = hash * 59 + this.InventoryTypes.GetHashCode();
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
