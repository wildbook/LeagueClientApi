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
    /// MissionProgressDTO
    /// </summary>
    [DataContract]
    public partial class MissionProgressDTO :  IEquatable<MissionProgressDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissionProgressDTO" /> class.
        /// </summary>
        /// <param name="CurrentProgress">CurrentProgress.</param>
        /// <param name="LastViewedProgress">LastViewedProgress.</param>
        /// <param name="TotalCount">TotalCount.</param>
        public MissionProgressDTO(int? CurrentProgress = default(int?), int? LastViewedProgress = default(int?), int? TotalCount = default(int?))
        {
            this.CurrentProgress = CurrentProgress;
            this.LastViewedProgress = LastViewedProgress;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// Gets or Sets CurrentProgress
        /// </summary>
        [DataMember(Name="currentProgress", EmitDefaultValue=false)]
        public int? CurrentProgress { get; set; }

        /// <summary>
        /// Gets or Sets LastViewedProgress
        /// </summary>
        [DataMember(Name="lastViewedProgress", EmitDefaultValue=false)]
        public int? LastViewedProgress { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MissionProgressDTO {\n");
            sb.Append("  CurrentProgress: ").Append(CurrentProgress).Append("\n");
            sb.Append("  LastViewedProgress: ").Append(LastViewedProgress).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(obj as MissionProgressDTO);
        }

        /// <summary>
        /// Returns true if MissionProgressDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of MissionProgressDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissionProgressDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrentProgress == other.CurrentProgress ||
                    this.CurrentProgress != null &&
                    this.CurrentProgress.Equals(other.CurrentProgress)
                ) && 
                (
                    this.LastViewedProgress == other.LastViewedProgress ||
                    this.LastViewedProgress != null &&
                    this.LastViewedProgress.Equals(other.LastViewedProgress)
                ) && 
                (
                    this.TotalCount == other.TotalCount ||
                    this.TotalCount != null &&
                    this.TotalCount.Equals(other.TotalCount)
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
                if (this.CurrentProgress != null)
                    hash = hash * 59 + this.CurrentProgress.GetHashCode();
                if (this.LastViewedProgress != null)
                    hash = hash * 59 + this.LastViewedProgress.GetHashCode();
                if (this.TotalCount != null)
                    hash = hash * 59 + this.TotalCount.GetHashCode();
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