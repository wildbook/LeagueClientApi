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
    /// PlayerMembershipDto
    /// </summary>
    [DataContract]
    public partial class PlayerMembershipDto :  IEquatable<PlayerMembershipDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerMembershipDto" /> class.
        /// </summary>
        /// <param name="ActiveClubs">ActiveClubs.</param>
        /// <param name="ClubsServerConfig">ClubsServerConfig.</param>
        /// <param name="PendingInvites">PendingInvites.</param>
        /// <param name="Player">Player.</param>
        /// <param name="PlayerClubPreferences">PlayerClubPreferences.</param>
        /// <param name="RemovedClubs">RemovedClubs.</param>
        /// <param name="ResourceUri">ResourceUri.</param>
        /// <param name="RevokedInviteClubs">RevokedInviteClubs.</param>
        /// <param name="SecureClubPresenceInfoString">SecureClubPresenceInfoString.</param>
        public PlayerMembershipDto(List<ClubDto> ActiveClubs = default(List<ClubDto>), ClubsServerConfigDto ClubsServerConfig = default(ClubsServerConfigDto), List<MembershipInviteDto> PendingInvites = default(List<MembershipInviteDto>), PlayerInfoDto Player = default(PlayerInfoDto), PlayerMembershipPreferencesDto PlayerClubPreferences = default(PlayerMembershipPreferencesDto), List<ClubReferenceDto> RemovedClubs = default(List<ClubReferenceDto>), string ResourceUri = default(string), List<ClubReferenceDto> RevokedInviteClubs = default(List<ClubReferenceDto>), string SecureClubPresenceInfoString = default(string))
        {
            this.ActiveClubs = ActiveClubs;
            this.ClubsServerConfig = ClubsServerConfig;
            this.PendingInvites = PendingInvites;
            this.Player = Player;
            this.PlayerClubPreferences = PlayerClubPreferences;
            this.RemovedClubs = RemovedClubs;
            this.ResourceUri = ResourceUri;
            this.RevokedInviteClubs = RevokedInviteClubs;
            this.SecureClubPresenceInfoString = SecureClubPresenceInfoString;
        }
        
        /// <summary>
        /// Gets or Sets ActiveClubs
        /// </summary>
        [DataMember(Name="activeClubs", EmitDefaultValue=false)]
        public List<ClubDto> ActiveClubs { get; set; }

        /// <summary>
        /// Gets or Sets ClubsServerConfig
        /// </summary>
        [DataMember(Name="clubsServerConfig", EmitDefaultValue=false)]
        public ClubsServerConfigDto ClubsServerConfig { get; set; }

        /// <summary>
        /// Gets or Sets PendingInvites
        /// </summary>
        [DataMember(Name="pendingInvites", EmitDefaultValue=false)]
        public List<MembershipInviteDto> PendingInvites { get; set; }

        /// <summary>
        /// Gets or Sets Player
        /// </summary>
        [DataMember(Name="player", EmitDefaultValue=false)]
        public PlayerInfoDto Player { get; set; }

        /// <summary>
        /// Gets or Sets PlayerClubPreferences
        /// </summary>
        [DataMember(Name="playerClubPreferences", EmitDefaultValue=false)]
        public PlayerMembershipPreferencesDto PlayerClubPreferences { get; set; }

        /// <summary>
        /// Gets or Sets RemovedClubs
        /// </summary>
        [DataMember(Name="removedClubs", EmitDefaultValue=false)]
        public List<ClubReferenceDto> RemovedClubs { get; set; }

        /// <summary>
        /// Gets or Sets ResourceUri
        /// </summary>
        [DataMember(Name="resourceUri", EmitDefaultValue=false)]
        public string ResourceUri { get; set; }

        /// <summary>
        /// Gets or Sets RevokedInviteClubs
        /// </summary>
        [DataMember(Name="revokedInviteClubs", EmitDefaultValue=false)]
        public List<ClubReferenceDto> RevokedInviteClubs { get; set; }

        /// <summary>
        /// Gets or Sets SecureClubPresenceInfoString
        /// </summary>
        [DataMember(Name="secureClubPresenceInfoString", EmitDefaultValue=false)]
        public string SecureClubPresenceInfoString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PlayerMembershipDto {\n");
            sb.Append("  ActiveClubs: ").Append(ActiveClubs).Append("\n");
            sb.Append("  ClubsServerConfig: ").Append(ClubsServerConfig).Append("\n");
            sb.Append("  PendingInvites: ").Append(PendingInvites).Append("\n");
            sb.Append("  Player: ").Append(Player).Append("\n");
            sb.Append("  PlayerClubPreferences: ").Append(PlayerClubPreferences).Append("\n");
            sb.Append("  RemovedClubs: ").Append(RemovedClubs).Append("\n");
            sb.Append("  ResourceUri: ").Append(ResourceUri).Append("\n");
            sb.Append("  RevokedInviteClubs: ").Append(RevokedInviteClubs).Append("\n");
            sb.Append("  SecureClubPresenceInfoString: ").Append(SecureClubPresenceInfoString).Append("\n");
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
            return this.Equals(obj as PlayerMembershipDto);
        }

        /// <summary>
        /// Returns true if PlayerMembershipDto instances are equal
        /// </summary>
        /// <param name="other">Instance of PlayerMembershipDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerMembershipDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActiveClubs == other.ActiveClubs ||
                    this.ActiveClubs != null &&
                    this.ActiveClubs.SequenceEqual(other.ActiveClubs)
                ) && 
                (
                    this.ClubsServerConfig == other.ClubsServerConfig ||
                    this.ClubsServerConfig != null &&
                    this.ClubsServerConfig.Equals(other.ClubsServerConfig)
                ) && 
                (
                    this.PendingInvites == other.PendingInvites ||
                    this.PendingInvites != null &&
                    this.PendingInvites.SequenceEqual(other.PendingInvites)
                ) && 
                (
                    this.Player == other.Player ||
                    this.Player != null &&
                    this.Player.Equals(other.Player)
                ) && 
                (
                    this.PlayerClubPreferences == other.PlayerClubPreferences ||
                    this.PlayerClubPreferences != null &&
                    this.PlayerClubPreferences.Equals(other.PlayerClubPreferences)
                ) && 
                (
                    this.RemovedClubs == other.RemovedClubs ||
                    this.RemovedClubs != null &&
                    this.RemovedClubs.SequenceEqual(other.RemovedClubs)
                ) && 
                (
                    this.ResourceUri == other.ResourceUri ||
                    this.ResourceUri != null &&
                    this.ResourceUri.Equals(other.ResourceUri)
                ) && 
                (
                    this.RevokedInviteClubs == other.RevokedInviteClubs ||
                    this.RevokedInviteClubs != null &&
                    this.RevokedInviteClubs.SequenceEqual(other.RevokedInviteClubs)
                ) && 
                (
                    this.SecureClubPresenceInfoString == other.SecureClubPresenceInfoString ||
                    this.SecureClubPresenceInfoString != null &&
                    this.SecureClubPresenceInfoString.Equals(other.SecureClubPresenceInfoString)
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
                if (this.ActiveClubs != null)
                    hash = hash * 59 + this.ActiveClubs.GetHashCode();
                if (this.ClubsServerConfig != null)
                    hash = hash * 59 + this.ClubsServerConfig.GetHashCode();
                if (this.PendingInvites != null)
                    hash = hash * 59 + this.PendingInvites.GetHashCode();
                if (this.Player != null)
                    hash = hash * 59 + this.Player.GetHashCode();
                if (this.PlayerClubPreferences != null)
                    hash = hash * 59 + this.PlayerClubPreferences.GetHashCode();
                if (this.RemovedClubs != null)
                    hash = hash * 59 + this.RemovedClubs.GetHashCode();
                if (this.ResourceUri != null)
                    hash = hash * 59 + this.ResourceUri.GetHashCode();
                if (this.RevokedInviteClubs != null)
                    hash = hash * 59 + this.RevokedInviteClubs.GetHashCode();
                if (this.SecureClubPresenceInfoString != null)
                    hash = hash * 59 + this.SecureClubPresenceInfoString.GetHashCode();
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
