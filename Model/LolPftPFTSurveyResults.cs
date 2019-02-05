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
    /// LolPftPFTSurveyResults
    /// </summary>
    [DataContract]
    public partial class LolPftPFTSurveyResults :  IEquatable<LolPftPFTSurveyResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPftPFTSurveyResults" /> class.
        /// </summary>
        /// <param name="Actions">Actions.</param>
        /// <param name="QuestionResponses">QuestionResponses.</param>
        public LolPftPFTSurveyResults(List<LolPftPFTEvent> Actions = default(List<LolPftPFTEvent>), List<LolPftPFTQuestionResponse> QuestionResponses = default(List<LolPftPFTQuestionResponse>))
        {
            this.Actions = Actions;
            this.QuestionResponses = QuestionResponses;
        }
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public List<LolPftPFTEvent> Actions { get; set; }

        /// <summary>
        /// Gets or Sets QuestionResponses
        /// </summary>
        [DataMember(Name="questionResponses", EmitDefaultValue=false)]
        public List<LolPftPFTQuestionResponse> QuestionResponses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPftPFTSurveyResults {\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  QuestionResponses: ").Append(QuestionResponses).Append("\n");
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
            return this.Equals(obj as LolPftPFTSurveyResults);
        }

        /// <summary>
        /// Returns true if LolPftPFTSurveyResults instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPftPFTSurveyResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPftPFTSurveyResults other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.SequenceEqual(other.Actions)
                ) && 
                (
                    this.QuestionResponses == other.QuestionResponses ||
                    this.QuestionResponses != null &&
                    this.QuestionResponses.SequenceEqual(other.QuestionResponses)
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
                if (this.Actions != null)
                    hash = hash * 59 + this.Actions.GetHashCode();
                if (this.QuestionResponses != null)
                    hash = hash * 59 + this.QuestionResponses.GetHashCode();
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
