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
    /// LcdsGameNotification
    /// </summary>
    [DataContract]
    public partial class LcdsGameNotification :  IEquatable<LcdsGameNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LcdsGameNotification" /> class.
        /// </summary>
        /// <param name="MessageArgument">MessageArgument.</param>
        /// <param name="MessageCode">MessageCode.</param>
        /// <param name="Type">Type.</param>
        public LcdsGameNotification(string MessageArgument = default(string), string MessageCode = default(string), string Type = default(string))
        {
            this.MessageArgument = MessageArgument;
            this.MessageCode = MessageCode;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets MessageArgument
        /// </summary>
        [DataMember(Name="messageArgument", EmitDefaultValue=false)]
        public string MessageArgument { get; set; }

        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name="messageCode", EmitDefaultValue=false)]
        public string MessageCode { get; set; }

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
            sb.Append("class LcdsGameNotification {\n");
            sb.Append("  MessageArgument: ").Append(MessageArgument).Append("\n");
            sb.Append("  MessageCode: ").Append(MessageCode).Append("\n");
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
            return this.Equals(obj as LcdsGameNotification);
        }

        /// <summary>
        /// Returns true if LcdsGameNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of LcdsGameNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LcdsGameNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MessageArgument == other.MessageArgument ||
                    this.MessageArgument != null &&
                    this.MessageArgument.Equals(other.MessageArgument)
                ) && 
                (
                    this.MessageCode == other.MessageCode ||
                    this.MessageCode != null &&
                    this.MessageCode.Equals(other.MessageCode)
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
                if (this.MessageArgument != null)
                    hash = hash * 59 + this.MessageArgument.GetHashCode();
                if (this.MessageCode != null)
                    hash = hash * 59 + this.MessageCode.GetHashCode();
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
