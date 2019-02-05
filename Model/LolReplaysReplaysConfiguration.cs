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
    /// LolReplaysReplaysConfiguration
    /// </summary>
    [DataContract]
    public partial class LolReplaysReplaysConfiguration :  IEquatable<LolReplaysReplaysConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolReplaysReplaysConfiguration" /> class.
        /// </summary>
        /// <param name="GameVersion">GameVersion.</param>
        /// <param name="IsLoggedIn">IsLoggedIn.</param>
        /// <param name="IsPatching">IsPatching.</param>
        /// <param name="IsPlayingGame">IsPlayingGame.</param>
        /// <param name="IsPlayingReplay">IsPlayingReplay.</param>
        /// <param name="IsReplaysEnabled">IsReplaysEnabled.</param>
        /// <param name="IsReplaysForEndOfGameEnabled">IsReplaysForEndOfGameEnabled.</param>
        /// <param name="IsReplaysForMatchHistoryEnabled">IsReplaysForMatchHistoryEnabled.</param>
        /// <param name="MinServerVersion">MinServerVersion.</param>
        /// <param name="MinutesUntilReplayConsideredLost">MinutesUntilReplayConsideredLost.</param>
        public LolReplaysReplaysConfiguration(string GameVersion = default(string), bool? IsLoggedIn = default(bool?), bool? IsPatching = default(bool?), bool? IsPlayingGame = default(bool?), bool? IsPlayingReplay = default(bool?), bool? IsReplaysEnabled = default(bool?), bool? IsReplaysForEndOfGameEnabled = default(bool?), bool? IsReplaysForMatchHistoryEnabled = default(bool?), string MinServerVersion = default(string), double? MinutesUntilReplayConsideredLost = default(double?))
        {
            this.GameVersion = GameVersion;
            this.IsLoggedIn = IsLoggedIn;
            this.IsPatching = IsPatching;
            this.IsPlayingGame = IsPlayingGame;
            this.IsPlayingReplay = IsPlayingReplay;
            this.IsReplaysEnabled = IsReplaysEnabled;
            this.IsReplaysForEndOfGameEnabled = IsReplaysForEndOfGameEnabled;
            this.IsReplaysForMatchHistoryEnabled = IsReplaysForMatchHistoryEnabled;
            this.MinServerVersion = MinServerVersion;
            this.MinutesUntilReplayConsideredLost = MinutesUntilReplayConsideredLost;
        }
        
        /// <summary>
        /// Gets or Sets GameVersion
        /// </summary>
        [DataMember(Name="gameVersion", EmitDefaultValue=false)]
        public string GameVersion { get; set; }

        /// <summary>
        /// Gets or Sets IsLoggedIn
        /// </summary>
        [DataMember(Name="isLoggedIn", EmitDefaultValue=false)]
        public bool? IsLoggedIn { get; set; }

        /// <summary>
        /// Gets or Sets IsPatching
        /// </summary>
        [DataMember(Name="isPatching", EmitDefaultValue=false)]
        public bool? IsPatching { get; set; }

        /// <summary>
        /// Gets or Sets IsPlayingGame
        /// </summary>
        [DataMember(Name="isPlayingGame", EmitDefaultValue=false)]
        public bool? IsPlayingGame { get; set; }

        /// <summary>
        /// Gets or Sets IsPlayingReplay
        /// </summary>
        [DataMember(Name="isPlayingReplay", EmitDefaultValue=false)]
        public bool? IsPlayingReplay { get; set; }

        /// <summary>
        /// Gets or Sets IsReplaysEnabled
        /// </summary>
        [DataMember(Name="isReplaysEnabled", EmitDefaultValue=false)]
        public bool? IsReplaysEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsReplaysForEndOfGameEnabled
        /// </summary>
        [DataMember(Name="isReplaysForEndOfGameEnabled", EmitDefaultValue=false)]
        public bool? IsReplaysForEndOfGameEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsReplaysForMatchHistoryEnabled
        /// </summary>
        [DataMember(Name="isReplaysForMatchHistoryEnabled", EmitDefaultValue=false)]
        public bool? IsReplaysForMatchHistoryEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MinServerVersion
        /// </summary>
        [DataMember(Name="minServerVersion", EmitDefaultValue=false)]
        public string MinServerVersion { get; set; }

        /// <summary>
        /// Gets or Sets MinutesUntilReplayConsideredLost
        /// </summary>
        [DataMember(Name="minutesUntilReplayConsideredLost", EmitDefaultValue=false)]
        public double? MinutesUntilReplayConsideredLost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolReplaysReplaysConfiguration {\n");
            sb.Append("  GameVersion: ").Append(GameVersion).Append("\n");
            sb.Append("  IsLoggedIn: ").Append(IsLoggedIn).Append("\n");
            sb.Append("  IsPatching: ").Append(IsPatching).Append("\n");
            sb.Append("  IsPlayingGame: ").Append(IsPlayingGame).Append("\n");
            sb.Append("  IsPlayingReplay: ").Append(IsPlayingReplay).Append("\n");
            sb.Append("  IsReplaysEnabled: ").Append(IsReplaysEnabled).Append("\n");
            sb.Append("  IsReplaysForEndOfGameEnabled: ").Append(IsReplaysForEndOfGameEnabled).Append("\n");
            sb.Append("  IsReplaysForMatchHistoryEnabled: ").Append(IsReplaysForMatchHistoryEnabled).Append("\n");
            sb.Append("  MinServerVersion: ").Append(MinServerVersion).Append("\n");
            sb.Append("  MinutesUntilReplayConsideredLost: ").Append(MinutesUntilReplayConsideredLost).Append("\n");
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
            return this.Equals(obj as LolReplaysReplaysConfiguration);
        }

        /// <summary>
        /// Returns true if LolReplaysReplaysConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of LolReplaysReplaysConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolReplaysReplaysConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameVersion == other.GameVersion ||
                    this.GameVersion != null &&
                    this.GameVersion.Equals(other.GameVersion)
                ) && 
                (
                    this.IsLoggedIn == other.IsLoggedIn ||
                    this.IsLoggedIn != null &&
                    this.IsLoggedIn.Equals(other.IsLoggedIn)
                ) && 
                (
                    this.IsPatching == other.IsPatching ||
                    this.IsPatching != null &&
                    this.IsPatching.Equals(other.IsPatching)
                ) && 
                (
                    this.IsPlayingGame == other.IsPlayingGame ||
                    this.IsPlayingGame != null &&
                    this.IsPlayingGame.Equals(other.IsPlayingGame)
                ) && 
                (
                    this.IsPlayingReplay == other.IsPlayingReplay ||
                    this.IsPlayingReplay != null &&
                    this.IsPlayingReplay.Equals(other.IsPlayingReplay)
                ) && 
                (
                    this.IsReplaysEnabled == other.IsReplaysEnabled ||
                    this.IsReplaysEnabled != null &&
                    this.IsReplaysEnabled.Equals(other.IsReplaysEnabled)
                ) && 
                (
                    this.IsReplaysForEndOfGameEnabled == other.IsReplaysForEndOfGameEnabled ||
                    this.IsReplaysForEndOfGameEnabled != null &&
                    this.IsReplaysForEndOfGameEnabled.Equals(other.IsReplaysForEndOfGameEnabled)
                ) && 
                (
                    this.IsReplaysForMatchHistoryEnabled == other.IsReplaysForMatchHistoryEnabled ||
                    this.IsReplaysForMatchHistoryEnabled != null &&
                    this.IsReplaysForMatchHistoryEnabled.Equals(other.IsReplaysForMatchHistoryEnabled)
                ) && 
                (
                    this.MinServerVersion == other.MinServerVersion ||
                    this.MinServerVersion != null &&
                    this.MinServerVersion.Equals(other.MinServerVersion)
                ) && 
                (
                    this.MinutesUntilReplayConsideredLost == other.MinutesUntilReplayConsideredLost ||
                    this.MinutesUntilReplayConsideredLost != null &&
                    this.MinutesUntilReplayConsideredLost.Equals(other.MinutesUntilReplayConsideredLost)
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
                if (this.GameVersion != null)
                    hash = hash * 59 + this.GameVersion.GetHashCode();
                if (this.IsLoggedIn != null)
                    hash = hash * 59 + this.IsLoggedIn.GetHashCode();
                if (this.IsPatching != null)
                    hash = hash * 59 + this.IsPatching.GetHashCode();
                if (this.IsPlayingGame != null)
                    hash = hash * 59 + this.IsPlayingGame.GetHashCode();
                if (this.IsPlayingReplay != null)
                    hash = hash * 59 + this.IsPlayingReplay.GetHashCode();
                if (this.IsReplaysEnabled != null)
                    hash = hash * 59 + this.IsReplaysEnabled.GetHashCode();
                if (this.IsReplaysForEndOfGameEnabled != null)
                    hash = hash * 59 + this.IsReplaysForEndOfGameEnabled.GetHashCode();
                if (this.IsReplaysForMatchHistoryEnabled != null)
                    hash = hash * 59 + this.IsReplaysForMatchHistoryEnabled.GetHashCode();
                if (this.MinServerVersion != null)
                    hash = hash * 59 + this.MinServerVersion.GetHashCode();
                if (this.MinutesUntilReplayConsideredLost != null)
                    hash = hash * 59 + this.MinutesUntilReplayConsideredLost.GetHashCode();
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
