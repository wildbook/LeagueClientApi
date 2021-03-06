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
    /// LeaguesLcdsAggregatedStats
    /// </summary>
    [DataContract]
    public partial class LeaguesLcdsAggregatedStats :  IEquatable<LeaguesLcdsAggregatedStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeaguesLcdsAggregatedStats" /> class.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="LifetimeStatistics">LifetimeStatistics.</param>
        public LeaguesLcdsAggregatedStats(LeaguesLcdsAggregatedStatsKey Key = default(LeaguesLcdsAggregatedStatsKey), List<LeaguesLcdsAggregatedStat> LifetimeStatistics = default(List<LeaguesLcdsAggregatedStat>))
        {
            this.Key = Key;
            this.LifetimeStatistics = LifetimeStatistics;
        }
        
        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public LeaguesLcdsAggregatedStatsKey Key { get; set; }

        /// <summary>
        /// Gets or Sets LifetimeStatistics
        /// </summary>
        [DataMember(Name="lifetimeStatistics", EmitDefaultValue=false)]
        public List<LeaguesLcdsAggregatedStat> LifetimeStatistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaguesLcdsAggregatedStats {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LifetimeStatistics: ").Append(LifetimeStatistics).Append("\n");
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
            return this.Equals(obj as LeaguesLcdsAggregatedStats);
        }

        /// <summary>
        /// Returns true if LeaguesLcdsAggregatedStats instances are equal
        /// </summary>
        /// <param name="other">Instance of LeaguesLcdsAggregatedStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaguesLcdsAggregatedStats other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.LifetimeStatistics == other.LifetimeStatistics ||
                    this.LifetimeStatistics != null &&
                    this.LifetimeStatistics.SequenceEqual(other.LifetimeStatistics)
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
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.LifetimeStatistics != null)
                    hash = hash * 59 + this.LifetimeStatistics.GetHashCode();
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
