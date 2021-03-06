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
    /// GameClientChatMessageResource
    /// </summary>
    [DataContract]
    public partial class GameClientChatMessageResource :  IEquatable<GameClientChatMessageResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameClientChatMessageResource" /> class.
        /// </summary>
        /// <param name="Body">Body.</param>
        /// <param name="FromSummonerName">FromSummonerName.</param>
        public GameClientChatMessageResource(string Body = default(string), string FromSummonerName = default(string))
        {
            this.Body = Body;
            this.FromSummonerName = FromSummonerName;
        }
        
        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets FromSummonerName
        /// </summary>
        [DataMember(Name="fromSummonerName", EmitDefaultValue=false)]
        public string FromSummonerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GameClientChatMessageResource {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  FromSummonerName: ").Append(FromSummonerName).Append("\n");
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
            return this.Equals(obj as GameClientChatMessageResource);
        }

        /// <summary>
        /// Returns true if GameClientChatMessageResource instances are equal
        /// </summary>
        /// <param name="other">Instance of GameClientChatMessageResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GameClientChatMessageResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Body == other.Body ||
                    this.Body != null &&
                    this.Body.Equals(other.Body)
                ) && 
                (
                    this.FromSummonerName == other.FromSummonerName ||
                    this.FromSummonerName != null &&
                    this.FromSummonerName.Equals(other.FromSummonerName)
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
                if (this.Body != null)
                    hash = hash * 59 + this.Body.GetHashCode();
                if (this.FromSummonerName != null)
                    hash = hash * 59 + this.FromSummonerName.GetHashCode();
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
