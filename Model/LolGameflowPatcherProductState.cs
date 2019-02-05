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
    /// LolGameflowPatcherProductState
    /// </summary>
    [DataContract]
    public partial class LolGameflowPatcherProductState :  IEquatable<LolGameflowPatcherProductState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolGameflowPatcherProductState" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="IsCorrupted">IsCorrupted.</param>
        /// <param name="IsStopped">IsStopped.</param>
        /// <param name="IsUpToDate">IsUpToDate.</param>
        /// <param name="IsUpdateAvailable">IsUpdateAvailable.</param>
        public LolGameflowPatcherProductState(LolGameflowPatcherProductStateAction Action = default(LolGameflowPatcherProductStateAction), bool? IsCorrupted = default(bool?), bool? IsStopped = default(bool?), bool? IsUpToDate = default(bool?), bool? IsUpdateAvailable = default(bool?))
        {
            this.Action = Action;
            this.IsCorrupted = IsCorrupted;
            this.IsStopped = IsStopped;
            this.IsUpToDate = IsUpToDate;
            this.IsUpdateAvailable = IsUpdateAvailable;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public LolGameflowPatcherProductStateAction Action { get; set; }

        /// <summary>
        /// Gets or Sets IsCorrupted
        /// </summary>
        [DataMember(Name="isCorrupted", EmitDefaultValue=false)]
        public bool? IsCorrupted { get; set; }

        /// <summary>
        /// Gets or Sets IsStopped
        /// </summary>
        [DataMember(Name="isStopped", EmitDefaultValue=false)]
        public bool? IsStopped { get; set; }

        /// <summary>
        /// Gets or Sets IsUpToDate
        /// </summary>
        [DataMember(Name="isUpToDate", EmitDefaultValue=false)]
        public bool? IsUpToDate { get; set; }

        /// <summary>
        /// Gets or Sets IsUpdateAvailable
        /// </summary>
        [DataMember(Name="isUpdateAvailable", EmitDefaultValue=false)]
        public bool? IsUpdateAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolGameflowPatcherProductState {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  IsCorrupted: ").Append(IsCorrupted).Append("\n");
            sb.Append("  IsStopped: ").Append(IsStopped).Append("\n");
            sb.Append("  IsUpToDate: ").Append(IsUpToDate).Append("\n");
            sb.Append("  IsUpdateAvailable: ").Append(IsUpdateAvailable).Append("\n");
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
            return this.Equals(obj as LolGameflowPatcherProductState);
        }

        /// <summary>
        /// Returns true if LolGameflowPatcherProductState instances are equal
        /// </summary>
        /// <param name="other">Instance of LolGameflowPatcherProductState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolGameflowPatcherProductState other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.IsCorrupted == other.IsCorrupted ||
                    this.IsCorrupted != null &&
                    this.IsCorrupted.Equals(other.IsCorrupted)
                ) && 
                (
                    this.IsStopped == other.IsStopped ||
                    this.IsStopped != null &&
                    this.IsStopped.Equals(other.IsStopped)
                ) && 
                (
                    this.IsUpToDate == other.IsUpToDate ||
                    this.IsUpToDate != null &&
                    this.IsUpToDate.Equals(other.IsUpToDate)
                ) && 
                (
                    this.IsUpdateAvailable == other.IsUpdateAvailable ||
                    this.IsUpdateAvailable != null &&
                    this.IsUpdateAvailable.Equals(other.IsUpdateAvailable)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.IsCorrupted != null)
                    hash = hash * 59 + this.IsCorrupted.GetHashCode();
                if (this.IsStopped != null)
                    hash = hash * 59 + this.IsStopped.GetHashCode();
                if (this.IsUpToDate != null)
                    hash = hash * 59 + this.IsUpToDate.GetHashCode();
                if (this.IsUpdateAvailable != null)
                    hash = hash * 59 + this.IsUpdateAvailable.GetHashCode();
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
