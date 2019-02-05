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
    /// LolMatchmakingMatchmakingSearchResource
    /// </summary>
    [DataContract]
    public partial class LolMatchmakingMatchmakingSearchResource :  IEquatable<LolMatchmakingMatchmakingSearchResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolMatchmakingMatchmakingSearchResource" /> class.
        /// </summary>
        /// <param name="DodgeData">DodgeData.</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="EstimatedQueueTime">EstimatedQueueTime.</param>
        /// <param name="IsCurrentlyInQueue">IsCurrentlyInQueue.</param>
        /// <param name="LobbyId">LobbyId.</param>
        /// <param name="LowPriorityData">LowPriorityData.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="ReadyCheck">ReadyCheck.</param>
        /// <param name="SearchState">SearchState.</param>
        /// <param name="TimeInQueue">TimeInQueue.</param>
        public LolMatchmakingMatchmakingSearchResource(LolMatchmakingMatchmakingDodgeData DodgeData = default(LolMatchmakingMatchmakingDodgeData), List<LolMatchmakingMatchmakingSearchErrorResource> Errors = default(List<LolMatchmakingMatchmakingSearchErrorResource>), float? EstimatedQueueTime = default(float?), bool? IsCurrentlyInQueue = default(bool?), string LobbyId = default(string), LolMatchmakingMatchmakingLowPriorityData LowPriorityData = default(LolMatchmakingMatchmakingLowPriorityData), int? QueueId = default(int?), LolMatchmakingMatchmakingReadyCheckResource ReadyCheck = default(LolMatchmakingMatchmakingReadyCheckResource), LolMatchmakingMatchmakingSearchState SearchState = default(LolMatchmakingMatchmakingSearchState), float? TimeInQueue = default(float?))
        {
            this.DodgeData = DodgeData;
            this.Errors = Errors;
            this.EstimatedQueueTime = EstimatedQueueTime;
            this.IsCurrentlyInQueue = IsCurrentlyInQueue;
            this.LobbyId = LobbyId;
            this.LowPriorityData = LowPriorityData;
            this.QueueId = QueueId;
            this.ReadyCheck = ReadyCheck;
            this.SearchState = SearchState;
            this.TimeInQueue = TimeInQueue;
        }
        
        /// <summary>
        /// Gets or Sets DodgeData
        /// </summary>
        [DataMember(Name="dodgeData", EmitDefaultValue=false)]
        public LolMatchmakingMatchmakingDodgeData DodgeData { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<LolMatchmakingMatchmakingSearchErrorResource> Errors { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedQueueTime
        /// </summary>
        [DataMember(Name="estimatedQueueTime", EmitDefaultValue=false)]
        public float? EstimatedQueueTime { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrentlyInQueue
        /// </summary>
        [DataMember(Name="isCurrentlyInQueue", EmitDefaultValue=false)]
        public bool? IsCurrentlyInQueue { get; set; }

        /// <summary>
        /// Gets or Sets LobbyId
        /// </summary>
        [DataMember(Name="lobbyId", EmitDefaultValue=false)]
        public string LobbyId { get; set; }

        /// <summary>
        /// Gets or Sets LowPriorityData
        /// </summary>
        [DataMember(Name="lowPriorityData", EmitDefaultValue=false)]
        public LolMatchmakingMatchmakingLowPriorityData LowPriorityData { get; set; }

        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public int? QueueId { get; set; }

        /// <summary>
        /// Gets or Sets ReadyCheck
        /// </summary>
        [DataMember(Name="readyCheck", EmitDefaultValue=false)]
        public LolMatchmakingMatchmakingReadyCheckResource ReadyCheck { get; set; }

        /// <summary>
        /// Gets or Sets SearchState
        /// </summary>
        [DataMember(Name="searchState", EmitDefaultValue=false)]
        public LolMatchmakingMatchmakingSearchState SearchState { get; set; }

        /// <summary>
        /// Gets or Sets TimeInQueue
        /// </summary>
        [DataMember(Name="timeInQueue", EmitDefaultValue=false)]
        public float? TimeInQueue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolMatchmakingMatchmakingSearchResource {\n");
            sb.Append("  DodgeData: ").Append(DodgeData).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  EstimatedQueueTime: ").Append(EstimatedQueueTime).Append("\n");
            sb.Append("  IsCurrentlyInQueue: ").Append(IsCurrentlyInQueue).Append("\n");
            sb.Append("  LobbyId: ").Append(LobbyId).Append("\n");
            sb.Append("  LowPriorityData: ").Append(LowPriorityData).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  ReadyCheck: ").Append(ReadyCheck).Append("\n");
            sb.Append("  SearchState: ").Append(SearchState).Append("\n");
            sb.Append("  TimeInQueue: ").Append(TimeInQueue).Append("\n");
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
            return this.Equals(obj as LolMatchmakingMatchmakingSearchResource);
        }

        /// <summary>
        /// Returns true if LolMatchmakingMatchmakingSearchResource instances are equal
        /// </summary>
        /// <param name="other">Instance of LolMatchmakingMatchmakingSearchResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolMatchmakingMatchmakingSearchResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DodgeData == other.DodgeData ||
                    this.DodgeData != null &&
                    this.DodgeData.Equals(other.DodgeData)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.EstimatedQueueTime == other.EstimatedQueueTime ||
                    this.EstimatedQueueTime != null &&
                    this.EstimatedQueueTime.Equals(other.EstimatedQueueTime)
                ) && 
                (
                    this.IsCurrentlyInQueue == other.IsCurrentlyInQueue ||
                    this.IsCurrentlyInQueue != null &&
                    this.IsCurrentlyInQueue.Equals(other.IsCurrentlyInQueue)
                ) && 
                (
                    this.LobbyId == other.LobbyId ||
                    this.LobbyId != null &&
                    this.LobbyId.Equals(other.LobbyId)
                ) && 
                (
                    this.LowPriorityData == other.LowPriorityData ||
                    this.LowPriorityData != null &&
                    this.LowPriorityData.Equals(other.LowPriorityData)
                ) && 
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) && 
                (
                    this.ReadyCheck == other.ReadyCheck ||
                    this.ReadyCheck != null &&
                    this.ReadyCheck.Equals(other.ReadyCheck)
                ) && 
                (
                    this.SearchState == other.SearchState ||
                    this.SearchState != null &&
                    this.SearchState.Equals(other.SearchState)
                ) && 
                (
                    this.TimeInQueue == other.TimeInQueue ||
                    this.TimeInQueue != null &&
                    this.TimeInQueue.Equals(other.TimeInQueue)
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
                if (this.DodgeData != null)
                    hash = hash * 59 + this.DodgeData.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.EstimatedQueueTime != null)
                    hash = hash * 59 + this.EstimatedQueueTime.GetHashCode();
                if (this.IsCurrentlyInQueue != null)
                    hash = hash * 59 + this.IsCurrentlyInQueue.GetHashCode();
                if (this.LobbyId != null)
                    hash = hash * 59 + this.LobbyId.GetHashCode();
                if (this.LowPriorityData != null)
                    hash = hash * 59 + this.LowPriorityData.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                if (this.ReadyCheck != null)
                    hash = hash * 59 + this.ReadyCheck.GetHashCode();
                if (this.SearchState != null)
                    hash = hash * 59 + this.SearchState.GetHashCode();
                if (this.TimeInQueue != null)
                    hash = hash * 59 + this.TimeInQueue.GetHashCode();
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