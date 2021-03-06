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
    /// PersonalizedOffersLcdsClientDynamicConfigurationNotification
    /// </summary>
    [DataContract]
    public partial class PersonalizedOffersLcdsClientDynamicConfigurationNotification :  IEquatable<PersonalizedOffersLcdsClientDynamicConfigurationNotification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalizedOffersLcdsClientDynamicConfigurationNotification" /> class.
        /// </summary>
        /// <param name="Configs">Configs.</param>
        /// <param name="Delta">Delta.</param>
        public PersonalizedOffersLcdsClientDynamicConfigurationNotification(string Configs = default(string), bool? Delta = default(bool?))
        {
            this.Configs = Configs;
            this.Delta = Delta;
        }
        
        /// <summary>
        /// Gets or Sets Configs
        /// </summary>
        [DataMember(Name="configs", EmitDefaultValue=false)]
        public string Configs { get; set; }

        /// <summary>
        /// Gets or Sets Delta
        /// </summary>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public bool? Delta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PersonalizedOffersLcdsClientDynamicConfigurationNotification {\n");
            sb.Append("  Configs: ").Append(Configs).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
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
            return this.Equals(obj as PersonalizedOffersLcdsClientDynamicConfigurationNotification);
        }

        /// <summary>
        /// Returns true if PersonalizedOffersLcdsClientDynamicConfigurationNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of PersonalizedOffersLcdsClientDynamicConfigurationNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonalizedOffersLcdsClientDynamicConfigurationNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Configs == other.Configs ||
                    this.Configs != null &&
                    this.Configs.Equals(other.Configs)
                ) && 
                (
                    this.Delta == other.Delta ||
                    this.Delta != null &&
                    this.Delta.Equals(other.Delta)
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
                if (this.Configs != null)
                    hash = hash * 59 + this.Configs.GetHashCode();
                if (this.Delta != null)
                    hash = hash * 59 + this.Delta.GetHashCode();
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
