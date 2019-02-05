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
    /// EndOfGameLcdsTeamInfo
    /// </summary>
    [DataContract]
    public partial class EndOfGameLcdsTeamInfo :  IEquatable<EndOfGameLcdsTeamInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EndOfGameLcdsTeamInfo" /> class.
        /// </summary>
        /// <param name="MemberStatusString">MemberStatusString.</param>
        /// <param name="Name">Name.</param>
        /// <param name="SecondsUntilEligibleForDeletion">SecondsUntilEligibleForDeletion.</param>
        /// <param name="Tag">Tag.</param>
        /// <param name="TeamId">TeamId.</param>
        public EndOfGameLcdsTeamInfo(string MemberStatusString = default(string), string Name = default(string), long? SecondsUntilEligibleForDeletion = default(long?), string Tag = default(string), EndOfGameLcdsTeamId TeamId = default(EndOfGameLcdsTeamId))
        {
            this.MemberStatusString = MemberStatusString;
            this.Name = Name;
            this.SecondsUntilEligibleForDeletion = SecondsUntilEligibleForDeletion;
            this.Tag = Tag;
            this.TeamId = TeamId;
        }
        
        /// <summary>
        /// Gets or Sets MemberStatusString
        /// </summary>
        [DataMember(Name="memberStatusString", EmitDefaultValue=false)]
        public string MemberStatusString { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SecondsUntilEligibleForDeletion
        /// </summary>
        [DataMember(Name="secondsUntilEligibleForDeletion", EmitDefaultValue=false)]
        public long? SecondsUntilEligibleForDeletion { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public EndOfGameLcdsTeamId TeamId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EndOfGameLcdsTeamInfo {\n");
            sb.Append("  MemberStatusString: ").Append(MemberStatusString).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SecondsUntilEligibleForDeletion: ").Append(SecondsUntilEligibleForDeletion).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
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
            return this.Equals(obj as EndOfGameLcdsTeamInfo);
        }

        /// <summary>
        /// Returns true if EndOfGameLcdsTeamInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of EndOfGameLcdsTeamInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EndOfGameLcdsTeamInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MemberStatusString == other.MemberStatusString ||
                    this.MemberStatusString != null &&
                    this.MemberStatusString.Equals(other.MemberStatusString)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SecondsUntilEligibleForDeletion == other.SecondsUntilEligibleForDeletion ||
                    this.SecondsUntilEligibleForDeletion != null &&
                    this.SecondsUntilEligibleForDeletion.Equals(other.SecondsUntilEligibleForDeletion)
                ) && 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
                ) && 
                (
                    this.TeamId == other.TeamId ||
                    this.TeamId != null &&
                    this.TeamId.Equals(other.TeamId)
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
                if (this.MemberStatusString != null)
                    hash = hash * 59 + this.MemberStatusString.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SecondsUntilEligibleForDeletion != null)
                    hash = hash * 59 + this.SecondsUntilEligibleForDeletion.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
                if (this.TeamId != null)
                    hash = hash * 59 + this.TeamId.GetHashCode();
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
