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
    /// MatchmakingLcdsFailedJoinPlayer
    /// </summary>
    [DataContract]
    public partial class MatchmakingLcdsFailedJoinPlayer :  IEquatable<MatchmakingLcdsFailedJoinPlayer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingLcdsFailedJoinPlayer" /> class.
        /// </summary>
        /// <param name="ReasonFailed">ReasonFailed.</param>
        /// <param name="Summoner">Summoner.</param>
        public MatchmakingLcdsFailedJoinPlayer(string ReasonFailed = default(string), MatchmakingLcdsSummoner Summoner = default(MatchmakingLcdsSummoner))
        {
            this.ReasonFailed = ReasonFailed;
            this.Summoner = Summoner;
        }
        
        /// <summary>
        /// Gets or Sets ReasonFailed
        /// </summary>
        [DataMember(Name="reasonFailed", EmitDefaultValue=false)]
        public string ReasonFailed { get; set; }

        /// <summary>
        /// Gets or Sets Summoner
        /// </summary>
        [DataMember(Name="summoner", EmitDefaultValue=false)]
        public MatchmakingLcdsSummoner Summoner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchmakingLcdsFailedJoinPlayer {\n");
            sb.Append("  ReasonFailed: ").Append(ReasonFailed).Append("\n");
            sb.Append("  Summoner: ").Append(Summoner).Append("\n");
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
            return this.Equals(obj as MatchmakingLcdsFailedJoinPlayer);
        }

        /// <summary>
        /// Returns true if MatchmakingLcdsFailedJoinPlayer instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchmakingLcdsFailedJoinPlayer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchmakingLcdsFailedJoinPlayer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReasonFailed == other.ReasonFailed ||
                    this.ReasonFailed != null &&
                    this.ReasonFailed.Equals(other.ReasonFailed)
                ) && 
                (
                    this.Summoner == other.Summoner ||
                    this.Summoner != null &&
                    this.Summoner.Equals(other.Summoner)
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
                if (this.ReasonFailed != null)
                    hash = hash * 59 + this.ReasonFailed.GetHashCode();
                if (this.Summoner != null)
                    hash = hash * 59 + this.Summoner.GetHashCode();
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
