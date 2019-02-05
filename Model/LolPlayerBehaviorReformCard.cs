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
    /// LolPlayerBehaviorReformCard
    /// </summary>
    [DataContract]
    public partial class LolPlayerBehaviorReformCard :  IEquatable<LolPlayerBehaviorReformCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolPlayerBehaviorReformCard" /> class.
        /// </summary>
        /// <param name="ChatLogs">ChatLogs.</param>
        /// <param name="GameIds">GameIds.</param>
        /// <param name="Id">Id.</param>
        /// <param name="PlayerFacingMessage">PlayerFacingMessage.</param>
        /// <param name="PunishmentLengthGames">PunishmentLengthGames.</param>
        /// <param name="PunishmentLengthTime">PunishmentLengthTime.</param>
        /// <param name="PunishmentType">PunishmentType.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="RestrictedChatGamesRemaining">RestrictedChatGamesRemaining.</param>
        /// <param name="TimeWhenPunishmentExpires">TimeWhenPunishmentExpires.</param>
        public LolPlayerBehaviorReformCard(List<string> ChatLogs = default(List<string>), List<long?> GameIds = default(List<long?>), long? Id = default(long?), string PlayerFacingMessage = default(string), long? PunishmentLengthGames = default(long?), long? PunishmentLengthTime = default(long?), string PunishmentType = default(string), string Reason = default(string), long? RestrictedChatGamesRemaining = default(long?), long? TimeWhenPunishmentExpires = default(long?))
        {
            this.ChatLogs = ChatLogs;
            this.GameIds = GameIds;
            this.Id = Id;
            this.PlayerFacingMessage = PlayerFacingMessage;
            this.PunishmentLengthGames = PunishmentLengthGames;
            this.PunishmentLengthTime = PunishmentLengthTime;
            this.PunishmentType = PunishmentType;
            this.Reason = Reason;
            this.RestrictedChatGamesRemaining = RestrictedChatGamesRemaining;
            this.TimeWhenPunishmentExpires = TimeWhenPunishmentExpires;
        }
        
        /// <summary>
        /// Gets or Sets ChatLogs
        /// </summary>
        [DataMember(Name="chatLogs", EmitDefaultValue=false)]
        public List<string> ChatLogs { get; set; }

        /// <summary>
        /// Gets or Sets GameIds
        /// </summary>
        [DataMember(Name="gameIds", EmitDefaultValue=false)]
        public List<long?> GameIds { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets PlayerFacingMessage
        /// </summary>
        [DataMember(Name="playerFacingMessage", EmitDefaultValue=false)]
        public string PlayerFacingMessage { get; set; }

        /// <summary>
        /// Gets or Sets PunishmentLengthGames
        /// </summary>
        [DataMember(Name="punishmentLengthGames", EmitDefaultValue=false)]
        public long? PunishmentLengthGames { get; set; }

        /// <summary>
        /// Gets or Sets PunishmentLengthTime
        /// </summary>
        [DataMember(Name="punishmentLengthTime", EmitDefaultValue=false)]
        public long? PunishmentLengthTime { get; set; }

        /// <summary>
        /// Gets or Sets PunishmentType
        /// </summary>
        [DataMember(Name="punishmentType", EmitDefaultValue=false)]
        public string PunishmentType { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets RestrictedChatGamesRemaining
        /// </summary>
        [DataMember(Name="restrictedChatGamesRemaining", EmitDefaultValue=false)]
        public long? RestrictedChatGamesRemaining { get; set; }

        /// <summary>
        /// Gets or Sets TimeWhenPunishmentExpires
        /// </summary>
        [DataMember(Name="timeWhenPunishmentExpires", EmitDefaultValue=false)]
        public long? TimeWhenPunishmentExpires { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolPlayerBehaviorReformCard {\n");
            sb.Append("  ChatLogs: ").Append(ChatLogs).Append("\n");
            sb.Append("  GameIds: ").Append(GameIds).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlayerFacingMessage: ").Append(PlayerFacingMessage).Append("\n");
            sb.Append("  PunishmentLengthGames: ").Append(PunishmentLengthGames).Append("\n");
            sb.Append("  PunishmentLengthTime: ").Append(PunishmentLengthTime).Append("\n");
            sb.Append("  PunishmentType: ").Append(PunishmentType).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  RestrictedChatGamesRemaining: ").Append(RestrictedChatGamesRemaining).Append("\n");
            sb.Append("  TimeWhenPunishmentExpires: ").Append(TimeWhenPunishmentExpires).Append("\n");
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
            return this.Equals(obj as LolPlayerBehaviorReformCard);
        }

        /// <summary>
        /// Returns true if LolPlayerBehaviorReformCard instances are equal
        /// </summary>
        /// <param name="other">Instance of LolPlayerBehaviorReformCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolPlayerBehaviorReformCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChatLogs == other.ChatLogs ||
                    this.ChatLogs != null &&
                    this.ChatLogs.SequenceEqual(other.ChatLogs)
                ) && 
                (
                    this.GameIds == other.GameIds ||
                    this.GameIds != null &&
                    this.GameIds.SequenceEqual(other.GameIds)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PlayerFacingMessage == other.PlayerFacingMessage ||
                    this.PlayerFacingMessage != null &&
                    this.PlayerFacingMessage.Equals(other.PlayerFacingMessage)
                ) && 
                (
                    this.PunishmentLengthGames == other.PunishmentLengthGames ||
                    this.PunishmentLengthGames != null &&
                    this.PunishmentLengthGames.Equals(other.PunishmentLengthGames)
                ) && 
                (
                    this.PunishmentLengthTime == other.PunishmentLengthTime ||
                    this.PunishmentLengthTime != null &&
                    this.PunishmentLengthTime.Equals(other.PunishmentLengthTime)
                ) && 
                (
                    this.PunishmentType == other.PunishmentType ||
                    this.PunishmentType != null &&
                    this.PunishmentType.Equals(other.PunishmentType)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.RestrictedChatGamesRemaining == other.RestrictedChatGamesRemaining ||
                    this.RestrictedChatGamesRemaining != null &&
                    this.RestrictedChatGamesRemaining.Equals(other.RestrictedChatGamesRemaining)
                ) && 
                (
                    this.TimeWhenPunishmentExpires == other.TimeWhenPunishmentExpires ||
                    this.TimeWhenPunishmentExpires != null &&
                    this.TimeWhenPunishmentExpires.Equals(other.TimeWhenPunishmentExpires)
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
                if (this.ChatLogs != null)
                    hash = hash * 59 + this.ChatLogs.GetHashCode();
                if (this.GameIds != null)
                    hash = hash * 59 + this.GameIds.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PlayerFacingMessage != null)
                    hash = hash * 59 + this.PlayerFacingMessage.GetHashCode();
                if (this.PunishmentLengthGames != null)
                    hash = hash * 59 + this.PunishmentLengthGames.GetHashCode();
                if (this.PunishmentLengthTime != null)
                    hash = hash * 59 + this.PunishmentLengthTime.GetHashCode();
                if (this.PunishmentType != null)
                    hash = hash * 59 + this.PunishmentType.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.RestrictedChatGamesRemaining != null)
                    hash = hash * 59 + this.RestrictedChatGamesRemaining.GetHashCode();
                if (this.TimeWhenPunishmentExpires != null)
                    hash = hash * 59 + this.TimeWhenPunishmentExpires.GetHashCode();
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