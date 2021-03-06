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
    /// LolLobbyTeamBuilderAfkCheckStateV1
    /// </summary>
    [DataContract]
    public partial class LolLobbyTeamBuilderAfkCheckStateV1 :  IEquatable<LolLobbyTeamBuilderAfkCheckStateV1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLobbyTeamBuilderAfkCheckStateV1" /> class.
        /// </summary>
        /// <param name="AfkReady">AfkReady.</param>
        /// <param name="InventoryDraft">InventoryDraft.</param>
        /// <param name="MaxAfkMillis">MaxAfkMillis.</param>
        /// <param name="RemainingAfkMillis">RemainingAfkMillis.</param>
        public LolLobbyTeamBuilderAfkCheckStateV1(bool? AfkReady = default(bool?), LolLobbyTeamBuilderTbdInventory InventoryDraft = default(LolLobbyTeamBuilderTbdInventory), int? MaxAfkMillis = default(int?), int? RemainingAfkMillis = default(int?))
        {
            this.AfkReady = AfkReady;
            this.InventoryDraft = InventoryDraft;
            this.MaxAfkMillis = MaxAfkMillis;
            this.RemainingAfkMillis = RemainingAfkMillis;
        }
        
        /// <summary>
        /// Gets or Sets AfkReady
        /// </summary>
        [DataMember(Name="afkReady", EmitDefaultValue=false)]
        public bool? AfkReady { get; set; }

        /// <summary>
        /// Gets or Sets InventoryDraft
        /// </summary>
        [DataMember(Name="inventoryDraft", EmitDefaultValue=false)]
        public LolLobbyTeamBuilderTbdInventory InventoryDraft { get; set; }

        /// <summary>
        /// Gets or Sets MaxAfkMillis
        /// </summary>
        [DataMember(Name="maxAfkMillis", EmitDefaultValue=false)]
        public int? MaxAfkMillis { get; set; }

        /// <summary>
        /// Gets or Sets RemainingAfkMillis
        /// </summary>
        [DataMember(Name="remainingAfkMillis", EmitDefaultValue=false)]
        public int? RemainingAfkMillis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLobbyTeamBuilderAfkCheckStateV1 {\n");
            sb.Append("  AfkReady: ").Append(AfkReady).Append("\n");
            sb.Append("  InventoryDraft: ").Append(InventoryDraft).Append("\n");
            sb.Append("  MaxAfkMillis: ").Append(MaxAfkMillis).Append("\n");
            sb.Append("  RemainingAfkMillis: ").Append(RemainingAfkMillis).Append("\n");
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
            return this.Equals(obj as LolLobbyTeamBuilderAfkCheckStateV1);
        }

        /// <summary>
        /// Returns true if LolLobbyTeamBuilderAfkCheckStateV1 instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLobbyTeamBuilderAfkCheckStateV1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLobbyTeamBuilderAfkCheckStateV1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AfkReady == other.AfkReady ||
                    this.AfkReady != null &&
                    this.AfkReady.Equals(other.AfkReady)
                ) && 
                (
                    this.InventoryDraft == other.InventoryDraft ||
                    this.InventoryDraft != null &&
                    this.InventoryDraft.Equals(other.InventoryDraft)
                ) && 
                (
                    this.MaxAfkMillis == other.MaxAfkMillis ||
                    this.MaxAfkMillis != null &&
                    this.MaxAfkMillis.Equals(other.MaxAfkMillis)
                ) && 
                (
                    this.RemainingAfkMillis == other.RemainingAfkMillis ||
                    this.RemainingAfkMillis != null &&
                    this.RemainingAfkMillis.Equals(other.RemainingAfkMillis)
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
                if (this.AfkReady != null)
                    hash = hash * 59 + this.AfkReady.GetHashCode();
                if (this.InventoryDraft != null)
                    hash = hash * 59 + this.InventoryDraft.GetHashCode();
                if (this.MaxAfkMillis != null)
                    hash = hash * 59 + this.MaxAfkMillis.GetHashCode();
                if (this.RemainingAfkMillis != null)
                    hash = hash * 59 + this.RemainingAfkMillis.GetHashCode();
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
