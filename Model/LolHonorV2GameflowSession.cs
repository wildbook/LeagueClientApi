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
    /// LolHonorV2GameflowSession
    /// </summary>
    [DataContract]
    public partial class LolHonorV2GameflowSession :  IEquatable<LolHonorV2GameflowSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolHonorV2GameflowSession" /> class.
        /// </summary>
        /// <param name="Phase">Phase.</param>
        public LolHonorV2GameflowSession(LolHonorV2GameflowPhase Phase = default(LolHonorV2GameflowPhase))
        {
            this.Phase = Phase;
        }
        
        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public LolHonorV2GameflowPhase Phase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolHonorV2GameflowSession {\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
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
            return this.Equals(obj as LolHonorV2GameflowSession);
        }

        /// <summary>
        /// Returns true if LolHonorV2GameflowSession instances are equal
        /// </summary>
        /// <param name="other">Instance of LolHonorV2GameflowSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolHonorV2GameflowSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
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
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
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
