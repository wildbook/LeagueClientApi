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
    /// LolEmailVerificationValidationStatus
    /// </summary>
    [DataContract]
    public partial class LolEmailVerificationValidationStatus :  IEquatable<LolEmailVerificationValidationStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolEmailVerificationValidationStatus" /> class.
        /// </summary>
        /// <param name="EmailStatus">EmailStatus.</param>
        public LolEmailVerificationValidationStatus(string EmailStatus = default(string))
        {
            this.EmailStatus = EmailStatus;
        }
        
        /// <summary>
        /// Gets or Sets EmailStatus
        /// </summary>
        [DataMember(Name="emailStatus", EmitDefaultValue=false)]
        public string EmailStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolEmailVerificationValidationStatus {\n");
            sb.Append("  EmailStatus: ").Append(EmailStatus).Append("\n");
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
            return this.Equals(obj as LolEmailVerificationValidationStatus);
        }

        /// <summary>
        /// Returns true if LolEmailVerificationValidationStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of LolEmailVerificationValidationStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolEmailVerificationValidationStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailStatus == other.EmailStatus ||
                    this.EmailStatus != null &&
                    this.EmailStatus.Equals(other.EmailStatus)
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
                if (this.EmailStatus != null)
                    hash = hash * 59 + this.EmailStatus.GetHashCode();
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
