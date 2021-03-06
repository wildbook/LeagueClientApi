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
    /// LolLobbyGameflowSession
    /// </summary>
    [DataContract]
    public partial class LolLobbyGameflowSession :  IEquatable<LolLobbyGameflowSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyGameflowSession" /> class.
        /// </summary>
        /// <param name="GameClient">GameClient.</param>
        /// <param name="GameDodge">GameDodge.</param>
        /// <param name="Phase">Phase.</param>
        public LolLobbyGameflowSession(LolLobbyGameflowGameClient GameClient = default(LolLobbyGameflowGameClient), LolLobbyGameflowGameDodge GameDodge = default(LolLobbyGameflowGameDodge), LolLobbyGameflowPhase Phase = default(LolLobbyGameflowPhase))
        {
            this.GameClient = GameClient;
            this.GameDodge = GameDodge;
            this.Phase = Phase;
        }
        
        /// <summary>
        /// Gets or Sets GameClient
        /// </summary>
        [DataMember(Name="gameClient", EmitDefaultValue=false)]
        public LolLobbyGameflowGameClient GameClient { get; set; }

        /// <summary>
        /// Gets or Sets GameDodge
        /// </summary>
        [DataMember(Name="gameDodge", EmitDefaultValue=false)]
        public LolLobbyGameflowGameDodge GameDodge { get; set; }

        /// <summary>
        /// Gets or Sets Phase
        /// </summary>
        [DataMember(Name="phase", EmitDefaultValue=false)]
        public LolLobbyGameflowPhase Phase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyGameflowSession {\n");
            sb.Append("  GameClient: ").Append(GameClient).Append("\n");
            sb.Append("  GameDodge: ").Append(GameDodge).Append("\n");
            sb.Append("  Phase: ").Append(Phase).Append("\n");
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
            return this.Equals(obj as LolLobbyGameflowSession);
        }

        /// <summary>
        /// Returns true if LolLobbyGameflowSession instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyGameflowSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyGameflowSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameClient == other.GameClient ||
                    this.GameClient != null &&
                    this.GameClient.Equals(other.GameClient)
                ) && 
                (
                    this.GameDodge == other.GameDodge ||
                    this.GameDodge != null &&
                    this.GameDodge.Equals(other.GameDodge)
                ) && 
                (
                    this.Phase == other.Phase ||
                    this.Phase != null &&
                    this.Phase.Equals(other.Phase)
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
                if (this.GameClient != null)
                    hash = hash * 59 + this.GameClient.GetHashCode();
                if (this.GameDodge != null)
                    hash = hash * 59 + this.GameDodge.GetHashCode();
                if (this.Phase != null)
                    hash = hash * 59 + this.Phase.GetHashCode();
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
