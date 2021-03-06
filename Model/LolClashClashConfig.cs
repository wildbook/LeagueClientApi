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
    /// LolClashClashConfig
    /// </summary>
    [DataContract]
    public partial class LolClashClashConfig :  IEquatable<LolClashClashConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolClashClashConfig" /> class.
        /// </summary>
        /// <param name="DarkModeEntitlement">DarkModeEntitlement.</param>
        /// <param name="EnabledState">EnabledState.</param>
        /// <param name="IconConfig">IconConfig.</param>
        /// <param name="IsPlaymodeRestrictionEnabled">IsPlaymodeRestrictionEnabled.</param>
        /// <param name="UseIndividualEntitlement">UseIndividualEntitlement.</param>
        /// <param name="Visibility">Visibility.</param>
        public LolClashClashConfig(string DarkModeEntitlement = default(string), LolClashClashState EnabledState = default(LolClashClashState), string IconConfig = default(string), bool? IsPlaymodeRestrictionEnabled = default(bool?), bool? UseIndividualEntitlement = default(bool?), LolClashClashVisibility Visibility = default(LolClashClashVisibility))
        {
            this.DarkModeEntitlement = DarkModeEntitlement;
            this.EnabledState = EnabledState;
            this.IconConfig = IconConfig;
            this.IsPlaymodeRestrictionEnabled = IsPlaymodeRestrictionEnabled;
            this.UseIndividualEntitlement = UseIndividualEntitlement;
            this.Visibility = Visibility;
        }
        
        /// <summary>
        /// Gets or Sets DarkModeEntitlement
        /// </summary>
        [DataMember(Name="DarkModeEntitlement", EmitDefaultValue=false)]
        public string DarkModeEntitlement { get; set; }

        /// <summary>
        /// Gets or Sets EnabledState
        /// </summary>
        [DataMember(Name="EnabledState", EmitDefaultValue=false)]
        public LolClashClashState EnabledState { get; set; }

        /// <summary>
        /// Gets or Sets IconConfig
        /// </summary>
        [DataMember(Name="IconConfig", EmitDefaultValue=false)]
        public string IconConfig { get; set; }

        /// <summary>
        /// Gets or Sets IsPlaymodeRestrictionEnabled
        /// </summary>
        [DataMember(Name="IsPlaymodeRestrictionEnabled", EmitDefaultValue=false)]
        public bool? IsPlaymodeRestrictionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets UseIndividualEntitlement
        /// </summary>
        [DataMember(Name="UseIndividualEntitlement", EmitDefaultValue=false)]
        public bool? UseIndividualEntitlement { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name="Visibility", EmitDefaultValue=false)]
        public LolClashClashVisibility Visibility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolClashClashConfig {\n");
            sb.Append("  DarkModeEntitlement: ").Append(DarkModeEntitlement).Append("\n");
            sb.Append("  EnabledState: ").Append(EnabledState).Append("\n");
            sb.Append("  IconConfig: ").Append(IconConfig).Append("\n");
            sb.Append("  IsPlaymodeRestrictionEnabled: ").Append(IsPlaymodeRestrictionEnabled).Append("\n");
            sb.Append("  UseIndividualEntitlement: ").Append(UseIndividualEntitlement).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(obj as LolClashClashConfig);
        }

        /// <summary>
        /// Returns true if LolClashClashConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of LolClashClashConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolClashClashConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DarkModeEntitlement == other.DarkModeEntitlement ||
                    this.DarkModeEntitlement != null &&
                    this.DarkModeEntitlement.Equals(other.DarkModeEntitlement)
                ) && 
                (
                    this.EnabledState == other.EnabledState ||
                    this.EnabledState != null &&
                    this.EnabledState.Equals(other.EnabledState)
                ) && 
                (
                    this.IconConfig == other.IconConfig ||
                    this.IconConfig != null &&
                    this.IconConfig.Equals(other.IconConfig)
                ) && 
                (
                    this.IsPlaymodeRestrictionEnabled == other.IsPlaymodeRestrictionEnabled ||
                    this.IsPlaymodeRestrictionEnabled != null &&
                    this.IsPlaymodeRestrictionEnabled.Equals(other.IsPlaymodeRestrictionEnabled)
                ) && 
                (
                    this.UseIndividualEntitlement == other.UseIndividualEntitlement ||
                    this.UseIndividualEntitlement != null &&
                    this.UseIndividualEntitlement.Equals(other.UseIndividualEntitlement)
                ) && 
                (
                    this.Visibility == other.Visibility ||
                    this.Visibility != null &&
                    this.Visibility.Equals(other.Visibility)
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
                if (this.DarkModeEntitlement != null)
                    hash = hash * 59 + this.DarkModeEntitlement.GetHashCode();
                if (this.EnabledState != null)
                    hash = hash * 59 + this.EnabledState.GetHashCode();
                if (this.IconConfig != null)
                    hash = hash * 59 + this.IconConfig.GetHashCode();
                if (this.IsPlaymodeRestrictionEnabled != null)
                    hash = hash * 59 + this.IsPlaymodeRestrictionEnabled.GetHashCode();
                if (this.UseIndividualEntitlement != null)
                    hash = hash * 59 + this.UseIndividualEntitlement.GetHashCode();
                if (this.Visibility != null)
                    hash = hash * 59 + this.Visibility.GetHashCode();
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
