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
    /// LolChatUserResource
    /// </summary>
    [DataContract]
    public partial class LolChatUserResource :  IEquatable<LolChatUserResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChatUserResource" /> class.
        /// </summary>
        /// <param name="Availability">Availability.</param>
        /// <param name="Icon">Icon.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LastSeenOnlineTimestamp">LastSeenOnlineTimestamp.</param>
        /// <param name="Lol">Lol.</param>
        /// <param name="Name">Name.</param>
        /// <param name="StatusMessage">StatusMessage.</param>
        public LolChatUserResource(string Availability = default(string), int? Icon = default(int?), long? Id = default(long?), string LastSeenOnlineTimestamp = default(string), Dictionary<string, string> Lol = default(Dictionary<string, string>), string Name = default(string), string StatusMessage = default(string))
        {
            this.Availability = Availability;
            this.Icon = Icon;
            this.Id = Id;
            this.LastSeenOnlineTimestamp = LastSeenOnlineTimestamp;
            this.Lol = Lol;
            this.Name = Name;
            this.StatusMessage = StatusMessage;
        }
        
        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public string Availability { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public int? Icon { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LastSeenOnlineTimestamp
        /// </summary>
        [DataMember(Name="lastSeenOnlineTimestamp", EmitDefaultValue=false)]
        public string LastSeenOnlineTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Lol
        /// </summary>
        [DataMember(Name="lol", EmitDefaultValue=false)]
        public Dictionary<string, string> Lol { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StatusMessage
        /// </summary>
        [DataMember(Name="statusMessage", EmitDefaultValue=false)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChatUserResource {\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastSeenOnlineTimestamp: ").Append(LastSeenOnlineTimestamp).Append("\n");
            sb.Append("  Lol: ").Append(Lol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StatusMessage: ").Append(StatusMessage).Append("\n");
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
            return this.Equals(obj as LolChatUserResource);
        }

        /// <summary>
        /// Returns true if LolChatUserResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChatUserResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChatUserResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Availability == other.Availability ||
                    this.Availability != null &&
                    this.Availability.Equals(other.Availability)
                ) && 
                (
                    this.Icon == other.Icon ||
                    this.Icon != null &&
                    this.Icon.Equals(other.Icon)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LastSeenOnlineTimestamp == other.LastSeenOnlineTimestamp ||
                    this.LastSeenOnlineTimestamp != null &&
                    this.LastSeenOnlineTimestamp.Equals(other.LastSeenOnlineTimestamp)
                ) && 
                (
                    this.Lol == other.Lol ||
                    this.Lol != null &&
                    this.Lol.SequenceEqual(other.Lol)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.StatusMessage == other.StatusMessage ||
                    this.StatusMessage != null &&
                    this.StatusMessage.Equals(other.StatusMessage)
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
                if (this.Availability != null)
                    hash = hash * 59 + this.Availability.GetHashCode();
                if (this.Icon != null)
                    hash = hash * 59 + this.Icon.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LastSeenOnlineTimestamp != null)
                    hash = hash * 59 + this.LastSeenOnlineTimestamp.GetHashCode();
                if (this.Lol != null)
                    hash = hash * 59 + this.Lol.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.StatusMessage != null)
                    hash = hash * 59 + this.StatusMessage.GetHashCode();
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
