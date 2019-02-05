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
    /// BracketMatch
    /// </summary>
    [DataContract]
    public partial class BracketMatch :  IEquatable<BracketMatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BracketMatch" /> class.
        /// </summary>
        /// <param name="GameId">GameId.</param>
        /// <param name="GameStartTime">GameStartTime.</param>
        /// <param name="Id">Id.</param>
        /// <param name="LoserBracket">LoserBracket.</param>
        /// <param name="Order">Order.</param>
        /// <param name="RosterId1">RosterId1.</param>
        /// <param name="RosterId2">RosterId2.</param>
        /// <param name="Round">Round.</param>
        /// <param name="RoundStartTime">RoundStartTime.</param>
        /// <param name="Status">Status.</param>
        /// <param name="WinnerId">WinnerId.</param>
        public BracketMatch(long? GameId = default(long?), long? GameStartTime = default(long?), long? Id = default(long?), bool? LoserBracket = default(bool?), int? Order = default(int?), long? RosterId1 = default(long?), long? RosterId2 = default(long?), int? Round = default(int?), long? RoundStartTime = default(long?), ClientBracketMatchStatus Status = default(ClientBracketMatchStatus), long? WinnerId = default(long?))
        {
            this.GameId = GameId;
            this.GameStartTime = GameStartTime;
            this.Id = Id;
            this.LoserBracket = LoserBracket;
            this.Order = Order;
            this.RosterId1 = RosterId1;
            this.RosterId2 = RosterId2;
            this.Round = Round;
            this.RoundStartTime = RoundStartTime;
            this.Status = Status;
            this.WinnerId = WinnerId;
        }
        
        /// <summary>
        /// Gets or Sets GameId
        /// </summary>
        [DataMember(Name="gameId", EmitDefaultValue=false)]
        public long? GameId { get; set; }

        /// <summary>
        /// Gets or Sets GameStartTime
        /// </summary>
        [DataMember(Name="gameStartTime", EmitDefaultValue=false)]
        public long? GameStartTime { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets LoserBracket
        /// </summary>
        [DataMember(Name="loserBracket", EmitDefaultValue=false)]
        public bool? LoserBracket { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or Sets RosterId1
        /// </summary>
        [DataMember(Name="rosterId1", EmitDefaultValue=false)]
        public long? RosterId1 { get; set; }

        /// <summary>
        /// Gets or Sets RosterId2
        /// </summary>
        [DataMember(Name="rosterId2", EmitDefaultValue=false)]
        public long? RosterId2 { get; set; }

        /// <summary>
        /// Gets or Sets Round
        /// </summary>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public int? Round { get; set; }

        /// <summary>
        /// Gets or Sets RoundStartTime
        /// </summary>
        [DataMember(Name="roundStartTime", EmitDefaultValue=false)]
        public long? RoundStartTime { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ClientBracketMatchStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets WinnerId
        /// </summary>
        [DataMember(Name="winnerId", EmitDefaultValue=false)]
        public long? WinnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BracketMatch {\n");
            sb.Append("  GameId: ").Append(GameId).Append("\n");
            sb.Append("  GameStartTime: ").Append(GameStartTime).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoserBracket: ").Append(LoserBracket).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  RosterId1: ").Append(RosterId1).Append("\n");
            sb.Append("  RosterId2: ").Append(RosterId2).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  RoundStartTime: ").Append(RoundStartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  WinnerId: ").Append(WinnerId).Append("\n");
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
            return this.Equals(obj as BracketMatch);
        }

        /// <summary>
        /// Returns true if BracketMatch instances are equal
        /// </summary>
        /// <param name="other">Instance of BracketMatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BracketMatch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameId == other.GameId ||
                    this.GameId != null &&
                    this.GameId.Equals(other.GameId)
                ) && 
                (
                    this.GameStartTime == other.GameStartTime ||
                    this.GameStartTime != null &&
                    this.GameStartTime.Equals(other.GameStartTime)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LoserBracket == other.LoserBracket ||
                    this.LoserBracket != null &&
                    this.LoserBracket.Equals(other.LoserBracket)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.RosterId1 == other.RosterId1 ||
                    this.RosterId1 != null &&
                    this.RosterId1.Equals(other.RosterId1)
                ) && 
                (
                    this.RosterId2 == other.RosterId2 ||
                    this.RosterId2 != null &&
                    this.RosterId2.Equals(other.RosterId2)
                ) && 
                (
                    this.Round == other.Round ||
                    this.Round != null &&
                    this.Round.Equals(other.Round)
                ) && 
                (
                    this.RoundStartTime == other.RoundStartTime ||
                    this.RoundStartTime != null &&
                    this.RoundStartTime.Equals(other.RoundStartTime)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.WinnerId == other.WinnerId ||
                    this.WinnerId != null &&
                    this.WinnerId.Equals(other.WinnerId)
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
                if (this.GameId != null)
                    hash = hash * 59 + this.GameId.GetHashCode();
                if (this.GameStartTime != null)
                    hash = hash * 59 + this.GameStartTime.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LoserBracket != null)
                    hash = hash * 59 + this.LoserBracket.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.RosterId1 != null)
                    hash = hash * 59 + this.RosterId1.GetHashCode();
                if (this.RosterId2 != null)
                    hash = hash * 59 + this.RosterId2.GetHashCode();
                if (this.Round != null)
                    hash = hash * 59 + this.Round.GetHashCode();
                if (this.RoundStartTime != null)
                    hash = hash * 59 + this.RoundStartTime.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.WinnerId != null)
                    hash = hash * 59 + this.WinnerId.GetHashCode();
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
