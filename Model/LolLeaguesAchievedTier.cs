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
    /// LolLeaguesAchievedTier
    /// </summary>
    [DataContract]
    public partial class LolLeaguesAchievedTier :  IEquatable<LolLeaguesAchievedTier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLeaguesAchievedTier" /> class.
        /// </summary>
        /// <param name="Division">Division.</param>
        /// <param name="QueueType">QueueType.</param>
        /// <param name="Tier">Tier.</param>
        public LolLeaguesAchievedTier(long? Division = default(long?), LolLeaguesLeagueQueueType QueueType = default(LolLeaguesLeagueQueueType), LolLeaguesLeagueTier Tier = default(LolLeaguesLeagueTier))
        {
            this.Division = Division;
            this.QueueType = QueueType;
            this.Tier = Tier;
        }
        
        /// <summary>
        /// Gets or Sets Division
        /// </summary>
        [DataMember(Name="division", EmitDefaultValue=false)]
        public long? Division { get; set; }

        /// <summary>
        /// Gets or Sets QueueType
        /// </summary>
        [DataMember(Name="queueType", EmitDefaultValue=false)]
        public LolLeaguesLeagueQueueType QueueType { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public LolLeaguesLeagueTier Tier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLeaguesAchievedTier {\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  QueueType: ").Append(QueueType).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
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
            return this.Equals(obj as LolLeaguesAchievedTier);
        }

        /// <summary>
        /// Returns true if LolLeaguesAchievedTier instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLeaguesAchievedTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLeaguesAchievedTier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Division == other.Division ||
                    this.Division != null &&
                    this.Division.Equals(other.Division)
                ) && 
                (
                    this.QueueType == other.QueueType ||
                    this.QueueType != null &&
                    this.QueueType.Equals(other.QueueType)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
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
                if (this.Division != null)
                    hash = hash * 59 + this.Division.GetHashCode();
                if (this.QueueType != null)
                    hash = hash * 59 + this.QueueType.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
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
