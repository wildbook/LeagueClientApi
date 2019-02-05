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
    /// LolAccountVerificationVerifyRequest
    /// </summary>
    [DataContract]
    public partial class LolAccountVerificationVerifyRequest :  IEquatable<LolAccountVerificationVerifyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolAccountVerificationVerifyRequest" /> class.
        /// </summary>
        /// <param name="Mediator">Mediator.</param>
        /// <param name="Token">Token.</param>
        public LolAccountVerificationVerifyRequest(string Mediator = default(string), string Token = default(string))
        {
            this.Mediator = Mediator;
            this.Token = Token;
        }
        
        /// <summary>
        /// Gets or Sets Mediator
        /// </summary>
        [DataMember(Name="mediator", EmitDefaultValue=false)]
        public string Mediator { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolAccountVerificationVerifyRequest {\n");
            sb.Append("  Mediator: ").Append(Mediator).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(obj as LolAccountVerificationVerifyRequest);
        }

        /// <summary>
        /// Returns true if LolAccountVerificationVerifyRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of LolAccountVerificationVerifyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolAccountVerificationVerifyRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mediator == other.Mediator ||
                    this.Mediator != null &&
                    this.Mediator.Equals(other.Mediator)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this.Mediator != null)
                    hash = hash * 59 + this.Mediator.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
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
