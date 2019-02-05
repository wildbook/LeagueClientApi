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
    /// RsoAuthEntitlementsToken
    /// </summary>
    [DataContract]
    public partial class RsoAuthEntitlementsToken :  IEquatable<RsoAuthEntitlementsToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RsoAuthEntitlementsToken" /> class.
        /// </summary>
        /// <param name="Entitlements">Entitlements.</param>
        /// <param name="Expiry">Expiry.</param>
        /// <param name="Token">Token.</param>
        public RsoAuthEntitlementsToken(List<string> Entitlements = default(List<string>), long? Expiry = default(long?), string Token = default(string))
        {
            this.Entitlements = Entitlements;
            this.Expiry = Expiry;
            this.Token = Token;
        }
        
        /// <summary>
        /// Gets or Sets Entitlements
        /// </summary>
        [DataMember(Name="entitlements", EmitDefaultValue=false)]
        public List<string> Entitlements { get; set; }

        /// <summary>
        /// Gets or Sets Expiry
        /// </summary>
        [DataMember(Name="expiry", EmitDefaultValue=false)]
        public long? Expiry { get; set; }

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
            sb.Append("class RsoAuthEntitlementsToken {\n");
            sb.Append("  Entitlements: ").Append(Entitlements).Append("\n");
            sb.Append("  Expiry: ").Append(Expiry).Append("\n");
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
            return this.Equals(obj as RsoAuthEntitlementsToken);
        }

        /// <summary>
        /// Returns true if RsoAuthEntitlementsToken instances are equal
        /// </summary>
        /// <param name="other">Instance of RsoAuthEntitlementsToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RsoAuthEntitlementsToken other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Entitlements == other.Entitlements ||
                    this.Entitlements != null &&
                    this.Entitlements.SequenceEqual(other.Entitlements)
                ) && 
                (
                    this.Expiry == other.Expiry ||
                    this.Expiry != null &&
                    this.Expiry.Equals(other.Expiry)
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
                if (this.Entitlements != null)
                    hash = hash * 59 + this.Entitlements.GetHashCode();
                if (this.Expiry != null)
                    hash = hash * 59 + this.Expiry.GetHashCode();
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
