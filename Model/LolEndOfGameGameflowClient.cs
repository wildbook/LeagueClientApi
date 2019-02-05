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
    /// LolEndOfGameGameflowClient
    /// </summary>
    [DataContract]
    public partial class LolEndOfGameGameflowClient :  IEquatable<LolEndOfGameGameflowClient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolEndOfGameGameflowClient" /> class.
        /// </summary>
        /// <param name="ObserverServerIp">ObserverServerIp.</param>
        /// <param name="ObserverServerPort">ObserverServerPort.</param>
        /// <param name="Running">Running.</param>
        public LolEndOfGameGameflowClient(string ObserverServerIp = default(string), int? ObserverServerPort = default(int?), bool? Running = default(bool?))
        {
            this.ObserverServerIp = ObserverServerIp;
            this.ObserverServerPort = ObserverServerPort;
            this.Running = Running;
        }
        
        /// <summary>
        /// Gets or Sets ObserverServerIp
        /// </summary>
        [DataMember(Name="observerServerIp", EmitDefaultValue=false)]
        public string ObserverServerIp { get; set; }

        /// <summary>
        /// Gets or Sets ObserverServerPort
        /// </summary>
        [DataMember(Name="observerServerPort", EmitDefaultValue=false)]
        public int? ObserverServerPort { get; set; }

        /// <summary>
        /// Gets or Sets Running
        /// </summary>
        [DataMember(Name="running", EmitDefaultValue=false)]
        public bool? Running { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolEndOfGameGameflowClient {\n");
            sb.Append("  ObserverServerIp: ").Append(ObserverServerIp).Append("\n");
            sb.Append("  ObserverServerPort: ").Append(ObserverServerPort).Append("\n");
            sb.Append("  Running: ").Append(Running).Append("\n");
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
            return this.Equals(obj as LolEndOfGameGameflowClient);
        }

        /// <summary>
        /// Returns true if LolEndOfGameGameflowClient instances are equal
        /// </summary>
        /// <param name="other">Instance of LolEndOfGameGameflowClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolEndOfGameGameflowClient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObserverServerIp == other.ObserverServerIp ||
                    this.ObserverServerIp != null &&
                    this.ObserverServerIp.Equals(other.ObserverServerIp)
                ) && 
                (
                    this.ObserverServerPort == other.ObserverServerPort ||
                    this.ObserverServerPort != null &&
                    this.ObserverServerPort.Equals(other.ObserverServerPort)
                ) && 
                (
                    this.Running == other.Running ||
                    this.Running != null &&
                    this.Running.Equals(other.Running)
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
                if (this.ObserverServerIp != null)
                    hash = hash * 59 + this.ObserverServerIp.GetHashCode();
                if (this.ObserverServerPort != null)
                    hash = hash * 59 + this.ObserverServerPort.GetHashCode();
                if (this.Running != null)
                    hash = hash * 59 + this.Running.GetHashCode();
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
