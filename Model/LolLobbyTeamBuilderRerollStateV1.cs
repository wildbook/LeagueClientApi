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
    /// LolLobbyTeamBuilderRerollStateV1
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderRerollStateV1 :  IEquatable<LolLobbyTeamBuilderRerollStateV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderRerollStateV1" /> class.
        /// </summary>
        /// <param name="AllowRerolling">AllowRerolling.</param>
        /// <param name="RerollsRemaining">RerollsRemaining.</param>
        public LolLobbyTeamBuilderRerollStateV1(bool? AllowRerolling = default(bool?), int? RerollsRemaining = default(int?))
        {
            this.AllowRerolling = AllowRerolling;
            this.RerollsRemaining = RerollsRemaining;
        }
        
        /// <summary>
        /// Gets or Sets AllowRerolling
        /// </summary>
        [DataMember(Name="allowRerolling", EmitDefaultValue=false)]
        public bool? AllowRerolling { get; set; }

        /// <summary>
        /// Gets or Sets RerollsRemaining
        /// </summary>
        [DataMember(Name="rerollsRemaining", EmitDefaultValue=false)]
        public int? RerollsRemaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderRerollStateV1 {\n");
            sb.Append("  AllowRerolling: ").Append(AllowRerolling).Append("\n");
            sb.Append("  RerollsRemaining: ").Append(RerollsRemaining).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderRerollStateV1);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderRerollStateV1 instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderRerollStateV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderRerollStateV1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowRerolling == other.AllowRerolling ||
                    this.AllowRerolling != null &&
                    this.AllowRerolling.Equals(other.AllowRerolling)
                ) && 
                (
                    this.RerollsRemaining == other.RerollsRemaining ||
                    this.RerollsRemaining != null &&
                    this.RerollsRemaining.Equals(other.RerollsRemaining)
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
                if (this.AllowRerolling != null)
                    hash = hash * 59 + this.AllowRerolling.GetHashCode();
                if (this.RerollsRemaining != null)
                    hash = hash * 59 + this.RerollsRemaining.GetHashCode();
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
