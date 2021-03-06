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
    /// MultipleReplayMetadataResponseItemV2
    /// </summary>
    [DataContract]
    public partial class MultipleReplayMetadataResponseItemV2 :  IEquatable<MultipleReplayMetadataResponseItemV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipleReplayMetadataResponseItemV2" /> class.
        /// </summary>
        /// <param name="GameId">GameId.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Status">Status.</param>
        public MultipleReplayMetadataResponseItemV2(long? GameId = default(long?), ReplayMetadataV2 Metadata = default(ReplayMetadataV2), ReplayResponseStatus Status = default(ReplayResponseStatus))
        {
            this.GameId = GameId;
            this.Metadata = Metadata;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public ReplayMetadataV2 Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ReplayResponseStatus Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipleReplayMetadataResponseItemV2 {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as MultipleReplayMetadataResponseItemV2);
        }

        /// <summary>
        /// Returns true if MultipleReplayMetadataResponseItemV2 instances are equal
        /// </summary>
        /// <param name="other">Instance of MultipleReplayMetadataResponseItemV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipleReplayMetadataResponseItemV2 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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
