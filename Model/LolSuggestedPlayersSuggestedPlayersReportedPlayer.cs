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
    /// LolSuggestedPlayersSuggestedPlayersReportedPlayer
    /// </summary>
    [DataContract]
    public partial class LolSuggestedPlayersSuggestedPlayersReportedPlayer :  IEquatable<LolSuggestedPlayersSuggestedPlayersReportedPlayer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolSuggestedPlayersSuggestedPlayersReportedPlayer" /> class.
        /// </summary>
        /// <param name="ReportedSummonerId">ReportedSummonerId.</param>
        public LolSuggestedPlayersSuggestedPlayersReportedPlayer(long? ReportedSummonerId = default(long?))
        {
            this.ReportedSummonerId = ReportedSummonerId;
        }
        
        /// <summary>
        /// Gets or Sets ReportedSummonerId
        /// </summary>
        [DataMember(Name="reportedSummonerId", EmitDefaultValue=false)]
        public long? ReportedSummonerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolSuggestedPlayersSuggestedPlayersReportedPlayer {\n");
            sb.Append("  ReportedSummonerId: ").Append(ReportedSummonerId).Append("\n");
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
            return this.Equals(obj as LolSuggestedPlayersSuggestedPlayersReportedPlayer);
        }

        /// <summary>
        /// Returns true if LolSuggestedPlayersSuggestedPlayersReportedPlayer instances are equal
        /// </summary>
        /// <param name="other">Instance of LolSuggestedPlayersSuggestedPlayersReportedPlayer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolSuggestedPlayersSuggestedPlayersReportedPlayer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportedSummonerId == other.ReportedSummonerId ||
                    this.ReportedSummonerId != null &&
                    this.ReportedSummonerId.Equals(other.ReportedSummonerId)
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
                if (this.ReportedSummonerId != null)
                    hash = hash * 59 + this.ReportedSummonerId.GetHashCode();
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
