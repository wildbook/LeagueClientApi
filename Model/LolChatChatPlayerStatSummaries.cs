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
    /// LolChatChatPlayerStatSummaries
    /// </summary>
    [DataContract]
    public partial class LolChatChatPlayerStatSummaries :  IEquatable<LolChatChatPlayerStatSummaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChatChatPlayerStatSummaries" /> class.
        /// </summary>
        /// <param name="PlayerStatSummarySet">PlayerStatSummarySet.</param>
        public LolChatChatPlayerStatSummaries(List<LolChatChatPlayerStatSummary> PlayerStatSummarySet = default(List<LolChatChatPlayerStatSummary>))
        {
            this.PlayerStatSummarySet = PlayerStatSummarySet;
        }
        
        /// <summary>
        /// Gets or Sets PlayerStatSummarySet
        /// </summary>
        [DataMember(Name="playerStatSummarySet", EmitDefaultValue=false)]
        public List<LolChatChatPlayerStatSummary> PlayerStatSummarySet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChatChatPlayerStatSummaries {\n");
            sb.Append("  PlayerStatSummarySet: ").Append(PlayerStatSummarySet).Append("\n");
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
            return this.Equals(obj as LolChatChatPlayerStatSummaries);
        }

        /// <summary>
        /// Returns true if LolChatChatPlayerStatSummaries instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChatChatPlayerStatSummaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChatChatPlayerStatSummaries other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlayerStatSummarySet == other.PlayerStatSummarySet ||
                    this.PlayerStatSummarySet != null &&
                    this.PlayerStatSummarySet.SequenceEqual(other.PlayerStatSummarySet)
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
                if (this.PlayerStatSummarySet != null)
                    hash = hash * 59 + this.PlayerStatSummarySet.GetHashCode();
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