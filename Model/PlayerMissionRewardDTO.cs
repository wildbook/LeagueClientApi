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
    /// PlayerMissionRewardDTO
    /// </summary>
    [DataContract]
    public partial class PlayerMissionRewardDTO :  IEquatable<PlayerMissionRewardDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerMissionRewardDTO" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="IconUrl">IconUrl.</param>
        /// <param name="ItemId">ItemId.</param>
        /// <param name="Media">Media.</param>
        /// <param name="RewardFulfilled">RewardFulfilled.</param>
        /// <param name="RewardType">RewardType.</param>
        public PlayerMissionRewardDTO(string Description = default(string), string IconUrl = default(string), string ItemId = default(string), MissionRewardMediaDTO Media = default(MissionRewardMediaDTO), bool? RewardFulfilled = default(bool?), string RewardType = default(string))
        {
            this.Description = Description;
            this.IconUrl = IconUrl;
            this.ItemId = ItemId;
            this.Media = Media;
            this.RewardFulfilled = RewardFulfilled;
            this.RewardType = RewardType;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets ItemId
        /// </summary>
        [DataMember(Name="itemId", EmitDefaultValue=false)]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public MissionRewardMediaDTO Media { get; set; }

        /// <summary>
        /// Gets or Sets RewardFulfilled
        /// </summary>
        [DataMember(Name="rewardFulfilled", EmitDefaultValue=false)]
        public bool? RewardFulfilled { get; set; }

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
            sb.Append("class PlayerMissionRewardDTO {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  RewardFulfilled: ").Append(RewardFulfilled).Append("\n");
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
            return this.Equals(obj as PlayerMissionRewardDTO);
        }

        /// <summary>
        /// Returns true if PlayerMissionRewardDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of PlayerMissionRewardDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlayerMissionRewardDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.IconUrl == other.IconUrl ||
                    this.IconUrl != null &&
                    this.IconUrl.Equals(other.IconUrl)
                ) && 
                (
                    this.ItemId == other.ItemId ||
                    this.ItemId != null &&
                    this.ItemId.Equals(other.ItemId)
                ) && 
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) && 
                (
                    this.RewardFulfilled == other.RewardFulfilled ||
                    this.RewardFulfilled != null &&
                    this.RewardFulfilled.Equals(other.RewardFulfilled)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.IconUrl != null)
                    hash = hash * 59 + this.IconUrl.GetHashCode();
                if (this.ItemId != null)
                    hash = hash * 59 + this.ItemId.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                if (this.RewardFulfilled != null)
                    hash = hash * 59 + this.RewardFulfilled.GetHashCode();
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
