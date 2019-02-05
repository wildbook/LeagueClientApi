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
    /// LolHonorV2HonorRecipient
    /// </summary>
    [DataContract]
    public partial class LolHonorV2HonorRecipient :  IEquatable<LolHonorV2HonorRecipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolHonorV2HonorRecipient" /> class.
        /// </summary>
        /// <param name="GameId">GameId.</param>
        /// <param name="Honors">Honors.</param>
        /// <param name="SummonerId">SummonerId.</param>
        public LolHonorV2HonorRecipient(long? GameId = default(long?), List<LolHonorV2Honor> Honors = default(List<LolHonorV2Honor>), long? SummonerId = default(long?))
        {
            this.GameId = GameId;
            this.Honors = Honors;
            this.SummonerId = SummonerId;
        }
        
        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets Honors
        /// </summary>
        [DataMember(Name="honors", EmitDefaultValue=false)]
        public List<LolHonorV2Honor> Honors { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolHonorV2HonorRecipient {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Honors: ").Append(Honors).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
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
            return this.Equals(obj as LolHonorV2HonorRecipient);
        }

        /// <summary>
        /// Returns true if LolHonorV2HonorRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of LolHonorV2HonorRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolHonorV2HonorRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.Honors == other.Honors ||
                    this.Honors != null &&
                    this.Honors.SequenceEqual(other.Honors)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
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
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.Honors != null)
                    hash = hash * 59 + this.Honors.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
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
