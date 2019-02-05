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
    /// LcdsMember
    /// </summary>
    [DataContract]
    public partial class LcdsMember :  IEquatable<LcdsMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LcdsMember" /> class.
        /// </summary>
        /// <param name="HasDelegatedInvitePower">HasDelegatedInvitePower.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerName">SummonerName.</param>
        public LcdsMember(bool? HasDelegatedInvitePower = default(bool?), long? SummonerId = default(long?), string SummonerName = default(string))
        {
            this.HasDelegatedInvitePower = HasDelegatedInvitePower;
            this.SummonerId = SummonerId;
            this.SummonerName = SummonerName;
        }
        
        /// <summary>
        /// Gets or Sets HasDelegatedInvitePower
        /// </summary>
        [DataMember(Name="hasDelegatedInvitePower", EmitDefaultValue=false)]
        public bool? HasDelegatedInvitePower { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets SummonerName
        /// </summary>
        [DataMember(Name="summonerName", EmitDefaultValue=false)]
        public string SummonerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LcdsMember {\n");
            sb.Append("  HasDelegatedInvitePower: ").Append(HasDelegatedInvitePower).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerName: ").Append(SummonerName).Append("\n");
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
            return this.Equals(obj as LcdsMember);
        }

        /// <summary>
        /// Returns true if LcdsMember instances are equal
        /// </summary>
        /// <param name="other">Instance of LcdsMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LcdsMember other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HasDelegatedInvitePower == other.HasDelegatedInvitePower ||
                    this.HasDelegatedInvitePower != null &&
                    this.HasDelegatedInvitePower.Equals(other.HasDelegatedInvitePower)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.SummonerName == other.SummonerName ||
                    this.SummonerName != null &&
                    this.SummonerName.Equals(other.SummonerName)
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
                if (this.HasDelegatedInvitePower != null)
                    hash = hash * 59 + this.HasDelegatedInvitePower.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerName != null)
                    hash = hash * 59 + this.SummonerName.GetHashCode();
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
