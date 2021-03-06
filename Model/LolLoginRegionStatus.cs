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
    /// LolLoginRegionStatus
    /// </summary>
    [DataContract]
    public partial class LolLoginRegionStatus :  IEquatable<LolLoginRegionStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLoginRegionStatus" /> class.
        /// </summary>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="IsLQFallbackAllowed">IsLQFallbackAllowed.</param>
        /// <param name="IsUserInfoEnabled">IsUserInfoEnabled.</param>
        /// <param name="PlatformId">PlatformId.</param>
        public LolLoginRegionStatus(bool? Enabled = default(bool?), bool? IsLQFallbackAllowed = default(bool?), bool? IsUserInfoEnabled = default(bool?), string PlatformId = default(string))
        {
            this.Enabled = Enabled;
            this.IsLQFallbackAllowed = IsLQFallbackAllowed;
            this.IsUserInfoEnabled = IsUserInfoEnabled;
            this.PlatformId = PlatformId;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets IsLQFallbackAllowed
        /// </summary>
        [DataMember(Name="isLQFallbackAllowed", EmitDefaultValue=false)]
        public bool? IsLQFallbackAllowed { get; set; }

        /// <summary>
        /// Gets or Sets IsUserInfoEnabled
        /// </summary>
        [DataMember(Name="isUserInfoEnabled", EmitDefaultValue=false)]
        public bool? IsUserInfoEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PlatformId
        /// </summary>
        [DataMember(Name="platformId", EmitDefaultValue=false)]
        public string PlatformId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLoginRegionStatus {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsLQFallbackAllowed: ").Append(IsLQFallbackAllowed).Append("\n");
            sb.Append("  IsUserInfoEnabled: ").Append(IsUserInfoEnabled).Append("\n");
            sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
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
            return this.Equals(obj as LolLoginRegionStatus);
        }

        /// <summary>
        /// Returns true if LolLoginRegionStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLoginRegionStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLoginRegionStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.IsLQFallbackAllowed == other.IsLQFallbackAllowed ||
                    this.IsLQFallbackAllowed != null &&
                    this.IsLQFallbackAllowed.Equals(other.IsLQFallbackAllowed)
                ) && 
                (
                    this.IsUserInfoEnabled == other.IsUserInfoEnabled ||
                    this.IsUserInfoEnabled != null &&
                    this.IsUserInfoEnabled.Equals(other.IsUserInfoEnabled)
                ) && 
                (
                    this.PlatformId == other.PlatformId ||
                    this.PlatformId != null &&
                    this.PlatformId.Equals(other.PlatformId)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.IsLQFallbackAllowed != null)
                    hash = hash * 59 + this.IsLQFallbackAllowed.GetHashCode();
                if (this.IsUserInfoEnabled != null)
                    hash = hash * 59 + this.IsUserInfoEnabled.GetHashCode();
                if (this.PlatformId != null)
                    hash = hash * 59 + this.PlatformId.GetHashCode();
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
