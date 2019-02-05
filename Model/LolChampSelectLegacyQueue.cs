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
    /// LolChampSelectLegacyQueue
    /// </summary>
    [DataContract]
    public partial class LolChampSelectLegacyQueue :  IEquatable<LolChampSelectLegacyQueue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampSelectLegacyQueue" /> class.
        /// </summary>
        /// <param name="AreFreeChampionsAllowed">AreFreeChampionsAllowed.</param>
        /// <param name="GameTypeConfig">GameTypeConfig.</param>
        public LolChampSelectLegacyQueue(bool? AreFreeChampionsAllowed = default(bool?), LolChampSelectLegacyQueueGameTypeConfig GameTypeConfig = default(LolChampSelectLegacyQueueGameTypeConfig))
        {
            this.AreFreeChampionsAllowed = AreFreeChampionsAllowed;
            this.GameTypeConfig = GameTypeConfig;
        }
        
        /// <summary>
        /// Gets or Sets AreFreeChampionsAllowed
        /// </summary>
        [DataMember(Name="areFreeChampionsAllowed", EmitDefaultValue=false)]
        public bool? AreFreeChampionsAllowed { get; set; }

        /// <summary>
        /// Gets or Sets GameTypeConfig
        /// </summary>
        [DataMember(Name="gameTypeConfig", EmitDefaultValue=false)]
        public LolChampSelectLegacyQueueGameTypeConfig GameTypeConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampSelectLegacyQueue {\n");
            sb.Append("  AreFreeChampionsAllowed: ").Append(AreFreeChampionsAllowed).Append("\n");
            sb.Append("  GameTypeConfig: ").Append(GameTypeConfig).Append("\n");
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
            return this.Equals(obj as LolChampSelectLegacyQueue);
        }

        /// <summary>
        /// Returns true if LolChampSelectLegacyQueue instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampSelectLegacyQueue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampSelectLegacyQueue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AreFreeChampionsAllowed == other.AreFreeChampionsAllowed ||
                    this.AreFreeChampionsAllowed != null &&
                    this.AreFreeChampionsAllowed.Equals(other.AreFreeChampionsAllowed)
                ) && 
                (
                    this.GameTypeConfig == other.GameTypeConfig ||
                    this.GameTypeConfig != null &&
                    this.GameTypeConfig.Equals(other.GameTypeConfig)
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
                if (this.AreFreeChampionsAllowed != null)
                    hash = hash * 59 + this.AreFreeChampionsAllowed.GetHashCode();
                if (this.GameTypeConfig != null)
                    hash = hash * 59 + this.GameTypeConfig.GetHashCode();
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
