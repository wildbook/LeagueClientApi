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
    /// LolSuggestedPlayersSuggestedPlayersSummoner
    /// </summary>
    [DataContract]
    public partial class LolSuggestedPlayersSuggestedPlayersSummoner :  IEquatable<LolSuggestedPlayersSuggestedPlayersSummoner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolSuggestedPlayersSuggestedPlayersSummoner" /> class.
        /// </summary>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerLevel">SummonerLevel.</param>
        public LolSuggestedPlayersSuggestedPlayersSummoner(string DisplayName = default(string), long? SummonerId = default(long?), int? SummonerLevel = default(int?))
        {
            this.DisplayName = DisplayName;
            this.SummonerId = SummonerId;
            this.SummonerLevel = SummonerLevel;
        }
        
        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets SummonerLevel
        /// </summary>
        [DataMember(Name="summonerLevel", EmitDefaultValue=false)]
        public int? SummonerLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolSuggestedPlayersSuggestedPlayersSummoner {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerLevel: ").Append(SummonerLevel).Append("\n");
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
            return this.Equals(obj as LolSuggestedPlayersSuggestedPlayersSummoner);
        }

        /// <summary>
        /// Returns true if LolSuggestedPlayersSuggestedPlayersSummoner instances are equal
        /// </summary>
        /// <param name="other">Instance of LolSuggestedPlayersSuggestedPlayersSummoner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolSuggestedPlayersSuggestedPlayersSummoner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.SummonerLevel == other.SummonerLevel ||
                    this.SummonerLevel != null &&
                    this.SummonerLevel.Equals(other.SummonerLevel)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerLevel != null)
                    hash = hash * 59 + this.SummonerLevel.GetHashCode();
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
