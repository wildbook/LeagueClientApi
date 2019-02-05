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
    /// LolLeaguesApexLeagues
    /// </summary>
    [DataContract]
    public partial class LolLeaguesApexLeagues :  IEquatable<LolLeaguesApexLeagues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLeaguesApexLeagues" /> class.
        /// </summary>
        /// <param name="Challengers">Challengers.</param>
        /// <param name="Masters">Masters.</param>
        public LolLeaguesApexLeagues(List<LolLeaguesLeague> Challengers = default(List<LolLeaguesLeague>), List<LolLeaguesLeague> Masters = default(List<LolLeaguesLeague>))
        {
            this.Challengers = Challengers;
            this.Masters = Masters;
        }
        
        /// <summary>
        /// Gets or Sets Challengers
        /// </summary>
        [DataMember(Name="challengers", EmitDefaultValue=false)]
        public List<LolLeaguesLeague> Challengers { get; set; }

        /// <summary>
        /// Gets or Sets Masters
        /// </summary>
        [DataMember(Name="masters", EmitDefaultValue=false)]
        public List<LolLeaguesLeague> Masters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLeaguesApexLeagues {\n");
            sb.Append("  Challengers: ").Append(Challengers).Append("\n");
            sb.Append("  Masters: ").Append(Masters).Append("\n");
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
            return this.Equals(obj as LolLeaguesApexLeagues);
        }

        /// <summary>
        /// Returns true if LolLeaguesApexLeagues instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLeaguesApexLeagues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLeaguesApexLeagues other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Challengers == other.Challengers ||
                    this.Challengers != null &&
                    this.Challengers.SequenceEqual(other.Challengers)
                ) && 
                (
                    this.Masters == other.Masters ||
                    this.Masters != null &&
                    this.Masters.SequenceEqual(other.Masters)
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
                if (this.Challengers != null)
                    hash = hash * 59 + this.Challengers.GetHashCode();
                if (this.Masters != null)
                    hash = hash * 59 + this.Masters.GetHashCode();
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