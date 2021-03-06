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
    /// LolLobbyPartyInviteDto
    /// </summary>
    [DataContract]
    public partial class LolLobbyPartyInviteDto :  IEquatable<LolLobbyPartyInviteDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyPartyInviteDto" /> class.
        /// </summary>
        /// <param name="GameMode">GameMode.</param>
        /// <param name="InvitedByPuuid">InvitedByPuuid.</param>
        /// <param name="PartyId">PartyId.</param>
        /// <param name="PartyVersion">PartyVersion.</param>
        /// <param name="State">State.</param>
        public LolLobbyPartyInviteDto(LolLobbyGameModeDto GameMode = default(LolLobbyGameModeDto), string InvitedByPuuid = default(string), string PartyId = default(string), int? PartyVersion = default(int?), string State = default(string))
        {
            this.GameMode = GameMode;
            this.InvitedByPuuid = InvitedByPuuid;
            this.PartyId = PartyId;
            this.PartyVersion = PartyVersion;
            this.State = State;
        }
        
        /// <summary>
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public LolLobbyGameModeDto GameMode { get; set; }

        /// <summary>
        /// Gets or Sets InvitedByPuuid
        /// </summary>
        [DataMember(Name="invitedByPuuid", EmitDefaultValue=false)]
        public string InvitedByPuuid { get; set; }

        /// <summary>
        /// Gets or Sets PartyId
        /// </summary>
        [DataMember(Name="partyId", EmitDefaultValue=false)]
        public string PartyId { get; set; }

        /// <summary>
        /// Gets or Sets PartyVersion
        /// </summary>
        [DataMember(Name="partyVersion", EmitDefaultValue=false)]
        public int? PartyVersion { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyPartyInviteDto {\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  InvitedByPuuid: ").Append(InvitedByPuuid).Append("\n");
            sb.Append("  PartyId: ").Append(PartyId).Append("\n");
            sb.Append("  PartyVersion: ").Append(PartyVersion).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as LolLobbyPartyInviteDto);
        }

        /// <summary>
        /// Returns true if LolLobbyPartyInviteDto instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyPartyInviteDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyPartyInviteDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameMode == other.GameMode ||
                    this.GameMode != null &&
                    this.GameMode.Equals(other.GameMode)
                ) && 
                (
                    this.InvitedByPuuid == other.InvitedByPuuid ||
                    this.InvitedByPuuid != null &&
                    this.InvitedByPuuid.Equals(other.InvitedByPuuid)
                ) && 
                (
                    this.PartyId == other.PartyId ||
                    this.PartyId != null &&
                    this.PartyId.Equals(other.PartyId)
                ) && 
                (
                    this.PartyVersion == other.PartyVersion ||
                    this.PartyVersion != null &&
                    this.PartyVersion.Equals(other.PartyVersion)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.GameMode != null)
                    hash = hash * 59 + this.GameMode.GetHashCode();
                if (this.InvitedByPuuid != null)
                    hash = hash * 59 + this.InvitedByPuuid.GetHashCode();
                if (this.PartyId != null)
                    hash = hash * 59 + this.PartyId.GetHashCode();
                if (this.PartyVersion != null)
                    hash = hash * 59 + this.PartyVersion.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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
