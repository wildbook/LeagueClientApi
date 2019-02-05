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
    /// LolHonorV2VendedHonorState
    /// </summary>
    [DataContract]
    public partial class LolHonorV2VendedHonorState :  IEquatable<LolHonorV2VendedHonorState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolHonorV2VendedHonorState" /> class.
        /// </summary>
        /// <param name="Checkpoint">Checkpoint.</param>
        /// <param name="Level">Level.</param>
        /// <param name="RewardsLocked">RewardsLocked.</param>
        public LolHonorV2VendedHonorState(int? Checkpoint = default(int?), int? Level = default(int?), bool? RewardsLocked = default(bool?))
        {
            this.Checkpoint = Checkpoint;
            this.Level = Level;
            this.RewardsLocked = RewardsLocked;
        }
        
        /// <summary>
        /// Gets or Sets Checkpoint
        /// </summary>
        [DataMember(Name="checkpoint", EmitDefaultValue=false)]
        public int? Checkpoint { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public int? Level { get; set; }

        /// <summary>
        /// Gets or Sets RewardsLocked
        /// </summary>
        [DataMember(Name="rewardsLocked", EmitDefaultValue=false)]
        public bool? RewardsLocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolHonorV2VendedHonorState {\n");
            sb.Append("  Checkpoint: ").Append(Checkpoint).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  RewardsLocked: ").Append(RewardsLocked).Append("\n");
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
            return this.Equals(obj as LolHonorV2VendedHonorState);
        }

        /// <summary>
        /// Returns true if LolHonorV2VendedHonorState instances are equal
        /// </summary>
        /// <param name="other">Instance of LolHonorV2VendedHonorState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolHonorV2VendedHonorState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Checkpoint == other.Checkpoint ||
                    this.Checkpoint != null &&
                    this.Checkpoint.Equals(other.Checkpoint)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.RewardsLocked == other.RewardsLocked ||
                    this.RewardsLocked != null &&
                    this.RewardsLocked.Equals(other.RewardsLocked)
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
                if (this.Checkpoint != null)
                    hash = hash * 59 + this.Checkpoint.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.RewardsLocked != null)
                    hash = hash * 59 + this.RewardsLocked.GetHashCode();
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
