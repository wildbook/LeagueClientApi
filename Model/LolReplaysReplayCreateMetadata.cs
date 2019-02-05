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
    /// LolReplaysReplayCreateMetadata
    /// </summary>
    [DataContract]
    public partial class LolReplaysReplayCreateMetadata :  IEquatable<LolReplaysReplayCreateMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolReplaysReplayCreateMetadata" /> class.
        /// </summary>
        /// <param name="GameEnd">GameEnd.</param>
        /// <param name="GameType">GameType.</param>
        /// <param name="GameVersion">GameVersion.</param>
        /// <param name="QueueId">QueueId.</param>
        public LolReplaysReplayCreateMetadata(long? GameEnd = default(long?), string GameType = default(string), string GameVersion = default(string), int? QueueId = default(int?))
        {
            this.GameEnd = GameEnd;
            this.GameType = GameType;
            this.GameVersion = GameVersion;
            this.QueueId = QueueId;
        }
        
        /// <summary>
        /// Gets or Sets GameEnd
        /// </summary>
        [DataMember(Name="gameEnd", EmitDefaultValue=false)]
        public long? GameEnd { get; set; }

        /// <summary>
        /// Gets or Sets GameType
        /// </summary>
        [DataMember(Name="gameType", EmitDefaultValue=false)]
        public string GameType { get; set; }

        /// <summary>
        /// Gets or Sets GameVersion
        /// </summary>
        [DataMember(Name="gameVersion", EmitDefaultValue=false)]
        public string GameVersion { get; set; }

        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public int? QueueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolReplaysReplayCreateMetadata {\n");
            sb.Append("  GameEnd: ").Append(GameEnd).Append("\n");
            sb.Append("  GameType: ").Append(GameType).Append("\n");
            sb.Append("  GameVersion: ").Append(GameVersion).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
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
            return this.Equals(obj as LolReplaysReplayCreateMetadata);
        }

        /// <summary>
        /// Returns true if LolReplaysReplayCreateMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of LolReplaysReplayCreateMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolReplaysReplayCreateMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameEnd == other.GameEnd ||
                    this.GameEnd != null &&
                    this.GameEnd.Equals(other.GameEnd)
                ) && 
                (
                    this.GameType == other.GameType ||
                    this.GameType != null &&
                    this.GameType.Equals(other.GameType)
                ) && 
                (
                    this.GameVersion == other.GameVersion ||
                    this.GameVersion != null &&
                    this.GameVersion.Equals(other.GameVersion)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
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
                if (this.GameEnd != null)
                    hash = hash * 59 + this.GameEnd.GetHashCode();
                if (this.GameType != null)
                    hash = hash * 59 + this.GameType.GetHashCode();
                if (this.GameVersion != null)
                    hash = hash * 59 + this.GameVersion.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
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
