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
    /// LolSummonerAutoFillDto
    /// </summary>
    [DataContract]
    public partial class LolSummonerAutoFillDto :  IEquatable<LolSummonerAutoFillDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolSummonerAutoFillDto" /> class.
        /// </summary>
        /// <param name="AutoFillQueues">AutoFillQueues.</param>
        public LolSummonerAutoFillDto(List<LolSummonerAutoFillQueueDto> AutoFillQueues = default(List<LolSummonerAutoFillQueueDto>))
        {
            this.AutoFillQueues = AutoFillQueues;
        }
        
        /// <summary>
        /// Gets or Sets AutoFillQueues
        /// </summary>
        [DataMember(Name="autoFillQueues", EmitDefaultValue=false)]
        public List<LolSummonerAutoFillQueueDto> AutoFillQueues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolSummonerAutoFillDto {\n");
            sb.Append("  AutoFillQueues: ").Append(AutoFillQueues).Append("\n");
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
            return this.Equals(obj as LolSummonerAutoFillDto);
        }

        /// <summary>
        /// Returns true if LolSummonerAutoFillDto instances are equal
        /// </summary>
        /// <param name="other">Instance of LolSummonerAutoFillDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolSummonerAutoFillDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AutoFillQueues == other.AutoFillQueues ||
                    this.AutoFillQueues != null &&
                    this.AutoFillQueues.SequenceEqual(other.AutoFillQueues)
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
                if (this.AutoFillQueues != null)
                    hash = hash * 59 + this.AutoFillQueues.GetHashCode();
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
