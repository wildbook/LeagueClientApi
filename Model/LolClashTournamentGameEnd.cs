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
    /// LolClashTournamentGameEnd
    /// </summary>
    [DataContract]
    public partial class LolClashTournamentGameEnd :  IEquatable<LolClashTournamentGameEnd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashTournamentGameEnd" /> class.
        /// </summary>
        /// <param name="BracketId">BracketId.</param>
        /// <param name="TournamentId">TournamentId.</param>
        public LolClashTournamentGameEnd(long? BracketId = default(long?), long? TournamentId = default(long?))
        {
            this.BracketId = BracketId;
            this.TournamentId = TournamentId;
        }
        
        /// <summary>
        /// Gets or Sets BracketId
        /// </summary>
        [DataMember(Name="bracketId", EmitDefaultValue=false)]
        public long? BracketId { get; set; }

        /// <summary>
        /// Gets or Sets TournamentId
        /// </summary>
        [DataMember(Name="tournamentId", EmitDefaultValue=false)]
        public long? TournamentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashTournamentGameEnd {\n");
            sb.Append("  BracketId: ").Append(BracketId).Append("\n");
            sb.Append("  TournamentId: ").Append(TournamentId).Append("\n");
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
            return this.Equals(obj as LolClashTournamentGameEnd);
        }

        /// <summary>
        /// Returns true if LolClashTournamentGameEnd instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashTournamentGameEnd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashTournamentGameEnd other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BracketId == other.BracketId ||
                    this.BracketId != null &&
                    this.BracketId.Equals(other.BracketId)
                ) && 
                (
                    this.TournamentId == other.TournamentId ||
                    this.TournamentId != null &&
                    this.TournamentId.Equals(other.TournamentId)
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
                if (this.BracketId != null)
                    hash = hash * 59 + this.BracketId.GetHashCode();
                if (this.TournamentId != null)
                    hash = hash * 59 + this.TournamentId.GetHashCode();
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
