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
    /// QueueEligilibilityGatekeeperRestrictionDtoV3
    /// </summary>
    [DataContract]
    public partial class QueueEligilibilityGatekeeperRestrictionDtoV3 :  IEquatable<QueueEligilibilityGatekeeperRestrictionDtoV3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueEligilibilityGatekeeperRestrictionDtoV3" /> class.
        /// </summary>
        /// <param name="Payload">Payload.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="RemainingMillis">RemainingMillis.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerName">SummonerName.</param>
        public QueueEligilibilityGatekeeperRestrictionDtoV3(string Payload = default(string), int? QueueId = default(int?), string Reason = default(string), long? RemainingMillis = default(long?), long? SummonerId = default(long?), string SummonerName = default(string))
        {
            this.Payload = Payload;
            this.QueueId = QueueId;
            this.Reason = Reason;
            this.RemainingMillis = RemainingMillis;
            this.SummonerId = SummonerId;
            this.SummonerName = SummonerName;
        }
        
        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name="payload", EmitDefaultValue=false)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public int? QueueId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets RemainingMillis
        /// </summary>
        [DataMember(Name="remainingMillis", EmitDefaultValue=false)]
        public long? RemainingMillis { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets SummonerName
        /// </summary>
        [DataMember(Name="summonerName", EmitDefaultValue=false)]
        public string SummonerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueEligilibilityGatekeeperRestrictionDtoV3 {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  RemainingMillis: ").Append(RemainingMillis).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerName: ").Append(SummonerName).Append("\n");
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
            return this.Equals(obj as QueueEligilibilityGatekeeperRestrictionDtoV3);
        }

        /// <summary>
        /// Returns true if QueueEligilibilityGatekeeperRestrictionDtoV3 instances are equal
        /// </summary>
        /// <param name="other">Instance of QueueEligilibilityGatekeeperRestrictionDtoV3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueEligilibilityGatekeeperRestrictionDtoV3 other)
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
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.RemainingMillis == other.RemainingMillis ||
                    this.RemainingMillis != null &&
                    this.RemainingMillis.Equals(other.RemainingMillis)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.SummonerName == other.SummonerName ||
                    this.SummonerName != null &&
                    this.SummonerName.Equals(other.SummonerName)
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
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.RemainingMillis != null)
                    hash = hash * 59 + this.RemainingMillis.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerName != null)
                    hash = hash * 59 + this.SummonerName.GetHashCode();
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
