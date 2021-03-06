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
    /// RosterDTO
    /// </summary>
    [DataContract]
    public partial class RosterDTO :  IEquatable<RosterDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RosterDTO" /> class.
        /// </summary>
        /// <param name="CaptainId">CaptainId.</param>
        /// <param name="DynamicState">DynamicState.</param>
        /// <param name="Eliminated">Eliminated.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Logo">Logo.</param>
        /// <param name="LogoColor">LogoColor.</param>
        /// <param name="Losses">Losses.</param>
        /// <param name="Members">Members.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Phases">Phases.</param>
        /// <param name="ShortName">ShortName.</param>
        /// <param name="Tier">Tier.</param>
        /// <param name="TournamentId">TournamentId.</param>
        /// <param name="Wins">Wins.</param>
        public RosterDTO(long? CaptainId = default(long?), RosterDynamicStateDTO DynamicState = default(RosterDynamicStateDTO), bool? Eliminated = default(bool?), long? Id = default(long?), int? Logo = default(int?), int? LogoColor = default(int?), int? Losses = default(int?), List<RosterMemberDTO> Members = default(List<RosterMemberDTO>), string Name = default(string), List<PhaseRosterDTO> Phases = default(List<PhaseRosterDTO>), string ShortName = default(string), int? Tier = default(int?), long? TournamentId = default(long?), int? Wins = default(int?))
        {
            this.CaptainId = CaptainId;
            this.DynamicState = DynamicState;
            this.Eliminated = Eliminated;
            this.Id = Id;
            this.Logo = Logo;
            this.LogoColor = LogoColor;
            this.Losses = Losses;
            this.Members = Members;
            this.Name = Name;
            this.Phases = Phases;
            this.ShortName = ShortName;
            this.Tier = Tier;
            this.TournamentId = TournamentId;
            this.Wins = Wins;
        }
        
        /// <summary>
        /// Gets or Sets CaptainId
        /// </summary>
        [DataMember(Name="captainId", EmitDefaultValue=false)]
        public long? CaptainId { get; set; }

        /// <summary>
        /// Gets or Sets DynamicState
        /// </summary>
        [DataMember(Name="dynamicState", EmitDefaultValue=false)]
        public RosterDynamicStateDTO DynamicState { get; set; }

        /// <summary>
        /// Gets or Sets Eliminated
        /// </summary>
        [DataMember(Name="eliminated", EmitDefaultValue=false)]
        public bool? Eliminated { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public int? Logo { get; set; }

        /// <summary>
        /// Gets or Sets LogoColor
        /// </summary>
        [DataMember(Name="logoColor", EmitDefaultValue=false)]
        public int? LogoColor { get; set; }

        /// <summary>
        /// Gets or Sets Losses
        /// </summary>
        [DataMember(Name="losses", EmitDefaultValue=false)]
        public int? Losses { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<RosterMemberDTO> Members { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Phases
        /// </summary>
        [DataMember(Name="phases", EmitDefaultValue=false)]
        public List<PhaseRosterDTO> Phases { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name="shortName", EmitDefaultValue=false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }

        /// <summary>
        /// Gets or Sets TournamentId
        /// </summary>
        [DataMember(Name="tournamentId", EmitDefaultValue=false)]
        public long? TournamentId { get; set; }

        /// <summary>
        /// Gets or Sets Wins
        /// </summary>
        [DataMember(Name="wins", EmitDefaultValue=false)]
        public int? Wins { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RosterDTO {\n");
            sb.Append("  CaptainId: ").Append(CaptainId).Append("\n");
            sb.Append("  DynamicState: ").Append(DynamicState).Append("\n");
            sb.Append("  Eliminated: ").Append(Eliminated).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  LogoColor: ").Append(LogoColor).Append("\n");
            sb.Append("  Losses: ").Append(Losses).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phases: ").Append(Phases).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  TournamentId: ").Append(TournamentId).Append("\n");
            sb.Append("  Wins: ").Append(Wins).Append("\n");
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
            return this.Equals(obj as RosterDTO);
        }

        /// <summary>
        /// Returns true if RosterDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of RosterDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RosterDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CaptainId == other.CaptainId ||
                    this.CaptainId != null &&
                    this.CaptainId.Equals(other.CaptainId)
                ) && 
                (
                    this.DynamicState == other.DynamicState ||
                    this.DynamicState != null &&
                    this.DynamicState.Equals(other.DynamicState)
                ) && 
                (
                    this.Eliminated == other.Eliminated ||
                    this.Eliminated != null &&
                    this.Eliminated.Equals(other.Eliminated)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Logo == other.Logo ||
                    this.Logo != null &&
                    this.Logo.Equals(other.Logo)
                ) && 
                (
                    this.LogoColor == other.LogoColor ||
                    this.LogoColor != null &&
                    this.LogoColor.Equals(other.LogoColor)
                ) && 
                (
                    this.Losses == other.Losses ||
                    this.Losses != null &&
                    this.Losses.Equals(other.Losses)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.SequenceEqual(other.Members)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Phases == other.Phases ||
                    this.Phases != null &&
                    this.Phases.SequenceEqual(other.Phases)
                ) && 
                (
                    this.ShortName == other.ShortName ||
                    this.ShortName != null &&
                    this.ShortName.Equals(other.ShortName)
                ) && 
                (
                    this.Tier == other.Tier ||
                    this.Tier != null &&
                    this.Tier.Equals(other.Tier)
                ) && 
                (
                    this.TournamentId == other.TournamentId ||
                    this.TournamentId != null &&
                    this.TournamentId.Equals(other.TournamentId)
                ) && 
                (
                    this.Wins == other.Wins ||
                    this.Wins != null &&
                    this.Wins.Equals(other.Wins)
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
                if (this.CaptainId != null)
                    hash = hash * 59 + this.CaptainId.GetHashCode();
                if (this.DynamicState != null)
                    hash = hash * 59 + this.DynamicState.GetHashCode();
                if (this.Eliminated != null)
                    hash = hash * 59 + this.Eliminated.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Logo != null)
                    hash = hash * 59 + this.Logo.GetHashCode();
                if (this.LogoColor != null)
                    hash = hash * 59 + this.LogoColor.GetHashCode();
                if (this.Losses != null)
                    hash = hash * 59 + this.Losses.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Phases != null)
                    hash = hash * 59 + this.Phases.GetHashCode();
                if (this.ShortName != null)
                    hash = hash * 59 + this.ShortName.GetHashCode();
                if (this.Tier != null)
                    hash = hash * 59 + this.Tier.GetHashCode();
                if (this.TournamentId != null)
                    hash = hash * 59 + this.TournamentId.GetHashCode();
                if (this.Wins != null)
                    hash = hash * 59 + this.Wins.GetHashCode();
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
