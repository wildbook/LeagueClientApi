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
    /// LolPftPFTEvent
    /// </summary>
    [DataContract]
    public partial class LolPftPFTEvent :  IEquatable<LolPftPFTEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPftPFTEvent" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="Data">Data.</param>
        /// <param name="PlayerSurveyId">PlayerSurveyId.</param>
        public LolPftPFTEvent(string Action = default(string), List<Object> Data = default(List<Object>), long? PlayerSurveyId = default(long?))
        {
            this.Action = Action;
            this.Data = Data;
            this.PlayerSurveyId = PlayerSurveyId;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<Object> Data { get; set; }

        /// <summary>
        /// Gets or Sets PlayerSurveyId
        /// </summary>
        [DataMember(Name="playerSurveyId", EmitDefaultValue=false)]
        public long? PlayerSurveyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPftPFTEvent {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  PlayerSurveyId: ").Append(PlayerSurveyId).Append("\n");
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
            return this.Equals(obj as LolPftPFTEvent);
        }

        /// <summary>
        /// Returns true if LolPftPFTEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPftPFTEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPftPFTEvent other)
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
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.PlayerSurveyId == other.PlayerSurveyId ||
                    this.PlayerSurveyId != null &&
                    this.PlayerSurveyId.Equals(other.PlayerSurveyId)
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.PlayerSurveyId != null)
                    hash = hash * 59 + this.PlayerSurveyId.GetHashCode();
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
