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
    /// LolChatLobbyMember
    /// </summary>
    [DataContract]
    public partial class LolChatLobbyMember :  IEquatable<LolChatLobbyMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChatLobbyMember" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="IsOwner">IsOwner.</param>
        public LolChatLobbyMember(long? Id = default(long?), bool? IsOwner = default(bool?))
        {
            this.Id = Id;
            this.IsOwner = IsOwner;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets IsOwner
        /// </summary>
        [DataMember(Name="isOwner", EmitDefaultValue=false)]
        public bool? IsOwner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChatLobbyMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
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
            return this.Equals(obj as LolChatLobbyMember);
        }

        /// <summary>
        /// Returns true if LolChatLobbyMember instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChatLobbyMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChatLobbyMember other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IsOwner == other.IsOwner ||
                    this.IsOwner != null &&
                    this.IsOwner.Equals(other.IsOwner)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.IsOwner != null)
                    hash = hash * 59 + this.IsOwner.GetHashCode();
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