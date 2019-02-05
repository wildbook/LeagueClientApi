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
    /// CollectionsLcdsTalentEntry
    /// </summary>
    [DataContract]
    public partial class CollectionsLcdsTalentEntry :  IEquatable<CollectionsLcdsTalentEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsLcdsTalentEntry" /> class.
        /// </summary>
        /// <param name="Rank">Rank.</param>
        /// <param name="TalentId">TalentId.</param>
        public CollectionsLcdsTalentEntry(int? Rank = default(int?), int? TalentId = default(int?))
        {
            this.Rank = Rank;
            this.TalentId = TalentId;
        }
        
        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Gets or Sets TalentId
        /// </summary>
        [DataMember(Name="talentId", EmitDefaultValue=false)]
        public int? TalentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionsLcdsTalentEntry {\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  TalentId: ").Append(TalentId).Append("\n");
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
            return this.Equals(obj as CollectionsLcdsTalentEntry);
        }

        /// <summary>
        /// Returns true if CollectionsLcdsTalentEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of CollectionsLcdsTalentEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionsLcdsTalentEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
                ) && 
                (
                    this.TalentId == other.TalentId ||
                    this.TalentId != null &&
                    this.TalentId.Equals(other.TalentId)
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
                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();
                if (this.TalentId != null)
                    hash = hash * 59 + this.TalentId.GetHashCode();
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
