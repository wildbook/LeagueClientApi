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
    /// LolHonorV2VendedHonorChange
    /// </summary>
    [DataContract]
    public partial class LolHonorV2VendedHonorChange :  IEquatable<LolHonorV2VendedHonorChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolHonorV2VendedHonorChange" /> class.
        /// </summary>
        /// <param name="ActionType">ActionType.</param>
        /// <param name="CurrentState">CurrentState.</param>
        /// <param name="PreviousState">PreviousState.</param>
        /// <param name="Reward">Reward.</param>
        public LolHonorV2VendedHonorChange(string ActionType = default(string), LolHonorV2VendedHonorState CurrentState = default(LolHonorV2VendedHonorState), LolHonorV2VendedHonorState PreviousState = default(LolHonorV2VendedHonorState), LolHonorV2Reward Reward = default(LolHonorV2Reward))
        {
            this.ActionType = ActionType;
            this.CurrentState = CurrentState;
            this.PreviousState = PreviousState;
            this.Reward = Reward;
        }
        
        /// <summary>
        /// Gets or Sets ActionType
        /// </summary>
        [DataMember(Name="actionType", EmitDefaultValue=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// Gets or Sets CurrentState
        /// </summary>
        [DataMember(Name="currentState", EmitDefaultValue=false)]
        public LolHonorV2VendedHonorState CurrentState { get; set; }

        /// <summary>
        /// Gets or Sets PreviousState
        /// </summary>
        [DataMember(Name="previousState", EmitDefaultValue=false)]
        public LolHonorV2VendedHonorState PreviousState { get; set; }

        /// <summary>
        /// Gets or Sets Reward
        /// </summary>
        [DataMember(Name="reward", EmitDefaultValue=false)]
        public LolHonorV2Reward Reward { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolHonorV2VendedHonorChange {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  CurrentState: ").Append(CurrentState).Append("\n");
            sb.Append("  PreviousState: ").Append(PreviousState).Append("\n");
            sb.Append("  Reward: ").Append(Reward).Append("\n");
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
            return this.Equals(obj as LolHonorV2VendedHonorChange);
        }

        /// <summary>
        /// Returns true if LolHonorV2VendedHonorChange instances are equal
        /// </summary>
        /// <param name="other">Instance of LolHonorV2VendedHonorChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolHonorV2VendedHonorChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActionType == other.ActionType ||
                    this.ActionType != null &&
                    this.ActionType.Equals(other.ActionType)
                ) && 
                (
                    this.CurrentState == other.CurrentState ||
                    this.CurrentState != null &&
                    this.CurrentState.Equals(other.CurrentState)
                ) && 
                (
                    this.PreviousState == other.PreviousState ||
                    this.PreviousState != null &&
                    this.PreviousState.Equals(other.PreviousState)
                ) && 
                (
                    this.Reward == other.Reward ||
                    this.Reward != null &&
                    this.Reward.Equals(other.Reward)
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
                if (this.ActionType != null)
                    hash = hash * 59 + this.ActionType.GetHashCode();
                if (this.CurrentState != null)
                    hash = hash * 59 + this.CurrentState.GetHashCode();
                if (this.PreviousState != null)
                    hash = hash * 59 + this.PreviousState.GetHashCode();
                if (this.Reward != null)
                    hash = hash * 59 + this.Reward.GetHashCode();
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
