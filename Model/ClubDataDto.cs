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
    /// ClubDataDto
    /// </summary>
    [DataContract]
    public partial class ClubDataDto :  IEquatable<ClubDataDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClubDataDto" /> class.
        /// </summary>
        /// <param name="ClubKey">ClubKey.</param>
        /// <param name="CreatedTs">CreatedTs.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Jid">Jid.</param>
        /// <param name="LastModifiedTs">LastModifiedTs.</param>
        /// <param name="Motd">Motd.</param>
        /// <param name="Name">Name.</param>
        /// <param name="PermissionMap">PermissionMap.</param>
        /// <param name="Role">Role.</param>
        /// <param name="Tag">Tag.</param>
        public ClubDataDto(string ClubKey = default(string), long? CreatedTs = default(long?), string Description = default(string), string Jid = default(string), long? LastModifiedTs = default(long?), string Motd = default(string), string Name = default(string), ClubPermissions PermissionMap = default(ClubPermissions), string Role = default(string), string Tag = default(string))
        {
            this.ClubKey = ClubKey;
            this.CreatedTs = CreatedTs;
            this.Description = Description;
            this.Jid = Jid;
            this.LastModifiedTs = LastModifiedTs;
            this.Motd = Motd;
            this.Name = Name;
            this.PermissionMap = PermissionMap;
            this.Role = Role;
            this.Tag = Tag;
        }
        
        /// <summary>
        /// Gets or Sets ClubKey
        /// </summary>
        [DataMember(Name="clubKey", EmitDefaultValue=false)]
        public string ClubKey { get; set; }

        /// <summary>
        /// Gets or Sets CreatedTs
        /// </summary>
        [DataMember(Name="createdTs", EmitDefaultValue=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Jid
        /// </summary>
        [DataMember(Name="jid", EmitDefaultValue=false)]
        public string Jid { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedTs
        /// </summary>
        [DataMember(Name="lastModifiedTs", EmitDefaultValue=false)]
        public long? LastModifiedTs { get; set; }

        /// <summary>
        /// Gets or Sets Motd
        /// </summary>
        [DataMember(Name="motd", EmitDefaultValue=false)]
        public string Motd { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PermissionMap
        /// </summary>
        [DataMember(Name="permissionMap", EmitDefaultValue=false)]
        public ClubPermissions PermissionMap { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClubDataDto {\n");
            sb.Append("  ClubKey: ").Append(ClubKey).Append("\n");
            sb.Append("  CreatedTs: ").Append(CreatedTs).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Jid: ").Append(Jid).Append("\n");
            sb.Append("  LastModifiedTs: ").Append(LastModifiedTs).Append("\n");
            sb.Append("  Motd: ").Append(Motd).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PermissionMap: ").Append(PermissionMap).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(obj as ClubDataDto);
        }

        /// <summary>
        /// Returns true if ClubDataDto instances are equal
        /// </summary>
        /// <param name="other">Instance of ClubDataDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClubDataDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClubKey == other.ClubKey ||
                    this.ClubKey != null &&
                    this.ClubKey.Equals(other.ClubKey)
                ) && 
                (
                    this.CreatedTs == other.CreatedTs ||
                    this.CreatedTs != null &&
                    this.CreatedTs.Equals(other.CreatedTs)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Jid == other.Jid ||
                    this.Jid != null &&
                    this.Jid.Equals(other.Jid)
                ) && 
                (
                    this.LastModifiedTs == other.LastModifiedTs ||
                    this.LastModifiedTs != null &&
                    this.LastModifiedTs.Equals(other.LastModifiedTs)
                ) && 
                (
                    this.Motd == other.Motd ||
                    this.Motd != null &&
                    this.Motd.Equals(other.Motd)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PermissionMap == other.PermissionMap ||
                    this.PermissionMap != null &&
                    this.PermissionMap.Equals(other.PermissionMap)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.Tag == other.Tag ||
                    this.Tag != null &&
                    this.Tag.Equals(other.Tag)
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
                if (this.ClubKey != null)
                    hash = hash * 59 + this.ClubKey.GetHashCode();
                if (this.CreatedTs != null)
                    hash = hash * 59 + this.CreatedTs.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Jid != null)
                    hash = hash * 59 + this.Jid.GetHashCode();
                if (this.LastModifiedTs != null)
                    hash = hash * 59 + this.LastModifiedTs.GetHashCode();
                if (this.Motd != null)
                    hash = hash * 59 + this.Motd.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PermissionMap != null)
                    hash = hash * 59 + this.PermissionMap.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Tag != null)
                    hash = hash * 59 + this.Tag.GetHashCode();
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
