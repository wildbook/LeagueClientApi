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
    /// LcdsPracticeGameConfig
    /// </summary>
    [DataContract]
    public partial class LcdsPracticeGameConfig :  IEquatable<LcdsPracticeGameConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LcdsPracticeGameConfig" /> class.
        /// </summary>
        /// <param name="AllowSpectators">AllowSpectators.</param>
        /// <param name="GameMap">GameMap.</param>
        /// <param name="GameMode">GameMode.</param>
        /// <param name="GameMutators">GameMutators.</param>
        /// <param name="GameName">GameName.</param>
        /// <param name="GamePassword">GamePassword.</param>
        /// <param name="GameTypeConfig">GameTypeConfig.</param>
        /// <param name="MaxNumPlayers">MaxNumPlayers.</param>
        /// <param name="PassbackDataPacket">PassbackDataPacket.</param>
        /// <param name="PassbackUrl">PassbackUrl.</param>
        /// <param name="Region">Region.</param>
        public LcdsPracticeGameConfig(string AllowSpectators = default(string), LcdsGameMap GameMap = default(LcdsGameMap), string GameMode = default(string), List<string> GameMutators = default(List<string>), string GameName = default(string), string GamePassword = default(string), int? GameTypeConfig = default(int?), int? MaxNumPlayers = default(int?), string PassbackDataPacket = default(string), string PassbackUrl = default(string), string Region = default(string))
        {
            this.AllowSpectators = AllowSpectators;
            this.GameMap = GameMap;
            this.GameMode = GameMode;
            this.GameMutators = GameMutators;
            this.GameName = GameName;
            this.GamePassword = GamePassword;
            this.GameTypeConfig = GameTypeConfig;
            this.MaxNumPlayers = MaxNumPlayers;
            this.PassbackDataPacket = PassbackDataPacket;
            this.PassbackUrl = PassbackUrl;
            this.Region = Region;
        }
        
        /// <summary>
        /// Gets or Sets AllowSpectators
        /// </summary>
        [DataMember(Name="allowSpectators", EmitDefaultValue=false)]
        public string AllowSpectators { get; set; }

        /// <summary>
        /// Gets or Sets GameMap
        /// </summary>
        [DataMember(Name="gameMap", EmitDefaultValue=false)]
        public LcdsGameMap GameMap { get; set; }

        /// <summary>
        /// Gets or Sets GameMode
        /// </summary>
        [DataMember(Name="gameMode", EmitDefaultValue=false)]
        public string GameMode { get; set; }

        /// <summary>
        /// Gets or Sets GameMutators
        /// </summary>
        [DataMember(Name="gameMutators", EmitDefaultValue=false)]
        public List<string> GameMutators { get; set; }

        /// <summary>
        /// Gets or Sets GameName
        /// </summary>
        [DataMember(Name="gameName", EmitDefaultValue=false)]
        public string GameName { get; set; }

        /// <summary>
        /// Gets or Sets GamePassword
        /// </summary>
        [DataMember(Name="gamePassword", EmitDefaultValue=false)]
        public string GamePassword { get; set; }

        /// <summary>
        /// Gets or Sets GameTypeConfig
        /// </summary>
        [DataMember(Name="gameTypeConfig", EmitDefaultValue=false)]
        public int? GameTypeConfig { get; set; }

        /// <summary>
        /// Gets or Sets MaxNumPlayers
        /// </summary>
        [DataMember(Name="maxNumPlayers", EmitDefaultValue=false)]
        public int? MaxNumPlayers { get; set; }

        /// <summary>
        /// Gets or Sets PassbackDataPacket
        /// </summary>
        [DataMember(Name="passbackDataPacket", EmitDefaultValue=false)]
        public string PassbackDataPacket { get; set; }

        /// <summary>
        /// Gets or Sets PassbackUrl
        /// </summary>
        [DataMember(Name="passbackUrl", EmitDefaultValue=false)]
        public string PassbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name="region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LcdsPracticeGameConfig {\n");
            sb.Append("  AllowSpectators: ").Append(AllowSpectators).Append("\n");
            sb.Append("  GameMap: ").Append(GameMap).Append("\n");
            sb.Append("  GameMode: ").Append(GameMode).Append("\n");
            sb.Append("  GameMutators: ").Append(GameMutators).Append("\n");
            sb.Append("  GameName: ").Append(GameName).Append("\n");
            sb.Append("  GamePassword: ").Append(GamePassword).Append("\n");
            sb.Append("  GameTypeConfig: ").Append(GameTypeConfig).Append("\n");
            sb.Append("  MaxNumPlayers: ").Append(MaxNumPlayers).Append("\n");
            sb.Append("  PassbackDataPacket: ").Append(PassbackDataPacket).Append("\n");
            sb.Append("  PassbackUrl: ").Append(PassbackUrl).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
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
            return this.Equals(obj as LcdsPracticeGameConfig);
        }

        /// <summary>
        /// Returns true if LcdsPracticeGameConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of LcdsPracticeGameConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LcdsPracticeGameConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllowSpectators == other.AllowSpectators ||
                    this.AllowSpectators != null &&
                    this.AllowSpectators.Equals(other.AllowSpectators)
                ) && 
                (
                    this.GameMap == other.GameMap ||
                    this.GameMap != null &&
                    this.GameMap.Equals(other.GameMap)
                ) && 
                (
                    this.GameMode == other.GameMode ||
                    this.GameMode != null &&
                    this.GameMode.Equals(other.GameMode)
                ) && 
                (
                    this.GameMutators == other.GameMutators ||
                    this.GameMutators != null &&
                    this.GameMutators.SequenceEqual(other.GameMutators)
                ) && 
                (
                    this.GameName == other.GameName ||
                    this.GameName != null &&
                    this.GameName.Equals(other.GameName)
                ) && 
                (
                    this.GamePassword == other.GamePassword ||
                    this.GamePassword != null &&
                    this.GamePassword.Equals(other.GamePassword)
                ) && 
                (
                    this.GameTypeConfig == other.GameTypeConfig ||
                    this.GameTypeConfig != null &&
                    this.GameTypeConfig.Equals(other.GameTypeConfig)
                ) && 
                (
                    this.MaxNumPlayers == other.MaxNumPlayers ||
                    this.MaxNumPlayers != null &&
                    this.MaxNumPlayers.Equals(other.MaxNumPlayers)
                ) && 
                (
                    this.PassbackDataPacket == other.PassbackDataPacket ||
                    this.PassbackDataPacket != null &&
                    this.PassbackDataPacket.Equals(other.PassbackDataPacket)
                ) && 
                (
                    this.PassbackUrl == other.PassbackUrl ||
                    this.PassbackUrl != null &&
                    this.PassbackUrl.Equals(other.PassbackUrl)
                ) && 
                (
                    this.Region == other.Region ||
                    this.Region != null &&
                    this.Region.Equals(other.Region)
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
                if (this.AllowSpectators != null)
                    hash = hash * 59 + this.AllowSpectators.GetHashCode();
                if (this.GameMap != null)
                    hash = hash * 59 + this.GameMap.GetHashCode();
                if (this.GameMode != null)
                    hash = hash * 59 + this.GameMode.GetHashCode();
                if (this.GameMutators != null)
                    hash = hash * 59 + this.GameMutators.GetHashCode();
                if (this.GameName != null)
                    hash = hash * 59 + this.GameName.GetHashCode();
                if (this.GamePassword != null)
                    hash = hash * 59 + this.GamePassword.GetHashCode();
                if (this.GameTypeConfig != null)
                    hash = hash * 59 + this.GameTypeConfig.GetHashCode();
                if (this.MaxNumPlayers != null)
                    hash = hash * 59 + this.MaxNumPlayers.GetHashCode();
                if (this.PassbackDataPacket != null)
                    hash = hash * 59 + this.PassbackDataPacket.GetHashCode();
                if (this.PassbackUrl != null)
                    hash = hash * 59 + this.PassbackUrl.GetHashCode();
                if (this.Region != null)
                    hash = hash * 59 + this.Region.GetHashCode();
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
