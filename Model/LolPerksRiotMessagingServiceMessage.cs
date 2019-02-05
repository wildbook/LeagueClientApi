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
    /// LolPerksRiotMessagingServiceMessage
    /// </summary>
    [DataContract]
    public partial class LolPerksRiotMessagingServiceMessage :  IEquatable<LolPerksRiotMessagingServiceMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksRiotMessagingServiceMessage" /> class.
        /// </summary>
        /// <param name="Payload">Payload.</param>
        /// <param name="Resource">Resource.</param>
        /// <param name="Service">Service.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="Version">Version.</param>
        public LolPerksRiotMessagingServiceMessage(string Payload = default(string), string Resource = default(string), string Service = default(string), long? Timestamp = default(long?), string Version = default(string))
        {
            this.Payload = Payload;
            this.Resource = Resource;
            this.Service = Service;
            this.Timestamp = Timestamp;
            this.Version = Version;
        }
        
        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue=false)]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or Sets Service
        /// </summary>
        [DataMember(Name="service", EmitDefaultValue=false)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksRiotMessagingServiceMessage {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as LolPerksRiotMessagingServiceMessage);
        }

        /// <summary>
        /// Returns true if LolPerksRiotMessagingServiceMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksRiotMessagingServiceMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksRiotMessagingServiceMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Payload == other.Payload ||
                    this.Payload != null &&
                    this.Payload.Equals(other.Payload)
                ) && 
                (
                    this.Resource == other.Resource ||
                    this.Resource != null &&
                    this.Resource.Equals(other.Resource)
                ) && 
                (
                    this.Service == other.Service ||
                    this.Service != null &&
                    this.Service.Equals(other.Service)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.Payload != null)
                    hash = hash * 59 + this.Payload.GetHashCode();
                if (this.Resource != null)
                    hash = hash * 59 + this.Resource.GetHashCode();
                if (this.Service != null)
                    hash = hash * 59 + this.Service.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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
