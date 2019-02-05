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
    /// LolSummonerRerollDataBagForClientV1
    /// </summary>
    [DataContract]
    public partial class LolSummonerRerollDataBagForClientV1 :  IEquatable<LolSummonerRerollDataBagForClientV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolSummonerRerollDataBagForClientV1" /> class.
        /// </summary>
        /// <param name="MaximumRerolls">MaximumRerolls.</param>
        /// <param name="PointCostOfReroll">PointCostOfReroll.</param>
        /// <param name="PointsGainedLastGame">PointsGainedLastGame.</param>
        /// <param name="PointsUntilNextReroll">PointsUntilNextReroll.</param>
        /// <param name="RerollCount">RerollCount.</param>
        /// <param name="TotalPoints">TotalPoints.</param>
        public LolSummonerRerollDataBagForClientV1(int? MaximumRerolls = default(int?), long? PointCostOfReroll = default(long?), long? PointsGainedLastGame = default(long?), long? PointsUntilNextReroll = default(long?), int? RerollCount = default(int?), long? TotalPoints = default(long?))
        {
            this.MaximumRerolls = MaximumRerolls;
            this.PointCostOfReroll = PointCostOfReroll;
            this.PointsGainedLastGame = PointsGainedLastGame;
            this.PointsUntilNextReroll = PointsUntilNextReroll;
            this.RerollCount = RerollCount;
            this.TotalPoints = TotalPoints;
        }
        
        /// <summary>
        /// Gets or Sets MaximumRerolls
        /// </summary>
        [DataMember(Name="maximumRerolls", EmitDefaultValue=false)]
        public int? MaximumRerolls { get; set; }

        /// <summary>
        /// Gets or Sets PointCostOfReroll
        /// </summary>
        [DataMember(Name="pointCostOfReroll", EmitDefaultValue=false)]
        public long? PointCostOfReroll { get; set; }

        /// <summary>
        /// Gets or Sets PointsGainedLastGame
        /// </summary>
        [DataMember(Name="pointsGainedLastGame", EmitDefaultValue=false)]
        public long? PointsGainedLastGame { get; set; }

        /// <summary>
        /// Gets or Sets PointsUntilNextReroll
        /// </summary>
        [DataMember(Name="pointsUntilNextReroll", EmitDefaultValue=false)]
        public long? PointsUntilNextReroll { get; set; }

        /// <summary>
        /// Gets or Sets RerollCount
        /// </summary>
        [DataMember(Name="rerollCount", EmitDefaultValue=false)]
        public int? RerollCount { get; set; }

        /// <summary>
        /// Gets or Sets TotalPoints
        /// </summary>
        [DataMember(Name="totalPoints", EmitDefaultValue=false)]
        public long? TotalPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolSummonerRerollDataBagForClientV1 {\n");
            sb.Append("  MaximumRerolls: ").Append(MaximumRerolls).Append("\n");
            sb.Append("  PointCostOfReroll: ").Append(PointCostOfReroll).Append("\n");
            sb.Append("  PointsGainedLastGame: ").Append(PointsGainedLastGame).Append("\n");
            sb.Append("  PointsUntilNextReroll: ").Append(PointsUntilNextReroll).Append("\n");
            sb.Append("  RerollCount: ").Append(RerollCount).Append("\n");
            sb.Append("  TotalPoints: ").Append(TotalPoints).Append("\n");
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
            return this.Equals(obj as LolSummonerRerollDataBagForClientV1);
        }

        /// <summary>
        /// Returns true if LolSummonerRerollDataBagForClientV1 instances are equal
        /// </summary>
        /// <param name="other">Instance of LolSummonerRerollDataBagForClientV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolSummonerRerollDataBagForClientV1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MaximumRerolls == other.MaximumRerolls ||
                    this.MaximumRerolls != null &&
                    this.MaximumRerolls.Equals(other.MaximumRerolls)
                ) && 
                (
                    this.PointCostOfReroll == other.PointCostOfReroll ||
                    this.PointCostOfReroll != null &&
                    this.PointCostOfReroll.Equals(other.PointCostOfReroll)
                ) && 
                (
                    this.PointsGainedLastGame == other.PointsGainedLastGame ||
                    this.PointsGainedLastGame != null &&
                    this.PointsGainedLastGame.Equals(other.PointsGainedLastGame)
                ) && 
                (
                    this.PointsUntilNextReroll == other.PointsUntilNextReroll ||
                    this.PointsUntilNextReroll != null &&
                    this.PointsUntilNextReroll.Equals(other.PointsUntilNextReroll)
                ) && 
                (
                    this.RerollCount == other.RerollCount ||
                    this.RerollCount != null &&
                    this.RerollCount.Equals(other.RerollCount)
                ) && 
                (
                    this.TotalPoints == other.TotalPoints ||
                    this.TotalPoints != null &&
                    this.TotalPoints.Equals(other.TotalPoints)
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
                if (this.MaximumRerolls != null)
                    hash = hash * 59 + this.MaximumRerolls.GetHashCode();
                if (this.PointCostOfReroll != null)
                    hash = hash * 59 + this.PointCostOfReroll.GetHashCode();
                if (this.PointsGainedLastGame != null)
                    hash = hash * 59 + this.PointsGainedLastGame.GetHashCode();
                if (this.PointsUntilNextReroll != null)
                    hash = hash * 59 + this.PointsUntilNextReroll.GetHashCode();
                if (this.RerollCount != null)
                    hash = hash * 59 + this.RerollCount.GetHashCode();
                if (this.TotalPoints != null)
                    hash = hash * 59 + this.TotalPoints.GetHashCode();
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
