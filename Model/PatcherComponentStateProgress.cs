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
    /// PatcherComponentStateProgress
    /// </summary>
    [DataContract]
    public partial class PatcherComponentStateProgress :  IEquatable<PatcherComponentStateProgress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatcherComponentStateProgress" /> class.
        /// </summary>
        /// <param name="BytesComplete">BytesComplete.</param>
        /// <param name="BytesPerSecond">BytesPerSecond.</param>
        /// <param name="BytesRequired">BytesRequired.</param>
        public PatcherComponentStateProgress(long? BytesComplete = default(long?), double? BytesPerSecond = default(double?), long? BytesRequired = default(long?))
        {
            this.BytesComplete = BytesComplete;
            this.BytesPerSecond = BytesPerSecond;
            this.BytesRequired = BytesRequired;
        }
        
        /// <summary>
        /// Gets or Sets BytesComplete
        /// </summary>
        [DataMember(Name="bytesComplete", EmitDefaultValue=false)]
        public long? BytesComplete { get; set; }

        /// <summary>
        /// Gets or Sets BytesPerSecond
        /// </summary>
        [DataMember(Name="bytesPerSecond", EmitDefaultValue=false)]
        public double? BytesPerSecond { get; set; }

        /// <summary>
        /// Gets or Sets BytesRequired
        /// </summary>
        [DataMember(Name="bytesRequired", EmitDefaultValue=false)]
        public long? BytesRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatcherComponentStateProgress {\n");
            sb.Append("  BytesComplete: ").Append(BytesComplete).Append("\n");
            sb.Append("  BytesPerSecond: ").Append(BytesPerSecond).Append("\n");
            sb.Append("  BytesRequired: ").Append(BytesRequired).Append("\n");
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
            return this.Equals(obj as PatcherComponentStateProgress);
        }

        /// <summary>
        /// Returns true if PatcherComponentStateProgress instances are equal
        /// </summary>
        /// <param name="other">Instance of PatcherComponentStateProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatcherComponentStateProgress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BytesComplete == other.BytesComplete ||
                    this.BytesComplete != null &&
                    this.BytesComplete.Equals(other.BytesComplete)
                ) && 
                (
                    this.BytesPerSecond == other.BytesPerSecond ||
                    this.BytesPerSecond != null &&
                    this.BytesPerSecond.Equals(other.BytesPerSecond)
                ) && 
                (
                    this.BytesRequired == other.BytesRequired ||
                    this.BytesRequired != null &&
                    this.BytesRequired.Equals(other.BytesRequired)
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
                if (this.BytesComplete != null)
                    hash = hash * 59 + this.BytesComplete.GetHashCode();
                if (this.BytesPerSecond != null)
                    hash = hash * 59 + this.BytesPerSecond.GetHashCode();
                if (this.BytesRequired != null)
                    hash = hash * 59 + this.BytesRequired.GetHashCode();
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
