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
    /// LolChampSelectLegacyChampSelectBannedChampions
    /// </summary>
    [DataContract]
    public partial class LolChampSelectLegacyChampSelectBannedChampions :  IEquatable<LolChampSelectLegacyChampSelectBannedChampions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampSelectLegacyChampSelectBannedChampions" /> class.
        /// </summary>
        /// <param name="MyTeamBans">MyTeamBans.</param>
        /// <param name="NumBans">NumBans.</param>
        /// <param name="TheirTeamBans">TheirTeamBans.</param>
        public LolChampSelectLegacyChampSelectBannedChampions(List<int?> MyTeamBans = default(List<int?>), int? NumBans = default(int?), List<int?> TheirTeamBans = default(List<int?>))
        {
            this.MyTeamBans = MyTeamBans;
            this.NumBans = NumBans;
            this.TheirTeamBans = TheirTeamBans;
        }
        
        /// <summary>
        /// Gets or Sets MyTeamBans
        /// </summary>
        [DataMember(Name="myTeamBans", EmitDefaultValue=false)]
        public List<int?> MyTeamBans { get; set; }

        /// <summary>
        /// Gets or Sets NumBans
        /// </summary>
        [DataMember(Name="numBans", EmitDefaultValue=false)]
        public int? NumBans { get; set; }

        /// <summary>
        /// Gets or Sets TheirTeamBans
        /// </summary>
        [DataMember(Name="theirTeamBans", EmitDefaultValue=false)]
        public List<int?> TheirTeamBans { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampSelectLegacyChampSelectBannedChampions {\n");
            sb.Append("  MyTeamBans: ").Append(MyTeamBans).Append("\n");
            sb.Append("  NumBans: ").Append(NumBans).Append("\n");
            sb.Append("  TheirTeamBans: ").Append(TheirTeamBans).Append("\n");
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
            return this.Equals(obj as LolChampSelectLegacyChampSelectBannedChampions);
        }

        /// <summary>
        /// Returns true if LolChampSelectLegacyChampSelectBannedChampions instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampSelectLegacyChampSelectBannedChampions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampSelectLegacyChampSelectBannedChampions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MyTeamBans == other.MyTeamBans ||
                    this.MyTeamBans != null &&
                    this.MyTeamBans.SequenceEqual(other.MyTeamBans)
                ) && 
                (
                    this.NumBans == other.NumBans ||
                    this.NumBans != null &&
                    this.NumBans.Equals(other.NumBans)
                ) && 
                (
                    this.TheirTeamBans == other.TheirTeamBans ||
                    this.TheirTeamBans != null &&
                    this.TheirTeamBans.SequenceEqual(other.TheirTeamBans)
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
                if (this.MyTeamBans != null)
                    hash = hash * 59 + this.MyTeamBans.GetHashCode();
                if (this.NumBans != null)
                    hash = hash * 59 + this.NumBans.GetHashCode();
                if (this.TheirTeamBans != null)
                    hash = hash * 59 + this.TheirTeamBans.GetHashCode();
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
