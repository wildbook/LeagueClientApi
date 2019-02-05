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
    /// LolBannersCapClashFlagEntitlementPayload
    /// </summary>
    [DataContract]
    public partial class LolBannersCapClashFlagEntitlementPayload :  IEquatable<LolBannersCapClashFlagEntitlementPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolBannersCapClashFlagEntitlementPayload" /> class.
        /// </summary>
        /// <param name="EventId">EventId.</param>
        /// <param name="RewardSpec">RewardSpec.</param>
        /// <param name="RewardType">RewardType.</param>
        public LolBannersCapClashFlagEntitlementPayload(string EventId = default(string), LolBannersClashV2FlagRewardSpec RewardSpec = default(LolBannersClashV2FlagRewardSpec), string RewardType = default(string))
        {
            this.EventId = EventId;
            this.RewardSpec = RewardSpec;
            this.RewardType = RewardType;
        }
        
        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name="eventId", EmitDefaultValue=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Gets or Sets RewardSpec
        /// </summary>
        [DataMember(Name="rewardSpec", EmitDefaultValue=false)]
        public LolBannersClashV2FlagRewardSpec RewardSpec { get; set; }

        /// <summary>
        /// Gets or Sets RewardType
        /// </summary>
        [DataMember(Name="rewardType", EmitDefaultValue=false)]
        public string RewardType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolBannersCapClashFlagEntitlementPayload {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  RewardSpec: ").Append(RewardSpec).Append("\n");
            sb.Append("  RewardType: ").Append(RewardType).Append("\n");
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
            return this.Equals(obj as LolBannersCapClashFlagEntitlementPayload);
        }

        /// <summary>
        /// Returns true if LolBannersCapClashFlagEntitlementPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of LolBannersCapClashFlagEntitlementPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolBannersCapClashFlagEntitlementPayload other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventId == other.EventId ||
                    this.EventId != null &&
                    this.EventId.Equals(other.EventId)
                ) && 
                (
                    this.RewardSpec == other.RewardSpec ||
                    this.RewardSpec != null &&
                    this.RewardSpec.Equals(other.RewardSpec)
                ) && 
                (
                    this.RewardType == other.RewardType ||
                    this.RewardType != null &&
                    this.RewardType.Equals(other.RewardType)
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
                if (this.EventId != null)
                    hash = hash * 59 + this.EventId.GetHashCode();
                if (this.RewardSpec != null)
                    hash = hash * 59 + this.RewardSpec.GetHashCode();
                if (this.RewardType != null)
                    hash = hash * 59 + this.RewardType.GetHashCode();
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
