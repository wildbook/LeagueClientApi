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
    /// LolHonorV2Ballot
    /// </summary>
    [DataContract]
    public partial class LolHonorV2Ballot :  IEquatable<LolHonorV2Ballot>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolHonorV2Ballot" /> class.
        /// </summary>
        /// <param name="EligiblePlayers">EligiblePlayers.</param>
        /// <param name="GameId">GameId.</param>
        public LolHonorV2Ballot(List<LolHonorV2EligiblePlayer> EligiblePlayers = default(List<LolHonorV2EligiblePlayer>), long? GameId = default(long?))
        {
            this.EligiblePlayers = EligiblePlayers;
            this.GameId = GameId;
        }
        
        /// <summary>
        /// Gets or Sets EligiblePlayers
        /// </summary>
        [DataMember(Name="eligiblePlayers", EmitDefaultValue=false)]
        public List<LolHonorV2EligiblePlayer> EligiblePlayers { get; set; }

        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolHonorV2Ballot {\n");
            sb.Append("  EligiblePlayers: ").Append(EligiblePlayers).Append("\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
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
            return this.Equals(obj as LolHonorV2Ballot);
        }

        /// <summary>
        /// Returns true if LolHonorV2Ballot instances are equal
        /// </summary>
        /// <param name="other">Instance of LolHonorV2Ballot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolHonorV2Ballot other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EligiblePlayers == other.EligiblePlayers ||
                    this.EligiblePlayers != null &&
                    this.EligiblePlayers.SequenceEqual(other.EligiblePlayers)
                ) && 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
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
                if (this.EligiblePlayers != null)
                    hash = hash * 59 + this.EligiblePlayers.GetHashCode();
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
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
