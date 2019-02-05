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
    /// LolChampSelectChampSelectDisabledChampions
    /// </summary>
    [DataContract]
    public partial class LolChampSelectChampSelectDisabledChampions :  IEquatable<LolChampSelectChampSelectDisabledChampions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampSelectChampSelectDisabledChampions" /> class.
        /// </summary>
        /// <param name="ChampionIds">ChampionIds.</param>
        public LolChampSelectChampSelectDisabledChampions(List<int?> ChampionIds = default(List<int?>))
        {
            this.ChampionIds = ChampionIds;
        }
        
        /// <summary>
        /// Gets or Sets ChampionIds
        /// </summary>
        [DataMember(Name="championIds", EmitDefaultValue=false)]
        public List<int?> ChampionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampSelectChampSelectDisabledChampions {\n");
            sb.Append("  ChampionIds: ").Append(ChampionIds).Append("\n");
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
            return this.Equals(obj as LolChampSelectChampSelectDisabledChampions);
        }

        /// <summary>
        /// Returns true if LolChampSelectChampSelectDisabledChampions instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampSelectChampSelectDisabledChampions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampSelectChampSelectDisabledChampions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChampionIds == other.ChampionIds ||
                    this.ChampionIds != null &&
                    this.ChampionIds.SequenceEqual(other.ChampionIds)
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
                if (this.ChampionIds != null)
                    hash = hash * 59 + this.ChampionIds.GetHashCode();
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
