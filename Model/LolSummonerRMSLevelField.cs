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
    /// LolSummonerRMSLevelField
    /// </summary>
    [DataContract]
    public partial class LolSummonerRMSLevelField :  IEquatable<LolSummonerRMSLevelField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolSummonerRMSLevelField" /> class.
        /// </summary>
        /// <param name="FinalLevel">FinalLevel.</param>
        /// <param name="InitialLevel">InitialLevel.</param>
        /// <param name="Progress">Progress.</param>
        public LolSummonerRMSLevelField(int? FinalLevel = default(int?), int? InitialLevel = default(int?), LolSummonerRMSLevelProgression Progress = default(LolSummonerRMSLevelProgression))
        {
            this.FinalLevel = FinalLevel;
            this.InitialLevel = InitialLevel;
            this.Progress = Progress;
        }
        
        /// <summary>
        /// Gets or Sets FinalLevel
        /// </summary>
        [DataMember(Name="finalLevel", EmitDefaultValue=false)]
        public int? FinalLevel { get; set; }

        /// <summary>
        /// Gets or Sets InitialLevel
        /// </summary>
        [DataMember(Name="initialLevel", EmitDefaultValue=false)]
        public int? InitialLevel { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public LolSummonerRMSLevelProgression Progress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolSummonerRMSLevelField {\n");
            sb.Append("  FinalLevel: ").Append(FinalLevel).Append("\n");
            sb.Append("  InitialLevel: ").Append(InitialLevel).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return this.Equals(obj as LolSummonerRMSLevelField);
        }

        /// <summary>
        /// Returns true if LolSummonerRMSLevelField instances are equal
        /// </summary>
        /// <param name="other">Instance of LolSummonerRMSLevelField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolSummonerRMSLevelField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FinalLevel == other.FinalLevel ||
                    this.FinalLevel != null &&
                    this.FinalLevel.Equals(other.FinalLevel)
                ) && 
                (
                    this.InitialLevel == other.InitialLevel ||
                    this.InitialLevel != null &&
                    this.InitialLevel.Equals(other.InitialLevel)
                ) && 
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.Equals(other.Progress)
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
                if (this.FinalLevel != null)
                    hash = hash * 59 + this.FinalLevel.GetHashCode();
                if (this.InitialLevel != null)
                    hash = hash * 59 + this.InitialLevel.GetHashCode();
                if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();
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
