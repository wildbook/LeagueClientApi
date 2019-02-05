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
    /// LolPlayerBehaviorPlayerNotificationResource
    /// </summary>
    [DataContract]
    public partial class LolPlayerBehaviorPlayerNotificationResource :  IEquatable<LolPlayerBehaviorPlayerNotificationResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPlayerBehaviorPlayerNotificationResource" /> class.
        /// </summary>
        /// <param name="BackgroundUrl">BackgroundUrl.</param>
        /// <param name="Created">Created.</param>
        /// <param name="Critical">Critical.</param>
        /// <param name="Data">Data.</param>
        /// <param name="DetailKey">DetailKey.</param>
        /// <param name="Expires">Expires.</param>
        /// <param name="IconUrl">IconUrl.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Source">Source.</param>
        /// <param name="State">State.</param>
        /// <param name="TitleKey">TitleKey.</param>
        /// <param name="Type">Type.</param>
        public LolPlayerBehaviorPlayerNotificationResource(string BackgroundUrl = default(string), string Created = default(string), bool? Critical = default(bool?), Dictionary<string, string> Data = default(Dictionary<string, string>), string DetailKey = default(string), string Expires = default(string), string IconUrl = default(string), long? Id = default(long?), string Source = default(string), string State = default(string), string TitleKey = default(string), string Type = default(string))
        {
            this.BackgroundUrl = BackgroundUrl;
            this.Created = Created;
            this.Critical = Critical;
            this.Data = Data;
            this.DetailKey = DetailKey;
            this.Expires = Expires;
            this.IconUrl = IconUrl;
            this.Id = Id;
            this.Source = Source;
            this.State = State;
            this.TitleKey = TitleKey;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets BackgroundUrl
        /// </summary>
        [DataMember(Name="backgroundUrl", EmitDefaultValue=false)]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }

        /// <summary>
        /// Gets or Sets Critical
        /// </summary>
        [DataMember(Name="critical", EmitDefaultValue=false)]
        public bool? Critical { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Gets or Sets DetailKey
        /// </summary>
        [DataMember(Name="detailKey", EmitDefaultValue=false)]
        public string DetailKey { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name="iconUrl", EmitDefaultValue=false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets TitleKey
        /// </summary>
        [DataMember(Name="titleKey", EmitDefaultValue=false)]
        public string TitleKey { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPlayerBehaviorPlayerNotificationResource {\n");
            sb.Append("  BackgroundUrl: ").Append(BackgroundUrl).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Critical: ").Append(Critical).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DetailKey: ").Append(DetailKey).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TitleKey: ").Append(TitleKey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LolPlayerBehaviorPlayerNotificationResource);
        }

        /// <summary>
        /// Returns true if LolPlayerBehaviorPlayerNotificationResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPlayerBehaviorPlayerNotificationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPlayerBehaviorPlayerNotificationResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BackgroundUrl == other.BackgroundUrl ||
                    this.BackgroundUrl != null &&
                    this.BackgroundUrl.Equals(other.BackgroundUrl)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.Critical == other.Critical ||
                    this.Critical != null &&
                    this.Critical.Equals(other.Critical)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) && 
                (
                    this.DetailKey == other.DetailKey ||
                    this.DetailKey != null &&
                    this.DetailKey.Equals(other.DetailKey)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) && 
                (
                    this.IconUrl == other.IconUrl ||
                    this.IconUrl != null &&
                    this.IconUrl.Equals(other.IconUrl)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.TitleKey == other.TitleKey ||
                    this.TitleKey != null &&
                    this.TitleKey.Equals(other.TitleKey)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.BackgroundUrl != null)
                    hash = hash * 59 + this.BackgroundUrl.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.Critical != null)
                    hash = hash * 59 + this.Critical.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.DetailKey != null)
                    hash = hash * 59 + this.DetailKey.GetHashCode();
                if (this.Expires != null)
                    hash = hash * 59 + this.Expires.GetHashCode();
                if (this.IconUrl != null)
                    hash = hash * 59 + this.IconUrl.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.TitleKey != null)
                    hash = hash * 59 + this.TitleKey.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
