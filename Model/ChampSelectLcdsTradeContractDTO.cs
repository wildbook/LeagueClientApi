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
    /// ChampSelectLcdsTradeContractDTO
    /// </summary>
    [DataContract]
    public partial class ChampSelectLcdsTradeContractDTO :  IEquatable<ChampSelectLcdsTradeContractDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChampSelectLcdsTradeContractDTO" /> class.
        /// </summary>
        /// <param name="RequesterChampionId">RequesterChampionId.</param>
        /// <param name="RequesterInternalSummonerName">RequesterInternalSummonerName.</param>
        /// <param name="ResponderChampionId">ResponderChampionId.</param>
        /// <param name="ResponderInternalSummonerName">ResponderInternalSummonerName.</param>
        /// <param name="State">State.</param>
        public ChampSelectLcdsTradeContractDTO(int? RequesterChampionId = default(int?), string RequesterInternalSummonerName = default(string), int? ResponderChampionId = default(int?), string ResponderInternalSummonerName = default(string), string State = default(string))
        {
            this.RequesterChampionId = RequesterChampionId;
            this.RequesterInternalSummonerName = RequesterInternalSummonerName;
            this.ResponderChampionId = ResponderChampionId;
            this.ResponderInternalSummonerName = ResponderInternalSummonerName;
            this.State = State;
        }
        
        /// <summary>
        /// Gets or Sets RequesterChampionId
        /// </summary>
        [DataMember(Name="requesterChampionId", EmitDefaultValue=false)]
        public int? RequesterChampionId { get; set; }

        /// <summary>
        /// Gets or Sets RequesterInternalSummonerName
        /// </summary>
        [DataMember(Name="requesterInternalSummonerName", EmitDefaultValue=false)]
        public string RequesterInternalSummonerName { get; set; }

        /// <summary>
        /// Gets or Sets ResponderChampionId
        /// </summary>
        [DataMember(Name="responderChampionId", EmitDefaultValue=false)]
        public int? ResponderChampionId { get; set; }

        /// <summary>
        /// Gets or Sets ResponderInternalSummonerName
        /// </summary>
        [DataMember(Name="responderInternalSummonerName", EmitDefaultValue=false)]
        public string ResponderInternalSummonerName { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChampSelectLcdsTradeContractDTO {\n");
            sb.Append("  RequesterChampionId: ").Append(RequesterChampionId).Append("\n");
            sb.Append("  RequesterInternalSummonerName: ").Append(RequesterInternalSummonerName).Append("\n");
            sb.Append("  ResponderChampionId: ").Append(ResponderChampionId).Append("\n");
            sb.Append("  ResponderInternalSummonerName: ").Append(ResponderInternalSummonerName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as ChampSelectLcdsTradeContractDTO);
        }

        /// <summary>
        /// Returns true if ChampSelectLcdsTradeContractDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ChampSelectLcdsTradeContractDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChampSelectLcdsTradeContractDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RequesterChampionId == other.RequesterChampionId ||
                    this.RequesterChampionId != null &&
                    this.RequesterChampionId.Equals(other.RequesterChampionId)
                ) && 
                (
                    this.RequesterInternalSummonerName == other.RequesterInternalSummonerName ||
                    this.RequesterInternalSummonerName != null &&
                    this.RequesterInternalSummonerName.Equals(other.RequesterInternalSummonerName)
                ) && 
                (
                    this.ResponderChampionId == other.ResponderChampionId ||
                    this.ResponderChampionId != null &&
                    this.ResponderChampionId.Equals(other.ResponderChampionId)
                ) && 
                (
                    this.ResponderInternalSummonerName == other.ResponderInternalSummonerName ||
                    this.ResponderInternalSummonerName != null &&
                    this.ResponderInternalSummonerName.Equals(other.ResponderInternalSummonerName)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.RequesterChampionId != null)
                    hash = hash * 59 + this.RequesterChampionId.GetHashCode();
                if (this.RequesterInternalSummonerName != null)
                    hash = hash * 59 + this.RequesterInternalSummonerName.GetHashCode();
                if (this.ResponderChampionId != null)
                    hash = hash * 59 + this.ResponderChampionId.GetHashCode();
                if (this.ResponderInternalSummonerName != null)
                    hash = hash * 59 + this.ResponderInternalSummonerName.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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