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
    /// LolSuggestedPlayersSuggestedPlayersConfig
    /// </summary>
    [DataContract]
    public partial class LolSuggestedPlayersSuggestedPlayersConfig :  IEquatable<LolSuggestedPlayersSuggestedPlayersConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolSuggestedPlayersSuggestedPlayersConfig" /> class.
        /// </summary>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="FriendsOfFriendsEnabled">FriendsOfFriendsEnabled.</param>
        /// <param name="FriendsOfFriendsLimit">FriendsOfFriendsLimit.</param>
        /// <param name="MaxNumReplacements">MaxNumReplacements.</param>
        /// <param name="MaxNumSuggestedPlayers">MaxNumSuggestedPlayers.</param>
        /// <param name="OnlineFriendsLimit">OnlineFriendsLimit.</param>
        /// <param name="PreviousPremadesLimit">PreviousPremadesLimit.</param>
        /// <param name="VicoriousComradesLimit">VicoriousComradesLimit.</param>
        public LolSuggestedPlayersSuggestedPlayersConfig(bool? Enabled = default(bool?), bool? FriendsOfFriendsEnabled = default(bool?), int? FriendsOfFriendsLimit = default(int?), int? MaxNumReplacements = default(int?), int? MaxNumSuggestedPlayers = default(int?), int? OnlineFriendsLimit = default(int?), int? PreviousPremadesLimit = default(int?), int? VicoriousComradesLimit = default(int?))
        {
            this.Enabled = Enabled;
            this.FriendsOfFriendsEnabled = FriendsOfFriendsEnabled;
            this.FriendsOfFriendsLimit = FriendsOfFriendsLimit;
            this.MaxNumReplacements = MaxNumReplacements;
            this.MaxNumSuggestedPlayers = MaxNumSuggestedPlayers;
            this.OnlineFriendsLimit = OnlineFriendsLimit;
            this.PreviousPremadesLimit = PreviousPremadesLimit;
            this.VicoriousComradesLimit = VicoriousComradesLimit;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets FriendsOfFriendsEnabled
        /// </summary>
        [DataMember(Name="FriendsOfFriendsEnabled", EmitDefaultValue=false)]
        public bool? FriendsOfFriendsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets FriendsOfFriendsLimit
        /// </summary>
        [DataMember(Name="FriendsOfFriendsLimit", EmitDefaultValue=false)]
        public int? FriendsOfFriendsLimit { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumReplacements
        /// </summary>
        [DataMember(Name="MaxNumReplacements", EmitDefaultValue=false)]
        public int? MaxNumReplacements { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumSuggestedPlayers
        /// </summary>
        [DataMember(Name="MaxNumSuggestedPlayers", EmitDefaultValue=false)]
        public int? MaxNumSuggestedPlayers { get; set; }

        /// <summary>
        /// Gets or Sets OnlineFriendsLimit
        /// </summary>
        [DataMember(Name="OnlineFriendsLimit", EmitDefaultValue=false)]
        public int? OnlineFriendsLimit { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPremadesLimit
        /// </summary>
        [DataMember(Name="PreviousPremadesLimit", EmitDefaultValue=false)]
        public int? PreviousPremadesLimit { get; set; }

        /// <summary>
        /// Gets or Sets VicoriousComradesLimit
        /// </summary>
        [DataMember(Name="VicoriousComradesLimit", EmitDefaultValue=false)]
        public int? VicoriousComradesLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolSuggestedPlayersSuggestedPlayersConfig {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FriendsOfFriendsEnabled: ").Append(FriendsOfFriendsEnabled).Append("\n");
            sb.Append("  FriendsOfFriendsLimit: ").Append(FriendsOfFriendsLimit).Append("\n");
            sb.Append("  MaxNumReplacements: ").Append(MaxNumReplacements).Append("\n");
            sb.Append("  MaxNumSuggestedPlayers: ").Append(MaxNumSuggestedPlayers).Append("\n");
            sb.Append("  OnlineFriendsLimit: ").Append(OnlineFriendsLimit).Append("\n");
            sb.Append("  PreviousPremadesLimit: ").Append(PreviousPremadesLimit).Append("\n");
            sb.Append("  VicoriousComradesLimit: ").Append(VicoriousComradesLimit).Append("\n");
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
            return this.Equals(obj as LolSuggestedPlayersSuggestedPlayersConfig);
        }

        /// <summary>
        /// Returns true if LolSuggestedPlayersSuggestedPlayersConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of LolSuggestedPlayersSuggestedPlayersConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolSuggestedPlayersSuggestedPlayersConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.FriendsOfFriendsEnabled == other.FriendsOfFriendsEnabled ||
                    this.FriendsOfFriendsEnabled != null &&
                    this.FriendsOfFriendsEnabled.Equals(other.FriendsOfFriendsEnabled)
                ) && 
                (
                    this.FriendsOfFriendsLimit == other.FriendsOfFriendsLimit ||
                    this.FriendsOfFriendsLimit != null &&
                    this.FriendsOfFriendsLimit.Equals(other.FriendsOfFriendsLimit)
                ) && 
                (
                    this.MaxNumReplacements == other.MaxNumReplacements ||
                    this.MaxNumReplacements != null &&
                    this.MaxNumReplacements.Equals(other.MaxNumReplacements)
                ) && 
                (
                    this.MaxNumSuggestedPlayers == other.MaxNumSuggestedPlayers ||
                    this.MaxNumSuggestedPlayers != null &&
                    this.MaxNumSuggestedPlayers.Equals(other.MaxNumSuggestedPlayers)
                ) && 
                (
                    this.OnlineFriendsLimit == other.OnlineFriendsLimit ||
                    this.OnlineFriendsLimit != null &&
                    this.OnlineFriendsLimit.Equals(other.OnlineFriendsLimit)
                ) && 
                (
                    this.PreviousPremadesLimit == other.PreviousPremadesLimit ||
                    this.PreviousPremadesLimit != null &&
                    this.PreviousPremadesLimit.Equals(other.PreviousPremadesLimit)
                ) && 
                (
                    this.VicoriousComradesLimit == other.VicoriousComradesLimit ||
                    this.VicoriousComradesLimit != null &&
                    this.VicoriousComradesLimit.Equals(other.VicoriousComradesLimit)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.FriendsOfFriendsEnabled != null)
                    hash = hash * 59 + this.FriendsOfFriendsEnabled.GetHashCode();
                if (this.FriendsOfFriendsLimit != null)
                    hash = hash * 59 + this.FriendsOfFriendsLimit.GetHashCode();
                if (this.MaxNumReplacements != null)
                    hash = hash * 59 + this.MaxNumReplacements.GetHashCode();
                if (this.MaxNumSuggestedPlayers != null)
                    hash = hash * 59 + this.MaxNumSuggestedPlayers.GetHashCode();
                if (this.OnlineFriendsLimit != null)
                    hash = hash * 59 + this.OnlineFriendsLimit.GetHashCode();
                if (this.PreviousPremadesLimit != null)
                    hash = hash * 59 + this.PreviousPremadesLimit.GetHashCode();
                if (this.VicoriousComradesLimit != null)
                    hash = hash * 59 + this.VicoriousComradesLimit.GetHashCode();
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
