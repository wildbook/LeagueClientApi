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
    /// LolLobbyTeamBuilderCellV1
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderCellV1 :  IEquatable<LolLobbyTeamBuilderCellV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderCellV1" /> class.
        /// </summary>
        /// <param name="AssignedPosition">AssignedPosition.</param>
        /// <param name="CellId">CellId.</param>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="ChampionPickIntent">ChampionPickIntent.</param>
        /// <param name="SkinId">SkinId.</param>
        /// <param name="Spell1Id">Spell1Id.</param>
        /// <param name="Spell2Id">Spell2Id.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="SummonerName">SummonerName.</param>
        /// <param name="TeamId">TeamId.</param>
        public LolLobbyTeamBuilderCellV1(string AssignedPosition = default(string), int? CellId = default(int?), int? ChampionId = default(int?), int? ChampionPickIntent = default(int?), int? SkinId = default(int?), int? Spell1Id = default(int?), int? Spell2Id = default(int?), long? SummonerId = default(long?), string SummonerName = default(string), int? TeamId = default(int?))
        {
            this.AssignedPosition = AssignedPosition;
            this.CellId = CellId;
            this.ChampionId = ChampionId;
            this.ChampionPickIntent = ChampionPickIntent;
            this.SkinId = SkinId;
            this.Spell1Id = Spell1Id;
            this.Spell2Id = Spell2Id;
            this.SummonerId = SummonerId;
            this.SummonerName = SummonerName;
            this.TeamId = TeamId;
        }
        
        /// <summary>
        /// Gets or Sets AssignedPosition
        /// </summary>
        [DataMember(Name="assignedPosition", EmitDefaultValue=false)]
        public string AssignedPosition { get; set; }

        /// <summary>
        /// Gets or Sets CellId
        /// </summary>
        [DataMember(Name="cellId", EmitDefaultValue=false)]
        public int? CellId { get; set; }

        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets ChampionPickIntent
        /// </summary>
        [DataMember(Name="championPickIntent", EmitDefaultValue=false)]
        public int? ChampionPickIntent { get; set; }

        /// <summary>
        /// Gets or Sets SkinId
        /// </summary>
        [DataMember(Name="skinId", EmitDefaultValue=false)]
        public int? SkinId { get; set; }

        /// <summary>
        /// Gets or Sets Spell1Id
        /// </summary>
        [DataMember(Name="spell1Id", EmitDefaultValue=false)]
        public int? Spell1Id { get; set; }

        /// <summary>
        /// Gets or Sets Spell2Id
        /// </summary>
        [DataMember(Name="spell2Id", EmitDefaultValue=false)]
        public int? Spell2Id { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets SummonerName
        /// </summary>
        [DataMember(Name="summonerName", EmitDefaultValue=false)]
        public string SummonerName { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public int? TeamId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderCellV1 {\n");
            sb.Append("  AssignedPosition: ").Append(AssignedPosition).Append("\n");
            sb.Append("  CellId: ").Append(CellId).Append("\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  ChampionPickIntent: ").Append(ChampionPickIntent).Append("\n");
            sb.Append("  SkinId: ").Append(SkinId).Append("\n");
            sb.Append("  Spell1Id: ").Append(Spell1Id).Append("\n");
            sb.Append("  Spell2Id: ").Append(Spell2Id).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  SummonerName: ").Append(SummonerName).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderCellV1);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderCellV1 instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderCellV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderCellV1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AssignedPosition == other.AssignedPosition ||
                    this.AssignedPosition != null &&
                    this.AssignedPosition.Equals(other.AssignedPosition)
                ) && 
                (
                    this.CellId == other.CellId ||
                    this.CellId != null &&
                    this.CellId.Equals(other.CellId)
                ) && 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.ChampionPickIntent == other.ChampionPickIntent ||
                    this.ChampionPickIntent != null &&
                    this.ChampionPickIntent.Equals(other.ChampionPickIntent)
                ) && 
                (
                    this.SkinId == other.SkinId ||
                    this.SkinId != null &&
                    this.SkinId.Equals(other.SkinId)
                ) && 
                (
                    this.Spell1Id == other.Spell1Id ||
                    this.Spell1Id != null &&
                    this.Spell1Id.Equals(other.Spell1Id)
                ) && 
                (
                    this.Spell2Id == other.Spell2Id ||
                    this.Spell2Id != null &&
                    this.Spell2Id.Equals(other.Spell2Id)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.SummonerName == other.SummonerName ||
                    this.SummonerName != null &&
                    this.SummonerName.Equals(other.SummonerName)
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
                if (this.AssignedPosition != null)
                    hash = hash * 59 + this.AssignedPosition.GetHashCode();
                if (this.CellId != null)
                    hash = hash * 59 + this.CellId.GetHashCode();
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.ChampionPickIntent != null)
                    hash = hash * 59 + this.ChampionPickIntent.GetHashCode();
                if (this.SkinId != null)
                    hash = hash * 59 + this.SkinId.GetHashCode();
                if (this.Spell1Id != null)
                    hash = hash * 59 + this.Spell1Id.GetHashCode();
                if (this.Spell2Id != null)
                    hash = hash * 59 + this.Spell2Id.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.SummonerName != null)
                    hash = hash * 59 + this.SummonerName.GetHashCode();
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
