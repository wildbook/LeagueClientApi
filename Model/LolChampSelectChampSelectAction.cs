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
    /// LolChampSelectChampSelectAction
    /// </summary>
    [DataContract]
    public partial class LolChampSelectChampSelectAction :  IEquatable<LolChampSelectChampSelectAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolChampSelectChampSelectAction" /> class.
        /// </summary>
        /// <param name="ActorCellId">ActorCellId.</param>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        public LolChampSelectChampSelectAction(long? ActorCellId = default(long?), int? ChampionId = default(int?), bool? Completed = default(bool?), long? Id = default(long?), string Type = default(string))
        {
            this.ActorCellId = ActorCellId;
            this.ChampionId = ChampionId;
            this.Completed = Completed;
            this.Id = Id;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets ActorCellId
        /// </summary>
        [DataMember(Name="actorCellId", EmitDefaultValue=false)]
        public long? ActorCellId { get; set; }

        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public bool? Completed { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolChampSelectChampSelectAction {\n");
            sb.Append("  ActorCellId: ").Append(ActorCellId).Append("\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as LolChampSelectChampSelectAction);
        }

        /// <summary>
        /// Returns true if LolChampSelectChampSelectAction instances are equal
        /// </summary>
        /// <param name="other">Instance of LolChampSelectChampSelectAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolChampSelectChampSelectAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActorCellId == other.ActorCellId ||
                    this.ActorCellId != null &&
                    this.ActorCellId.Equals(other.ActorCellId)
                ) && 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.ActorCellId != null)
                    hash = hash * 59 + this.ActorCellId.GetHashCode();
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
