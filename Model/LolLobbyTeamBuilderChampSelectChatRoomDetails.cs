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
    /// LolLobbyTeamBuilderChampSelectChatRoomDetails
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderChampSelectChatRoomDetails :  IEquatable<LolLobbyTeamBuilderChampSelectChatRoomDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderChampSelectChatRoomDetails" /> class.
        /// </summary>
        /// <param name="ChatRoomName">ChatRoomName.</param>
        /// <param name="ChatRoomPassword">ChatRoomPassword.</param>
        public LolLobbyTeamBuilderChampSelectChatRoomDetails(string ChatRoomName = default(string), string ChatRoomPassword = default(string))
        {
            this.ChatRoomName = ChatRoomName;
            this.ChatRoomPassword = ChatRoomPassword;
        }
        
        /// <summary>
        /// Gets or Sets ChatRoomName
        /// </summary>
        [DataMember(Name="chatRoomName", EmitDefaultValue=false)]
        public string ChatRoomName { get; set; }

        /// <summary>
        /// Gets or Sets ChatRoomPassword
        /// </summary>
        [DataMember(Name="chatRoomPassword", EmitDefaultValue=false)]
        public string ChatRoomPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderChampSelectChatRoomDetails {\n");
            sb.Append("  ChatRoomName: ").Append(ChatRoomName).Append("\n");
            sb.Append("  ChatRoomPassword: ").Append(ChatRoomPassword).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderChampSelectChatRoomDetails);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderChampSelectChatRoomDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderChampSelectChatRoomDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderChampSelectChatRoomDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChatRoomName == other.ChatRoomName ||
                    this.ChatRoomName != null &&
                    this.ChatRoomName.Equals(other.ChatRoomName)
                ) && 
                (
                    this.ChatRoomPassword == other.ChatRoomPassword ||
                    this.ChatRoomPassword != null &&
                    this.ChatRoomPassword.Equals(other.ChatRoomPassword)
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
                if (this.ChatRoomName != null)
                    hash = hash * 59 + this.ChatRoomName.GetHashCode();
                if (this.ChatRoomPassword != null)
                    hash = hash * 59 + this.ChatRoomPassword.GetHashCode();
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
