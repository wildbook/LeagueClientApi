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
    /// LolChampSelectChampSelectMySelection
    /// </summary>
    [DataContract]
    public partial class LolChampSelectChampSelectMySelection :  IEquatable<LolChampSelectChampSelectMySelection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampSelectChampSelectMySelection" /> class.
        /// </summary>
        /// <param name="SelectedSkinId">SelectedSkinId.</param>
        /// <param name="Spell1Id">Spell1Id.</param>
        /// <param name="Spell2Id">Spell2Id.</param>
        /// <param name="WardSkinId">WardSkinId.</param>
        public LolChampSelectChampSelectMySelection(int? SelectedSkinId = default(int?), long? Spell1Id = default(long?), long? Spell2Id = default(long?), long? WardSkinId = default(long?))
        {
            this.SelectedSkinId = SelectedSkinId;
            this.Spell1Id = Spell1Id;
            this.Spell2Id = Spell2Id;
            this.WardSkinId = WardSkinId;
        }
        
        /// <summary>
        /// Gets or Sets SelectedSkinId
        /// </summary>
        [DataMember(Name="selectedSkinId", EmitDefaultValue=false)]
        public int? SelectedSkinId { get; set; }

        /// <summary>
        /// Gets or Sets Spell1Id
        /// </summary>
        [DataMember(Name="spell1Id", EmitDefaultValue=false)]
        public long? Spell1Id { get; set; }

        /// <summary>
        /// Gets or Sets Spell2Id
        /// </summary>
        [DataMember(Name="spell2Id", EmitDefaultValue=false)]
        public long? Spell2Id { get; set; }

        /// <summary>
        /// Gets or Sets WardSkinId
        /// </summary>
        [DataMember(Name="wardSkinId", EmitDefaultValue=false)]
        public long? WardSkinId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampSelectChampSelectMySelection {\n");
            sb.Append("  SelectedSkinId: ").Append(SelectedSkinId).Append("\n");
            sb.Append("  Spell1Id: ").Append(Spell1Id).Append("\n");
            sb.Append("  Spell2Id: ").Append(Spell2Id).Append("\n");
            sb.Append("  WardSkinId: ").Append(WardSkinId).Append("\n");
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
            return this.Equals(obj as LolChampSelectChampSelectMySelection);
        }

        /// <summary>
        /// Returns true if LolChampSelectChampSelectMySelection instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampSelectChampSelectMySelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampSelectChampSelectMySelection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SelectedSkinId == other.SelectedSkinId ||
                    this.SelectedSkinId != null &&
                    this.SelectedSkinId.Equals(other.SelectedSkinId)
                ) && 
                (
                    this.Spell1Id == other.Spell1Id ||
                    this.Spell1Id != null &&
                    this.Spell1Id.Equals(other.Spell1Id)
                ) && 
                (
                    this.Spell2Id == other.Spell2Id ||
                    this.Spell2Id != null &&
                    this.Spell2Id.Equals(other.Spell2Id)
                ) && 
                (
                    this.WardSkinId == other.WardSkinId ||
                    this.WardSkinId != null &&
                    this.WardSkinId.Equals(other.WardSkinId)
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
                if (this.SelectedSkinId != null)
                    hash = hash * 59 + this.SelectedSkinId.GetHashCode();
                if (this.Spell1Id != null)
                    hash = hash * 59 + this.Spell1Id.GetHashCode();
                if (this.Spell2Id != null)
                    hash = hash * 59 + this.Spell2Id.GetHashCode();
                if (this.WardSkinId != null)
                    hash = hash * 59 + this.WardSkinId.GetHashCode();
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
