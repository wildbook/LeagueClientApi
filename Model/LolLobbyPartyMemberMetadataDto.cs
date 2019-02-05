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
    /// LolLobbyPartyMemberMetadataDto
    /// </summary>
    [DataContract]
    public partial class LolLobbyPartyMemberMetadataDto :  IEquatable<LolLobbyPartyMemberMetadataDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyPartyMemberMetadataDto" /> class.
        /// </summary>
        /// <param name="PositionPref">PositionPref.</param>
        public LolLobbyPartyMemberMetadataDto(List<string> PositionPref = default(List<string>))
        {
            this.PositionPref = PositionPref;
        }
        
        /// <summary>
        /// Gets or Sets PositionPref
        /// </summary>
        [DataMember(Name="positionPref", EmitDefaultValue=false)]
        public List<string> PositionPref { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyPartyMemberMetadataDto {\n");
            sb.Append("  PositionPref: ").Append(PositionPref).Append("\n");
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
            return this.Equals(obj as LolLobbyPartyMemberMetadataDto);
        }

        /// <summary>
        /// Returns true if LolLobbyPartyMemberMetadataDto instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyPartyMemberMetadataDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyPartyMemberMetadataDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PositionPref == other.PositionPref ||
                    this.PositionPref != null &&
                    this.PositionPref.SequenceEqual(other.PositionPref)
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
                if (this.PositionPref != null)
                    hash = hash * 59 + this.PositionPref.GetHashCode();
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