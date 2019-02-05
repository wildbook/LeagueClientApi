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
    /// LolMatchHistoryMatchHistoryGameList
    /// </summary>
    [DataContract]
    public partial class LolMatchHistoryMatchHistoryGameList :  IEquatable<LolMatchHistoryMatchHistoryGameList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolMatchHistoryMatchHistoryGameList" /> class.
        /// </summary>
        /// <param name="GameBeginDate">GameBeginDate.</param>
        /// <param name="GameCount">GameCount.</param>
        /// <param name="GameEndDate">GameEndDate.</param>
        /// <param name="GameIndexBegin">GameIndexBegin.</param>
        /// <param name="GameIndexEnd">GameIndexEnd.</param>
        /// <param name="Games">Games.</param>
        public LolMatchHistoryMatchHistoryGameList(string GameBeginDate = default(string), long? GameCount = default(long?), string GameEndDate = default(string), long? GameIndexBegin = default(long?), long? GameIndexEnd = default(long?), List<LolMatchHistoryMatchHistoryGame> Games = default(List<LolMatchHistoryMatchHistoryGame>))
        {
            this.GameBeginDate = GameBeginDate;
            this.GameCount = GameCount;
            this.GameEndDate = GameEndDate;
            this.GameIndexBegin = GameIndexBegin;
            this.GameIndexEnd = GameIndexEnd;
            this.Games = Games;
        }
        
        /// <summary>
        /// Gets or Sets GameBeginDate
        /// </summary>
        [DataMember(Name="gameBeginDate", EmitDefaultValue=false)]
        public string GameBeginDate { get; set; }

        /// <summary>
        /// Gets or Sets GameCount
        /// </summary>
        [DataMember(Name="gameCount", EmitDefaultValue=false)]
        public long? GameCount { get; set; }

        /// <summary>
        /// Gets or Sets GameEndDate
        /// </summary>
        [DataMember(Name="gameEndDate", EmitDefaultValue=false)]
        public string GameEndDate { get; set; }

        /// <summary>
        /// Gets or Sets GameIndexBegin
        /// </summary>
        [DataMember(Name="gameIndexBegin", EmitDefaultValue=false)]
        public long? GameIndexBegin { get; set; }

        /// <summary>
        /// Gets or Sets GameIndexEnd
        /// </summary>
        [DataMember(Name="gameIndexEnd", EmitDefaultValue=false)]
        public long? GameIndexEnd { get; set; }

        /// <summary>
        /// Gets or Sets Games
        /// </summary>
        [DataMember(Name="games", EmitDefaultValue=false)]
        public List<LolMatchHistoryMatchHistoryGame> Games { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolMatchHistoryMatchHistoryGameList {\n");
            sb.Append("  GameBeginDate: ").Append(GameBeginDate).Append("\n");
            sb.Append("  GameCount: ").Append(GameCount).Append("\n");
            sb.Append("  GameEndDate: ").Append(GameEndDate).Append("\n");
            sb.Append("  GameIndexBegin: ").Append(GameIndexBegin).Append("\n");
            sb.Append("  GameIndexEnd: ").Append(GameIndexEnd).Append("\n");
            sb.Append("  Games: ").Append(Games).Append("\n");
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
            return this.Equals(obj as LolMatchHistoryMatchHistoryGameList);
        }

        /// <summary>
        /// Returns true if LolMatchHistoryMatchHistoryGameList instances are equal
        /// </summary>
        /// <param name="other">Instance of LolMatchHistoryMatchHistoryGameList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolMatchHistoryMatchHistoryGameList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GameBeginDate == other.GameBeginDate ||
                    this.GameBeginDate != null &&
                    this.GameBeginDate.Equals(other.GameBeginDate)
                ) && 
                (
                    this.GameCount == other.GameCount ||
                    this.GameCount != null &&
                    this.GameCount.Equals(other.GameCount)
                ) && 
                (
                    this.GameEndDate == other.GameEndDate ||
                    this.GameEndDate != null &&
                    this.GameEndDate.Equals(other.GameEndDate)
                ) && 
                (
                    this.GameIndexBegin == other.GameIndexBegin ||
                    this.GameIndexBegin != null &&
                    this.GameIndexBegin.Equals(other.GameIndexBegin)
                ) && 
                (
                    this.GameIndexEnd == other.GameIndexEnd ||
                    this.GameIndexEnd != null &&
                    this.GameIndexEnd.Equals(other.GameIndexEnd)
                ) && 
                (
                    this.Games == other.Games ||
                    this.Games != null &&
                    this.Games.SequenceEqual(other.Games)
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
                if (this.GameBeginDate != null)
                    hash = hash * 59 + this.GameBeginDate.GetHashCode();
                if (this.GameCount != null)
                    hash = hash * 59 + this.GameCount.GetHashCode();
                if (this.GameEndDate != null)
                    hash = hash * 59 + this.GameEndDate.GetHashCode();
                if (this.GameIndexBegin != null)
                    hash = hash * 59 + this.GameIndexBegin.GetHashCode();
                if (this.GameIndexEnd != null)
                    hash = hash * 59 + this.GameIndexEnd.GetHashCode();
                if (this.Games != null)
                    hash = hash * 59 + this.Games.GetHashCode();
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