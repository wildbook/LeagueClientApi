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
    /// PlayerLootResultDTO
    /// </summary>
    [DataContract]
    public partial class PlayerLootResultDTO :  IEquatable<PlayerLootResultDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerLootResultDTO" /> class.
        /// </summary>
        /// <param name="Added">Added.</param>
        /// <param name="Details">Details.</param>
        /// <param name="Redeemed">Redeemed.</param>
        /// <param name="Removed">Removed.</param>
        /// <param name="Status">Status.</param>
        public PlayerLootResultDTO(List<PlayerLootDTO> Added = default(List<PlayerLootDTO>), string Details = default(string), List<string> Redeemed = default(List<string>), List<PlayerLootDTO> Removed = default(List<PlayerLootDTO>), string Status = default(string))
        {
            this.Added = Added;
            this.Details = Details;
            this.Redeemed = Redeemed;
            this.Removed = Removed;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name="added", EmitDefaultValue=false)]
        public List<PlayerLootDTO> Added { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Redeemed
        /// </summary>
        [DataMember(Name="redeemed", EmitDefaultValue=false)]
        public List<string> Redeemed { get; set; }

        /// <summary>
        /// Gets or Sets Removed
        /// </summary>
        [DataMember(Name="removed", EmitDefaultValue=false)]
        public List<PlayerLootDTO> Removed { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerLootResultDTO {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Redeemed: ").Append(Redeemed).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as PlayerLootResultDTO);
        }

        /// <summary>
        /// Returns true if PlayerLootResultDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of PlayerLootResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerLootResultDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Added == other.Added ||
                    this.Added != null &&
                    this.Added.SequenceEqual(other.Added)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.Equals(other.Details)
                ) && 
                (
                    this.Redeemed == other.Redeemed ||
                    this.Redeemed != null &&
                    this.Redeemed.SequenceEqual(other.Redeemed)
                ) && 
                (
                    this.Removed == other.Removed ||
                    this.Removed != null &&
                    this.Removed.SequenceEqual(other.Removed)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.Added != null)
                    hash = hash * 59 + this.Added.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Redeemed != null)
                    hash = hash * 59 + this.Redeemed.GetHashCode();
                if (this.Removed != null)
                    hash = hash * 59 + this.Removed.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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
