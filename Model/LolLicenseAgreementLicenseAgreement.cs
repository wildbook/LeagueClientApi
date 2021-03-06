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
    /// LolLicenseAgreementLicenseAgreement
    /// </summary>
    [DataContract]
    public partial class LolLicenseAgreementLicenseAgreement :  IEquatable<LolLicenseAgreementLicenseAgreement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLicenseAgreementLicenseAgreement" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="LicenseType">LicenseType.</param>
        /// <param name="Text">Text.</param>
        public LolLicenseAgreementLicenseAgreement(string Id = default(string), LolLicenseAgreementLicenseAgreementType LicenseType = default(LolLicenseAgreementLicenseAgreementType), string Text = default(string))
        {
            this.Id = Id;
            this.LicenseType = LicenseType;
            this.Text = Text;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LicenseType
        /// </summary>
        [DataMember(Name="licenseType", EmitDefaultValue=false)]
        public LolLicenseAgreementLicenseAgreementType LicenseType { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLicenseAgreementLicenseAgreement {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as LolLicenseAgreementLicenseAgreement);
        }

        /// <summary>
        /// Returns true if LolLicenseAgreementLicenseAgreement instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLicenseAgreementLicenseAgreement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLicenseAgreementLicenseAgreement other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LicenseType == other.LicenseType ||
                    this.LicenseType != null &&
                    this.LicenseType.Equals(other.LicenseType)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LicenseType != null)
                    hash = hash * 59 + this.LicenseType.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
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
