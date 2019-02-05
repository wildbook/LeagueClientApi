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
    /// LolClashPlayerChatRoster
    /// </summary>
    [DataContract]
    public partial class LolClashPlayerChatRoster :  IEquatable<LolClashPlayerChatRoster>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashPlayerChatRoster" /> class.
        /// </summary>
        /// <param name="EndTimeMs">EndTimeMs.</param>
        /// <param name="IconColorId">IconColorId.</param>
        /// <param name="IconId">IconId.</param>
        /// <param name="IsRegistered">IsRegistered.</param>
        /// <param name="Key">Key.</param>
        /// <param name="Name">Name.</param>
        /// <param name="PlayerState">PlayerState.</param>
        /// <param name="ShortName">ShortName.</param>
        /// <param name="StartTimeMs">StartTimeMs.</param>
        /// <param name="TournamentId">TournamentId.</param>
        /// <param name="TournamentState">TournamentState.</param>
        public LolClashPlayerChatRoster(long? EndTimeMs = default(long?), int? IconColorId = default(int?), int? IconId = default(int?), bool? IsRegistered = default(bool?), string Key = default(string), string Name = default(string), LolClashPlayerState PlayerState = default(LolClashPlayerState), string ShortName = default(string), long? StartTimeMs = default(long?), long? TournamentId = default(long?), LolClashTournamentState TournamentState = default(LolClashTournamentState))
        {
            this.EndTimeMs = EndTimeMs;
            this.IconColorId = IconColorId;
            this.IconId = IconId;
            this.IsRegistered = IsRegistered;
            this.Key = Key;
            this.Name = Name;
            this.PlayerState = PlayerState;
            this.ShortName = ShortName;
            this.StartTimeMs = StartTimeMs;
            this.TournamentId = TournamentId;
            this.TournamentState = TournamentState;
        }
        
        /// <summary>
        /// Gets or Sets EndTimeMs
        /// </summary>
        [DataMember(Name="endTimeMs", EmitDefaultValue=false)]
        public long? EndTimeMs { get; set; }

        /// <summary>
        /// Gets or Sets IconColorId
        /// </summary>
        [DataMember(Name="iconColorId", EmitDefaultValue=false)]
        public int? IconColorId { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name="iconId", EmitDefaultValue=false)]
        public int? IconId { get; set; }

        /// <summary>
        /// Gets or Sets IsRegistered
        /// </summary>
        [DataMember(Name="isRegistered", EmitDefaultValue=false)]
        public bool? IsRegistered { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PlayerState
        /// </summary>
        [DataMember(Name="playerState", EmitDefaultValue=false)]
        public LolClashPlayerState PlayerState { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets StartTimeMs
        /// </summary>
        [DataMember(Name="startTimeMs", EmitDefaultValue=false)]
        public long? StartTimeMs { get; set; }

        /// <summary>
        /// Gets or Sets TournamentId
        /// </summary>
        [DataMember(Name="tournamentId", EmitDefaultValue=false)]
        public long? TournamentId { get; set; }

        /// <summary>
        /// Gets or Sets TournamentState
        /// </summary>
        [DataMember(Name="tournamentState", EmitDefaultValue=false)]
        public LolClashTournamentState TournamentState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashPlayerChatRoster {\n");
            sb.Append("  EndTimeMs: ").Append(EndTimeMs).Append("\n");
            sb.Append("  IconColorId: ").Append(IconColorId).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PlayerState: ").Append(PlayerState).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  StartTimeMs: ").Append(StartTimeMs).Append("\n");
            sb.Append("  TournamentId: ").Append(TournamentId).Append("\n");
            sb.Append("  TournamentState: ").Append(TournamentState).Append("\n");
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
            return this.Equals(obj as LolClashPlayerChatRoster);
        }

        /// <summary>
        /// Returns true if LolClashPlayerChatRoster instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashPlayerChatRoster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashPlayerChatRoster other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndTimeMs == other.EndTimeMs ||
                    this.EndTimeMs != null &&
                    this.EndTimeMs.Equals(other.EndTimeMs)
                ) && 
                (
                    this.IconColorId == other.IconColorId ||
                    this.IconColorId != null &&
                    this.IconColorId.Equals(other.IconColorId)
                ) && 
                (
                    this.IconId == other.IconId ||
                    this.IconId != null &&
                    this.IconId.Equals(other.IconId)
                ) && 
                (
                    this.IsRegistered == other.IsRegistered ||
                    this.IsRegistered != null &&
                    this.IsRegistered.Equals(other.IsRegistered)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PlayerState == other.PlayerState ||
                    this.PlayerState != null &&
                    this.PlayerState.Equals(other.PlayerState)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.StartTimeMs == other.StartTimeMs ||
                    this.StartTimeMs != null &&
                    this.StartTimeMs.Equals(other.StartTimeMs)
                ) && 
                (
                    this.TournamentId == other.TournamentId ||
                    this.TournamentId != null &&
                    this.TournamentId.Equals(other.TournamentId)
                ) && 
                (
                    this.TournamentState == other.TournamentState ||
                    this.TournamentState != null &&
                    this.TournamentState.Equals(other.TournamentState)
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
                if (this.EndTimeMs != null)
                    hash = hash * 59 + this.EndTimeMs.GetHashCode();
                if (this.IconColorId != null)
                    hash = hash * 59 + this.IconColorId.GetHashCode();
                if (this.IconId != null)
                    hash = hash * 59 + this.IconId.GetHashCode();
                if (this.IsRegistered != null)
                    hash = hash * 59 + this.IsRegistered.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PlayerState != null)
                    hash = hash * 59 + this.PlayerState.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.StartTimeMs != null)
                    hash = hash * 59 + this.StartTimeMs.GetHashCode();
                if (this.TournamentId != null)
                    hash = hash * 59 + this.TournamentId.GetHashCode();
                if (this.TournamentState != null)
                    hash = hash * 59 + this.TournamentState.GetHashCode();
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
