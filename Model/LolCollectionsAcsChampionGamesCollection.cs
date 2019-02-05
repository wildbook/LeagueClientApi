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
    /// LolCollectionsAcsChampionGamesCollection
    /// </summary>
    [DataContract]
    public partial class LolCollectionsAcsChampionGamesCollection :  IEquatable<LolCollectionsAcsChampionGamesCollection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolCollectionsAcsChampionGamesCollection" /> class.
        /// </summary>
        /// <param name="Champions">Champions.</param>
        /// <param name="GameCount">GameCount.</param>
        public LolCollectionsAcsChampionGamesCollection(List<LolCollectionsAcsChampionGames> Champions = default(List<LolCollectionsAcsChampionGames>), int? GameCount = default(int?))
        {
            this.Champions = Champions;
            this.GameCount = GameCount;
        }
        
        /// <summary>
        /// Gets or Sets Champions
        /// </summary>
        [DataMember(Name="champions", EmitDefaultValue=false)]
        public List<LolCollectionsAcsChampionGames> Champions { get; set; }

        /// <summary>
        /// Gets or Sets GameCount
        /// </summary>
        [DataMember(Name="gameCount", EmitDefaultValue=false)]
        public int? GameCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolCollectionsAcsChampionGamesCollection {\n");
            sb.Append("  Champions: ").Append(Champions).Append("\n");
            sb.Append("  GameCount: ").Append(GameCount).Append("\n");
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
            return this.Equals(obj as LolCollectionsAcsChampionGamesCollection);
        }

        /// <summary>
        /// Returns true if LolCollectionsAcsChampionGamesCollection instances are equal
        /// </summary>
        /// <param name="other">Instance of LolCollectionsAcsChampionGamesCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolCollectionsAcsChampionGamesCollection other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Champions == other.Champions ||
                    this.Champions != null &&
                    this.Champions.SequenceEqual(other.Champions)
                ) && 
                (
                    this.GameCount == other.GameCount ||
                    this.GameCount != null &&
                    this.GameCount.Equals(other.GameCount)
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
                if (this.Champions != null)
                    hash = hash * 59 + this.Champions.GetHashCode();
                if (this.GameCount != null)
                    hash = hash * 59 + this.GameCount.GetHashCode();
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
