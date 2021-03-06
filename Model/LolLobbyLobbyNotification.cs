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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace LeagueClientApi.Model
{
    /// <summary>
    /// LolLobbyLobbyNotification
    /// </summary>
    [DataContract]
    public partial class LolLobbyLobbyNotification :  IEquatable<LolLobbyLobbyNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyLobbyNotification" /> class.
        /// </summary>
        /// <param name="NotificationId">NotificationId.</param>
        /// <param name="NotificationReason">NotificationReason.</param>
        /// <param name="SummonerIds">SummonerIds.</param>
        /// <param name="Timestamp">Timestamp.</param>
        public LolLobbyLobbyNotification(string NotificationId = default(string), string NotificationReason = default(string), List<long?> SummonerIds = default(List<long?>), long? Timestamp = default(long?))
        {
            this.NotificationId = NotificationId;
            this.NotificationReason = NotificationReason;
            this.SummonerIds = SummonerIds;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Gets or Sets NotificationId
        /// </summary>
        [DataMember(Name="notificationId", EmitDefaultValue=false)]
        public string NotificationId { get; set; }

        /// <summary>
        /// Gets or Sets NotificationReason
        /// </summary>
        [DataMember(Name="notificationReason", EmitDefaultValue=false)]
        public string NotificationReason { get; set; }

        /// <summary>
        /// Gets or Sets SummonerIds
        /// </summary>
        [DataMember(Name="summonerIds", EmitDefaultValue=false)]
        public List<long?> SummonerIds { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyLobbyNotification {\n");
            sb.Append("  NotificationId: ").Append(NotificationId).Append("\n");
            sb.Append("  NotificationReason: ").Append(NotificationReason).Append("\n");
            sb.Append("  SummonerIds: ").Append(SummonerIds).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as LolLobbyLobbyNotification);
        }

        /// <summary>
        /// Returns true if LolLobbyLobbyNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyLobbyNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyLobbyNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NotificationId == other.NotificationId ||
                    this.NotificationId != null &&
                    this.NotificationId.Equals(other.NotificationId)
                ) && 
                (
                    this.NotificationReason == other.NotificationReason ||
                    this.NotificationReason != null &&
                    this.NotificationReason.Equals(other.NotificationReason)
                ) && 
                (
                    this.SummonerIds == other.SummonerIds ||
                    this.SummonerIds != null &&
                    this.SummonerIds.SequenceEqual(other.SummonerIds)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.NotificationId != null)
                    hash = hash * 59 + this.NotificationId.GetHashCode();
                if (this.NotificationReason != null)
                    hash = hash * 59 + this.NotificationReason.GetHashCode();
                if (this.SummonerIds != null)
                    hash = hash * 59 + this.SummonerIds.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
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
