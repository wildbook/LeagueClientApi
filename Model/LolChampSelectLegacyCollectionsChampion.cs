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
    /// LolChampSelectLegacyCollectionsChampion
    /// </summary>
    [DataContract]
    public partial class LolChampSelectLegacyCollectionsChampion :  IEquatable<LolChampSelectLegacyCollectionsChampion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampSelectLegacyCollectionsChampion" /> class.
        /// </summary>
        /// <param name="FreeToPlay">FreeToPlay.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Ownership">Ownership.</param>
        public LolChampSelectLegacyCollectionsChampion(bool? FreeToPlay = default(bool?), int? Id = default(int?), LolChampSelectLegacyCollectionsOwnership Ownership = default(LolChampSelectLegacyCollectionsOwnership))
        {
            this.FreeToPlay = FreeToPlay;
            this.Id = Id;
            this.Ownership = Ownership;
        }
        
        /// <summary>
        /// Gets or Sets FreeToPlay
        /// </summary>
        [DataMember(Name="freeToPlay", EmitDefaultValue=false)]
        public bool? FreeToPlay { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Ownership
        /// </summary>
        [DataMember(Name="ownership", EmitDefaultValue=false)]
        public LolChampSelectLegacyCollectionsOwnership Ownership { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampSelectLegacyCollectionsChampion {\n");
            sb.Append("  FreeToPlay: ").Append(FreeToPlay).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Ownership: ").Append(Ownership).Append("\n");
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
            return this.Equals(obj as LolChampSelectLegacyCollectionsChampion);
        }

        /// <summary>
        /// Returns true if LolChampSelectLegacyCollectionsChampion instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampSelectLegacyCollectionsChampion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampSelectLegacyCollectionsChampion other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FreeToPlay == other.FreeToPlay ||
                    this.FreeToPlay != null &&
                    this.FreeToPlay.Equals(other.FreeToPlay)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Ownership == other.Ownership ||
                    this.Ownership != null &&
                    this.Ownership.Equals(other.Ownership)
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
                if (this.FreeToPlay != null)
                    hash = hash * 59 + this.FreeToPlay.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Ownership != null)
                    hash = hash * 59 + this.Ownership.GetHashCode();
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