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
    /// LolChampionsCollectionsChampionSkinEmblemPath
    /// </summary>
    [DataContract]
    public partial class LolChampionsCollectionsChampionSkinEmblemPath :  IEquatable<LolChampionsCollectionsChampionSkinEmblemPath>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampionsCollectionsChampionSkinEmblemPath" /> class.
        /// </summary>
        /// <param name="Large">Large.</param>
        /// <param name="Small">Small.</param>
        public LolChampionsCollectionsChampionSkinEmblemPath(string Large = default(string), string Small = default(string))
        {
            this.Large = Large;
            this.Small = Small;
        }
        
        /// <summary>
        /// Gets or Sets Large
        /// </summary>
        [DataMember(Name="large", EmitDefaultValue=false)]
        public string Large { get; set; }

        /// <summary>
        /// Gets or Sets Small
        /// </summary>
        [DataMember(Name="small", EmitDefaultValue=false)]
        public string Small { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampionsCollectionsChampionSkinEmblemPath {\n");
            sb.Append("  Large: ").Append(Large).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
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
            return this.Equals(obj as LolChampionsCollectionsChampionSkinEmblemPath);
        }

        /// <summary>
        /// Returns true if LolChampionsCollectionsChampionSkinEmblemPath instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampionsCollectionsChampionSkinEmblemPath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampionsCollectionsChampionSkinEmblemPath other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Large == other.Large ||
                    this.Large != null &&
                    this.Large.Equals(other.Large)
                ) && 
                (
                    this.Small == other.Small ||
                    this.Small != null &&
                    this.Small.Equals(other.Small)
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
                if (this.Large != null)
                    hash = hash * 59 + this.Large.GetHashCode();
                if (this.Small != null)
                    hash = hash * 59 + this.Small.GetHashCode();
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
