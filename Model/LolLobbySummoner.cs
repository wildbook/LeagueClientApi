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
    /// LolLobbySummoner
    /// </summary>
    [DataContract]
    public partial class LolLobbySummoner :  IEquatable<LolLobbySummoner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbySummoner" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="ProfileIconId">ProfileIconId.</param>
        /// <param name="Puuid">Puuid.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerLevel">SummonerLevel.</param>
        public LolLobbySummoner(long? AccountId = default(long?), string DisplayName = default(string), int? ProfileIconId = default(int?), string Puuid = default(string), long? SummonerId = default(long?), int? SummonerLevel = default(int?))
        {
            this.AccountId = AccountId;
            this.DisplayName = DisplayName;
            this.ProfileIconId = ProfileIconId;
            this.Puuid = Puuid;
            this.SummonerId = SummonerId;
            this.SummonerLevel = SummonerLevel;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets ProfileIconId
        /// </summary>
        [DataMember(Name="profileIconId", EmitDefaultValue=false)]
        public int? ProfileIconId { get; set; }

        /// <summary>
        /// Gets or Sets Puuid
        /// </summary>
        [DataMember(Name="puuid", EmitDefaultValue=false)]
        public string Puuid { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets SummonerLevel
        /// </summary>
        [DataMember(Name="summonerLevel", EmitDefaultValue=false)]
        public int? SummonerLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbySummoner {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  ProfileIconId: ").Append(ProfileIconId).Append("\n");
            sb.Append("  Puuid: ").Append(Puuid).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerLevel: ").Append(SummonerLevel).Append("\n");
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
            return this.Equals(obj as LolLobbySummoner);
        }

        /// <summary>
        /// Returns true if LolLobbySummoner instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbySummoner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbySummoner other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.ProfileIconId == other.ProfileIconId ||
                    this.ProfileIconId != null &&
                    this.ProfileIconId.Equals(other.ProfileIconId)
                ) && 
                (
                    this.Puuid == other.Puuid ||
                    this.Puuid != null &&
                    this.Puuid.Equals(other.Puuid)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.SummonerLevel == other.SummonerLevel ||
                    this.SummonerLevel != null &&
                    this.SummonerLevel.Equals(other.SummonerLevel)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.ProfileIconId != null)
                    hash = hash * 59 + this.ProfileIconId.GetHashCode();
                if (this.Puuid != null)
                    hash = hash * 59 + this.Puuid.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerLevel != null)
                    hash = hash * 59 + this.SummonerLevel.GetHashCode();
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
