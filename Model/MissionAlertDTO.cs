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
    /// MissionAlertDTO
    /// </summary>
    [DataContract]
    public partial class MissionAlertDTO :  IEquatable<MissionAlertDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissionAlertDTO" /> class.
        /// </summary>
        /// <param name="AlertTime">AlertTime.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Type">Type.</param>
        public MissionAlertDTO(long? AlertTime = default(long?), string Message = default(string), string Type = default(string))
        {
            this.AlertTime = AlertTime;
            this.Message = Message;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets AlertTime
        /// </summary>
        [DataMember(Name="alertTime", EmitDefaultValue=false)]
        public long? AlertTime { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MissionAlertDTO {\n");
            sb.Append("  AlertTime: ").Append(AlertTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as MissionAlertDTO);
        }

        /// <summary>
        /// Returns true if MissionAlertDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of MissionAlertDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissionAlertDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AlertTime == other.AlertTime ||
                    this.AlertTime != null &&
                    this.AlertTime.Equals(other.AlertTime)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AlertTime != null)
                    hash = hash * 59 + this.AlertTime.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
