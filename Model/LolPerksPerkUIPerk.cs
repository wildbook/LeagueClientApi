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
    /// LolPerksPerkUIPerk
    /// </summary>
    [DataContract]
    public partial class LolPerksPerkUIPerk :  IEquatable<LolPerksPerkUIPerk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPerksPerkUIPerk" /> class.
        /// </summary>
        /// <param name="IconPath">IconPath.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LongDesc">LongDesc.</param>
        /// <param name="Name">Name.</param>
        /// <param name="ShortDesc">ShortDesc.</param>
        /// <param name="Tooltip">Tooltip.</param>
        public LolPerksPerkUIPerk(string IconPath = default(string), int? Id = default(int?), string LongDesc = default(string), string Name = default(string), string ShortDesc = default(string), string Tooltip = default(string))
        {
            this.IconPath = IconPath;
            this.Id = Id;
            this.LongDesc = LongDesc;
            this.Name = Name;
            this.ShortDesc = ShortDesc;
            this.Tooltip = Tooltip;
        }
        
        /// <summary>
        /// Gets or Sets IconPath
        /// </summary>
        [DataMember(Name="iconPath", EmitDefaultValue=false)]
        public string IconPath { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets LongDesc
        /// </summary>
        [DataMember(Name="longDesc", EmitDefaultValue=false)]
        public string LongDesc { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortDesc
        /// </summary>
        [DataMember(Name="shortDesc", EmitDefaultValue=false)]
        public string ShortDesc { get; set; }

        /// <summary>
        /// Gets or Sets Tooltip
        /// </summary>
        [DataMember(Name="tooltip", EmitDefaultValue=false)]
        public string Tooltip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPerksPerkUIPerk {\n");
            sb.Append("  IconPath: ").Append(IconPath).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongDesc: ").Append(LongDesc).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortDesc: ").Append(ShortDesc).Append("\n");
            sb.Append("  Tooltip: ").Append(Tooltip).Append("\n");
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
            return this.Equals(obj as LolPerksPerkUIPerk);
        }

        /// <summary>
        /// Returns true if LolPerksPerkUIPerk instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPerksPerkUIPerk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPerksPerkUIPerk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IconPath == other.IconPath ||
                    this.IconPath != null &&
                    this.IconPath.Equals(other.IconPath)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LongDesc == other.LongDesc ||
                    this.LongDesc != null &&
                    this.LongDesc.Equals(other.LongDesc)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ShortDesc == other.ShortDesc ||
                    this.ShortDesc != null &&
                    this.ShortDesc.Equals(other.ShortDesc)
                ) && 
                (
                    this.Tooltip == other.Tooltip ||
                    this.Tooltip != null &&
                    this.Tooltip.Equals(other.Tooltip)
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
                if (this.IconPath != null)
                    hash = hash * 59 + this.IconPath.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LongDesc != null)
                    hash = hash * 59 + this.LongDesc.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ShortDesc != null)
                    hash = hash * 59 + this.ShortDesc.GetHashCode();
                if (this.Tooltip != null)
                    hash = hash * 59 + this.Tooltip.GetHashCode();
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
