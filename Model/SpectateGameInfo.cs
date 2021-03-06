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
    /// SpectateGameInfo
    /// </summary>
    [DataContract]
    public partial class SpectateGameInfo :  IEquatable<SpectateGameInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpectateGameInfo" /> class.
        /// </summary>
        /// <param name="AllowObserveMode">AllowObserveMode.</param>
        /// <param name="DropInSpectateGameId">DropInSpectateGameId.</param>
        /// <param name="GameQueueType">GameQueueType.</param>
        public SpectateGameInfo(string AllowObserveMode = default(string), string DropInSpectateGameId = default(string), string GameQueueType = default(string))
        {
            this.AllowObserveMode = AllowObserveMode;
            this.DropInSpectateGameId = DropInSpectateGameId;
            this.GameQueueType = GameQueueType;
        }
        
        /// <summary>
        /// Gets or Sets AllowObserveMode
        /// </summary>
        [DataMember(Name="allowObserveMode", EmitDefaultValue=false)]
        public string AllowObserveMode { get; set; }

        /// <summary>
        /// Gets or Sets DropInSpectateGameId
        /// </summary>
        [DataMember(Name="dropInSpectateGameId", EmitDefaultValue=false)]
        public string DropInSpectateGameId { get; set; }

        /// <summary>
        /// Gets or Sets GameQueueType
        /// </summary>
        [DataMember(Name="gameQueueType", EmitDefaultValue=false)]
        public string GameQueueType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpectateGameInfo {\n");
            sb.Append("  AllowObserveMode: ").Append(AllowObserveMode).Append("\n");
            sb.Append("  DropInSpectateGameId: ").Append(DropInSpectateGameId).Append("\n");
            sb.Append("  GameQueueType: ").Append(GameQueueType).Append("\n");
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
            return this.Equals(obj as SpectateGameInfo);
        }

        /// <summary>
        /// Returns true if SpectateGameInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of SpectateGameInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpectateGameInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowObserveMode == other.AllowObserveMode ||
                    this.AllowObserveMode != null &&
                    this.AllowObserveMode.Equals(other.AllowObserveMode)
                ) && 
                (
                    this.DropInSpectateGameId == other.DropInSpectateGameId ||
                    this.DropInSpectateGameId != null &&
                    this.DropInSpectateGameId.Equals(other.DropInSpectateGameId)
                ) && 
                (
                    this.GameQueueType == other.GameQueueType ||
                    this.GameQueueType != null &&
                    this.GameQueueType.Equals(other.GameQueueType)
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
                if (this.AllowObserveMode != null)
                    hash = hash * 59 + this.AllowObserveMode.GetHashCode();
                if (this.DropInSpectateGameId != null)
                    hash = hash * 59 + this.DropInSpectateGameId.GetHashCode();
                if (this.GameQueueType != null)
                    hash = hash * 59 + this.GameQueueType.GetHashCode();
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
