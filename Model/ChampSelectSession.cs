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
    /// ChampSelectSession
    /// </summary>
    [DataContract]
    public partial class ChampSelectSession :  IEquatable<ChampSelectSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChampSelectSession" /> class.
        /// </summary>
        /// <param name="Timer">Timer.</param>
        public ChampSelectSession(ChampSelectTimer Timer = default(ChampSelectTimer))
        {
            this.Timer = Timer;
        }
        
        /// <summary>
        /// Gets or Sets Timer
        /// </summary>
        [DataMember(Name="timer", EmitDefaultValue=false)]
        public ChampSelectTimer Timer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChampSelectSession {\n");
            sb.Append("  Timer: ").Append(Timer).Append("\n");
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
            return this.Equals(obj as ChampSelectSession);
        }

        /// <summary>
        /// Returns true if ChampSelectSession instances are equal
        /// </summary>
        /// <param name="other">Instance of ChampSelectSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChampSelectSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Timer == other.Timer ||
                    this.Timer != null &&
                    this.Timer.Equals(other.Timer)
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
                if (this.Timer != null)
                    hash = hash * 59 + this.Timer.GetHashCode();
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
