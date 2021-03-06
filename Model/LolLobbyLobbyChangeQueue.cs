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
    /// LolLobbyLobbyChangeQueue
    /// </summary>
    [DataContract]
    public partial class LolLobbyLobbyChangeQueue :  IEquatable<LolLobbyLobbyChangeQueue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyLobbyChangeQueue" /> class.
        /// </summary>
        /// <param name="CustomGameLobby">CustomGameLobby.</param>
        /// <param name="IsCustom">IsCustom.</param>
        /// <param name="QueueId">QueueId.</param>
        public LolLobbyLobbyChangeQueue(LolLobbyLobbyCustomGameLobby CustomGameLobby = default(LolLobbyLobbyCustomGameLobby), bool? IsCustom = default(bool?), int? QueueId = default(int?))
        {
            this.CustomGameLobby = CustomGameLobby;
            this.IsCustom = IsCustom;
            this.QueueId = QueueId;
        }
        
        /// <summary>
        /// Gets or Sets CustomGameLobby
        /// </summary>
        [DataMember(Name="customGameLobby", EmitDefaultValue=false)]
        public LolLobbyLobbyCustomGameLobby CustomGameLobby { get; set; }

        /// <summary>
        /// Gets or Sets IsCustom
        /// </summary>
        [DataMember(Name="isCustom", EmitDefaultValue=false)]
        public bool? IsCustom { get; set; }

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
            sb.Append("class LolLobbyLobbyChangeQueue {\n");
            sb.Append("  CustomGameLobby: ").Append(CustomGameLobby).Append("\n");
            sb.Append("  IsCustom: ").Append(IsCustom).Append("\n");
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
            return this.Equals(obj as LolLobbyLobbyChangeQueue);
        }

        /// <summary>
        /// Returns true if LolLobbyLobbyChangeQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyLobbyChangeQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyLobbyChangeQueue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomGameLobby == other.CustomGameLobby ||
                    this.CustomGameLobby != null &&
                    this.CustomGameLobby.Equals(other.CustomGameLobby)
                ) && 
                (
                    this.IsCustom == other.IsCustom ||
                    this.IsCustom != null &&
                    this.IsCustom.Equals(other.IsCustom)
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
                if (this.CustomGameLobby != null)
                    hash = hash * 59 + this.CustomGameLobby.GetHashCode();
                if (this.IsCustom != null)
                    hash = hash * 59 + this.IsCustom.GetHashCode();
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
