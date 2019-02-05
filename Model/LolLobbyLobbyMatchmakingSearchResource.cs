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
    /// LolLobbyLobbyMatchmakingSearchResource
    /// </summary>
    [DataContract]
    public partial class LolLobbyLobbyMatchmakingSearchResource :  IEquatable<LolLobbyLobbyMatchmakingSearchResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyLobbyMatchmakingSearchResource" /> class.
        /// </summary>
        /// <param name="Errors">Errors.</param>
        /// <param name="LowPriorityData">LowPriorityData.</param>
        /// <param name="SearchState">SearchState.</param>
        public LolLobbyLobbyMatchmakingSearchResource(List<LolLobbyLobbyMatchmakingSearchErrorResource> Errors = default(List<LolLobbyLobbyMatchmakingSearchErrorResource>), LolLobbyLobbyMatchmakingLowPriorityDataResource LowPriorityData = default(LolLobbyLobbyMatchmakingLowPriorityDataResource), LolLobbyLobbyMatchmakingSearchState SearchState = default(LolLobbyLobbyMatchmakingSearchState))
        {
            this.Errors = Errors;
            this.LowPriorityData = LowPriorityData;
            this.SearchState = SearchState;
        }
        
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<LolLobbyLobbyMatchmakingSearchErrorResource> Errors { get; set; }

        /// <summary>
        /// Gets or Sets LowPriorityData
        /// </summary>
        [DataMember(Name="lowPriorityData", EmitDefaultValue=false)]
        public LolLobbyLobbyMatchmakingLowPriorityDataResource LowPriorityData { get; set; }

        /// <summary>
        /// Gets or Sets SearchState
        /// </summary>
        [DataMember(Name="searchState", EmitDefaultValue=false)]
        public LolLobbyLobbyMatchmakingSearchState SearchState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyLobbyMatchmakingSearchResource {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  LowPriorityData: ").Append(LowPriorityData).Append("\n");
            sb.Append("  SearchState: ").Append(SearchState).Append("\n");
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
            return this.Equals(obj as LolLobbyLobbyMatchmakingSearchResource);
        }

        /// <summary>
        /// Returns true if LolLobbyLobbyMatchmakingSearchResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyLobbyMatchmakingSearchResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyLobbyMatchmakingSearchResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.LowPriorityData == other.LowPriorityData ||
                    this.LowPriorityData != null &&
                    this.LowPriorityData.Equals(other.LowPriorityData)
                ) && 
                (
                    this.SearchState == other.SearchState ||
                    this.SearchState != null &&
                    this.SearchState.Equals(other.SearchState)
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
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.LowPriorityData != null)
                    hash = hash * 59 + this.LowPriorityData.GetHashCode();
                if (this.SearchState != null)
                    hash = hash * 59 + this.SearchState.GetHashCode();
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