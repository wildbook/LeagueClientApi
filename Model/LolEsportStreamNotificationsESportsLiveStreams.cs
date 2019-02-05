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
    /// LolEsportStreamNotificationsESportsLiveStreams
    /// </summary>
    [DataContract]
    public partial class LolEsportStreamNotificationsESportsLiveStreams :  IEquatable<LolEsportStreamNotificationsESportsLiveStreams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolEsportStreamNotificationsESportsLiveStreams" /> class.
        /// </summary>
        /// <param name="LiveStreams">LiveStreams.</param>
        public LolEsportStreamNotificationsESportsLiveStreams(List<LolEsportStreamNotificationsESportsStreams> LiveStreams = default(List<LolEsportStreamNotificationsESportsStreams>))
        {
            this.LiveStreams = LiveStreams;
        }
        
        /// <summary>
        /// Gets or Sets LiveStreams
        /// </summary>
        [DataMember(Name="liveStreams", EmitDefaultValue=false)]
        public List<LolEsportStreamNotificationsESportsStreams> LiveStreams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolEsportStreamNotificationsESportsLiveStreams {\n");
            sb.Append("  LiveStreams: ").Append(LiveStreams).Append("\n");
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
            return this.Equals(obj as LolEsportStreamNotificationsESportsLiveStreams);
        }

        /// <summary>
        /// Returns true if LolEsportStreamNotificationsESportsLiveStreams instances are equal
        /// </summary>
        /// <param name="other">Instance of LolEsportStreamNotificationsESportsLiveStreams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolEsportStreamNotificationsESportsLiveStreams other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LiveStreams == other.LiveStreams ||
                    this.LiveStreams != null &&
                    this.LiveStreams.SequenceEqual(other.LiveStreams)
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
                if (this.LiveStreams != null)
                    hash = hash * 59 + this.LiveStreams.GetHashCode();
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
