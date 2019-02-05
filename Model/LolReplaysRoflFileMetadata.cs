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
    /// LolReplaysRoflFileMetadata
    /// </summary>
    [DataContract]
    public partial class LolReplaysRoflFileMetadata :  IEquatable<LolReplaysRoflFileMetadata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolReplaysRoflFileMetadata" /> class.
        /// </summary>
        /// <param name="GameLength">GameLength.</param>
        /// <param name="GameVersion">GameVersion.</param>
        /// <param name="LastGameChunkId">LastGameChunkId.</param>
        /// <param name="LastKeyFrameId">LastKeyFrameId.</param>
        public LolReplaysRoflFileMetadata(int? GameLength = default(int?), string GameVersion = default(string), int? LastGameChunkId = default(int?), int? LastKeyFrameId = default(int?))
        {
            this.GameLength = GameLength;
            this.GameVersion = GameVersion;
            this.LastGameChunkId = LastGameChunkId;
            this.LastKeyFrameId = LastKeyFrameId;
        }
        
        /// <summary>
        /// Gets or Sets GameLength
        /// </summary>
        [DataMember(Name="gameLength", EmitDefaultValue=false)]
        public int? GameLength { get; set; }

        /// <summary>
        /// Gets or Sets GameVersion
        /// </summary>
        [DataMember(Name="gameVersion", EmitDefaultValue=false)]
        public string GameVersion { get; set; }

        /// <summary>
        /// Gets or Sets LastGameChunkId
        /// </summary>
        [DataMember(Name="lastGameChunkId", EmitDefaultValue=false)]
        public int? LastGameChunkId { get; set; }

        /// <summary>
        /// Gets or Sets LastKeyFrameId
        /// </summary>
        [DataMember(Name="lastKeyFrameId", EmitDefaultValue=false)]
        public int? LastKeyFrameId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolReplaysRoflFileMetadata {\n");
            sb.Append("  GameLength: ").Append(GameLength).Append("\n");
            sb.Append("  GameVersion: ").Append(GameVersion).Append("\n");
            sb.Append("  LastGameChunkId: ").Append(LastGameChunkId).Append("\n");
            sb.Append("  LastKeyFrameId: ").Append(LastKeyFrameId).Append("\n");
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
            return this.Equals(obj as LolReplaysRoflFileMetadata);
        }

        /// <summary>
        /// Returns true if LolReplaysRoflFileMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of LolReplaysRoflFileMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolReplaysRoflFileMetadata other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameLength == other.GameLength ||
                    this.GameLength != null &&
                    this.GameLength.Equals(other.GameLength)
                ) && 
                (
                    this.GameVersion == other.GameVersion ||
                    this.GameVersion != null &&
                    this.GameVersion.Equals(other.GameVersion)
                ) && 
                (
                    this.LastGameChunkId == other.LastGameChunkId ||
                    this.LastGameChunkId != null &&
                    this.LastGameChunkId.Equals(other.LastGameChunkId)
                ) && 
                (
                    this.LastKeyFrameId == other.LastKeyFrameId ||
                    this.LastKeyFrameId != null &&
                    this.LastKeyFrameId.Equals(other.LastKeyFrameId)
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
                if (this.GameLength != null)
                    hash = hash * 59 + this.GameLength.GetHashCode();
                if (this.GameVersion != null)
                    hash = hash * 59 + this.GameVersion.GetHashCode();
                if (this.LastGameChunkId != null)
                    hash = hash * 59 + this.LastGameChunkId.GetHashCode();
                if (this.LastKeyFrameId != null)
                    hash = hash * 59 + this.LastKeyFrameId.GetHashCode();
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
