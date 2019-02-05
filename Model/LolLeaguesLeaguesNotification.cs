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
    /// LolLeaguesLeaguesNotification
    /// </summary>
    [DataContract]
    public partial class LolLeaguesLeaguesNotification :  IEquatable<LolLeaguesLeaguesNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLeaguesLeaguesNotification" /> class.
        /// </summary>
        /// <param name="AcknowledgedByPlayer">AcknowledgedByPlayer.</param>
        /// <param name="Data">Data.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Priority">Priority.</param>
        /// <param name="Severity">Severity.</param>
        /// <param name="TitleType">TitleType.</param>
        /// <param name="Type">Type.</param>
        public LolLeaguesLeaguesNotification(bool? AcknowledgedByPlayer = default(bool?), LolLeaguesLeagueNotificationItem Data = default(LolLeaguesLeagueNotificationItem), long? Id = default(long?), long? Priority = default(long?), LolLeaguesSeverity Severity = default(LolLeaguesSeverity), string TitleType = default(string), string Type = default(string))
        {
            this.AcknowledgedByPlayer = AcknowledgedByPlayer;
            this.Data = Data;
            this.Id = Id;
            this.Priority = Priority;
            this.Severity = Severity;
            this.TitleType = TitleType;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets AcknowledgedByPlayer
        /// </summary>
        [DataMember(Name="acknowledgedByPlayer", EmitDefaultValue=false)]
        public bool? AcknowledgedByPlayer { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public LolLeaguesLeagueNotificationItem Data { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public LolLeaguesSeverity Severity { get; set; }

        /// <summary>
        /// Gets or Sets TitleType
        /// </summary>
        [DataMember(Name="titleType", EmitDefaultValue=false)]
        public string TitleType { get; set; }

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
            sb.Append("class LolLeaguesLeaguesNotification {\n");
            sb.Append("  AcknowledgedByPlayer: ").Append(AcknowledgedByPlayer).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  TitleType: ").Append(TitleType).Append("\n");
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
            return this.Equals(obj as LolLeaguesLeaguesNotification);
        }

        /// <summary>
        /// Returns true if LolLeaguesLeaguesNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLeaguesLeaguesNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLeaguesLeaguesNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcknowledgedByPlayer == other.AcknowledgedByPlayer ||
                    this.AcknowledgedByPlayer != null &&
                    this.AcknowledgedByPlayer.Equals(other.AcknowledgedByPlayer)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.Severity == other.Severity ||
                    this.Severity != null &&
                    this.Severity.Equals(other.Severity)
                ) && 
                (
                    this.TitleType == other.TitleType ||
                    this.TitleType != null &&
                    this.TitleType.Equals(other.TitleType)
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
                if (this.AcknowledgedByPlayer != null)
                    hash = hash * 59 + this.AcknowledgedByPlayer.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.Severity != null)
                    hash = hash * 59 + this.Severity.GetHashCode();
                if (this.TitleType != null)
                    hash = hash * 59 + this.TitleType.GetHashCode();
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
