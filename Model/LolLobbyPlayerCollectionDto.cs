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
    /// LolLobbyPlayerCollectionDto
    /// </summary>
    [DataContract]
    public partial class LolLobbyPlayerCollectionDto :  IEquatable<LolLobbyPlayerCollectionDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyPlayerCollectionDto" /> class.
        /// </summary>
        /// <param name="Players">Players.</param>
        public LolLobbyPlayerCollectionDto(List<LolLobbyPlayerDto> Players = default(List<LolLobbyPlayerDto>))
        {
            this.Players = Players;
        }
        
        /// <summary>
        /// Gets or Sets Players
        /// </summary>
        [DataMember(Name="players", EmitDefaultValue=false)]
        public List<LolLobbyPlayerDto> Players { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyPlayerCollectionDto {\n");
            sb.Append("  Players: ").Append(Players).Append("\n");
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
            return this.Equals(obj as LolLobbyPlayerCollectionDto);
        }

        /// <summary>
        /// Returns true if LolLobbyPlayerCollectionDto instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyPlayerCollectionDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyPlayerCollectionDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Players == other.Players ||
                    this.Players != null &&
                    this.Players.SequenceEqual(other.Players)
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
                if (this.Players != null)
                    hash = hash * 59 + this.Players.GetHashCode();
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
