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
    /// MatchmakingLcdsQueueRestricted
    /// </summary>
    [DataContract]
    public partial class MatchmakingLcdsQueueRestricted :  IEquatable<MatchmakingLcdsQueueRestricted>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchmakingLcdsQueueRestricted" /> class.
        /// </summary>
        /// <param name="Message">Message.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="ReasonFailed">ReasonFailed.</param>
        /// <param name="Summoner">Summoner.</param>
        public MatchmakingLcdsQueueRestricted(string Message = default(string), int? QueueId = default(int?), string ReasonFailed = default(string), MatchmakingLcdsSummoner Summoner = default(MatchmakingLcdsSummoner))
        {
            this.Message = Message;
            this.QueueId = QueueId;
            this.ReasonFailed = ReasonFailed;
            this.Summoner = Summoner;
        }
        
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public int? QueueId { get; set; }

        /// <summary>
        /// Gets or Sets ReasonFailed
        /// </summary>
        [DataMember(Name="reasonFailed", EmitDefaultValue=false)]
        public string ReasonFailed { get; set; }

        /// <summary>
        /// Gets or Sets Summoner
        /// </summary>
        [DataMember(Name="summoner", EmitDefaultValue=false)]
        public MatchmakingLcdsSummoner Summoner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchmakingLcdsQueueRestricted {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  ReasonFailed: ").Append(ReasonFailed).Append("\n");
            sb.Append("  Summoner: ").Append(Summoner).Append("\n");
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
            return this.Equals(obj as MatchmakingLcdsQueueRestricted);
        }

        /// <summary>
        /// Returns true if MatchmakingLcdsQueueRestricted instances are equal
        /// </summary>
        /// <param name="other">Instance of MatchmakingLcdsQueueRestricted to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchmakingLcdsQueueRestricted other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) && 
                (
                    this.ReasonFailed == other.ReasonFailed ||
                    this.ReasonFailed != null &&
                    this.ReasonFailed.Equals(other.ReasonFailed)
                ) && 
                (
                    this.Summoner == other.Summoner ||
                    this.Summoner != null &&
                    this.Summoner.Equals(other.Summoner)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                if (this.ReasonFailed != null)
                    hash = hash * 59 + this.ReasonFailed.GetHashCode();
                if (this.Summoner != null)
                    hash = hash * 59 + this.Summoner.GetHashCode();
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
