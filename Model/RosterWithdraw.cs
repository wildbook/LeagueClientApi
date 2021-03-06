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
    /// RosterWithdraw
    /// </summary>
    [DataContract]
    public partial class RosterWithdraw :  IEquatable<RosterWithdraw>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RosterWithdraw" /> class.
        /// </summary>
        /// <param name="DeclineWithdrawMembers">DeclineWithdrawMembers.</param>
        /// <param name="GameStartBufferMs">GameStartBufferMs.</param>
        /// <param name="InitVoteMember">InitVoteMember.</param>
        /// <param name="InitVoteTime">InitVoteTime.</param>
        /// <param name="LockoutTimeMs">LockoutTimeMs.</param>
        /// <param name="VoteTimeoutMs">VoteTimeoutMs.</param>
        /// <param name="VoteWithdrawMembers">VoteWithdrawMembers.</param>
        public RosterWithdraw(List<long?> DeclineWithdrawMembers = default(List<long?>), long? GameStartBufferMs = default(long?), long? InitVoteMember = default(long?), long? InitVoteTime = default(long?), long? LockoutTimeMs = default(long?), long? VoteTimeoutMs = default(long?), List<long?> VoteWithdrawMembers = default(List<long?>))
        {
            this.DeclineWithdrawMembers = DeclineWithdrawMembers;
            this.GameStartBufferMs = GameStartBufferMs;
            this.InitVoteMember = InitVoteMember;
            this.InitVoteTime = InitVoteTime;
            this.LockoutTimeMs = LockoutTimeMs;
            this.VoteTimeoutMs = VoteTimeoutMs;
            this.VoteWithdrawMembers = VoteWithdrawMembers;
        }
        
        /// <summary>
        /// Gets or Sets DeclineWithdrawMembers
        /// </summary>
        [DataMember(Name="declineWithdrawMembers", EmitDefaultValue=false)]
        public List<long?> DeclineWithdrawMembers { get; set; }

        /// <summary>
        /// Gets or Sets GameStartBufferMs
        /// </summary>
        [DataMember(Name="gameStartBufferMs", EmitDefaultValue=false)]
        public long? GameStartBufferMs { get; set; }

        /// <summary>
        /// Gets or Sets InitVoteMember
        /// </summary>
        [DataMember(Name="initVoteMember", EmitDefaultValue=false)]
        public long? InitVoteMember { get; set; }

        /// <summary>
        /// Gets or Sets InitVoteTime
        /// </summary>
        [DataMember(Name="initVoteTime", EmitDefaultValue=false)]
        public long? InitVoteTime { get; set; }

        /// <summary>
        /// Gets or Sets LockoutTimeMs
        /// </summary>
        [DataMember(Name="lockoutTimeMs", EmitDefaultValue=false)]
        public long? LockoutTimeMs { get; set; }

        /// <summary>
        /// Gets or Sets VoteTimeoutMs
        /// </summary>
        [DataMember(Name="voteTimeoutMs", EmitDefaultValue=false)]
        public long? VoteTimeoutMs { get; set; }

        /// <summary>
        /// Gets or Sets VoteWithdrawMembers
        /// </summary>
        [DataMember(Name="voteWithdrawMembers", EmitDefaultValue=false)]
        public List<long?> VoteWithdrawMembers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RosterWithdraw {\n");
            sb.Append("  DeclineWithdrawMembers: ").Append(DeclineWithdrawMembers).Append("\n");
            sb.Append("  GameStartBufferMs: ").Append(GameStartBufferMs).Append("\n");
            sb.Append("  InitVoteMember: ").Append(InitVoteMember).Append("\n");
            sb.Append("  InitVoteTime: ").Append(InitVoteTime).Append("\n");
            sb.Append("  LockoutTimeMs: ").Append(LockoutTimeMs).Append("\n");
            sb.Append("  VoteTimeoutMs: ").Append(VoteTimeoutMs).Append("\n");
            sb.Append("  VoteWithdrawMembers: ").Append(VoteWithdrawMembers).Append("\n");
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
            return this.Equals(obj as RosterWithdraw);
        }

        /// <summary>
        /// Returns true if RosterWithdraw instances are equal
        /// </summary>
        /// <param name="other">Instance of RosterWithdraw to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RosterWithdraw other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeclineWithdrawMembers == other.DeclineWithdrawMembers ||
                    this.DeclineWithdrawMembers != null &&
                    this.DeclineWithdrawMembers.SequenceEqual(other.DeclineWithdrawMembers)
                ) && 
                (
                    this.GameStartBufferMs == other.GameStartBufferMs ||
                    this.GameStartBufferMs != null &&
                    this.GameStartBufferMs.Equals(other.GameStartBufferMs)
                ) && 
                (
                    this.InitVoteMember == other.InitVoteMember ||
                    this.InitVoteMember != null &&
                    this.InitVoteMember.Equals(other.InitVoteMember)
                ) && 
                (
                    this.InitVoteTime == other.InitVoteTime ||
                    this.InitVoteTime != null &&
                    this.InitVoteTime.Equals(other.InitVoteTime)
                ) && 
                (
                    this.LockoutTimeMs == other.LockoutTimeMs ||
                    this.LockoutTimeMs != null &&
                    this.LockoutTimeMs.Equals(other.LockoutTimeMs)
                ) && 
                (
                    this.VoteTimeoutMs == other.VoteTimeoutMs ||
                    this.VoteTimeoutMs != null &&
                    this.VoteTimeoutMs.Equals(other.VoteTimeoutMs)
                ) && 
                (
                    this.VoteWithdrawMembers == other.VoteWithdrawMembers ||
                    this.VoteWithdrawMembers != null &&
                    this.VoteWithdrawMembers.SequenceEqual(other.VoteWithdrawMembers)
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
                if (this.DeclineWithdrawMembers != null)
                    hash = hash * 59 + this.DeclineWithdrawMembers.GetHashCode();
                if (this.GameStartBufferMs != null)
                    hash = hash * 59 + this.GameStartBufferMs.GetHashCode();
                if (this.InitVoteMember != null)
                    hash = hash * 59 + this.InitVoteMember.GetHashCode();
                if (this.InitVoteTime != null)
                    hash = hash * 59 + this.InitVoteTime.GetHashCode();
                if (this.LockoutTimeMs != null)
                    hash = hash * 59 + this.LockoutTimeMs.GetHashCode();
                if (this.VoteTimeoutMs != null)
                    hash = hash * 59 + this.VoteTimeoutMs.GetHashCode();
                if (this.VoteWithdrawMembers != null)
                    hash = hash * 59 + this.VoteWithdrawMembers.GetHashCode();
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
