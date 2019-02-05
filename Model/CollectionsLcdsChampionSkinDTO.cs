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
    /// CollectionsLcdsChampionSkinDTO
    /// </summary>
    [DataContract]
    public partial class CollectionsLcdsChampionSkinDTO :  IEquatable<CollectionsLcdsChampionSkinDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsLcdsChampionSkinDTO" /> class.
        /// </summary>
        /// <param name="ChampionId">ChampionId.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="FreeToPlayReward">FreeToPlayReward.</param>
        /// <param name="LastSelected">LastSelected.</param>
        /// <param name="Owned">Owned.</param>
        /// <param name="PurchaseDate">PurchaseDate.</param>
        /// <param name="SkinId">SkinId.</param>
        /// <param name="Sources">Sources.</param>
        /// <param name="StillObtainable">StillObtainable.</param>
        /// <param name="WinCountRemaining">WinCountRemaining.</param>
        public CollectionsLcdsChampionSkinDTO(int? ChampionId = default(int?), long? EndDate = default(long?), bool? FreeToPlayReward = default(bool?), bool? LastSelected = default(bool?), bool? Owned = default(bool?), long? PurchaseDate = default(long?), int? SkinId = default(int?), List<string> Sources = default(List<string>), bool? StillObtainable = default(bool?), int? WinCountRemaining = default(int?))
        {
            this.ChampionId = ChampionId;
            this.EndDate = EndDate;
            this.FreeToPlayReward = FreeToPlayReward;
            this.LastSelected = LastSelected;
            this.Owned = Owned;
            this.PurchaseDate = PurchaseDate;
            this.SkinId = SkinId;
            this.Sources = Sources;
            this.StillObtainable = StillObtainable;
            this.WinCountRemaining = WinCountRemaining;
        }
        
        /// <summary>
        /// Gets or Sets ChampionId
        /// </summary>
        [DataMember(Name="championId", EmitDefaultValue=false)]
        public int? ChampionId { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets FreeToPlayReward
        /// </summary>
        [DataMember(Name="freeToPlayReward", EmitDefaultValue=false)]
        public bool? FreeToPlayReward { get; set; }

        /// <summary>
        /// Gets or Sets LastSelected
        /// </summary>
        [DataMember(Name="lastSelected", EmitDefaultValue=false)]
        public bool? LastSelected { get; set; }

        /// <summary>
        /// Gets or Sets Owned
        /// </summary>
        [DataMember(Name="owned", EmitDefaultValue=false)]
        public bool? Owned { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseDate
        /// </summary>
        [DataMember(Name="purchaseDate", EmitDefaultValue=false)]
        public long? PurchaseDate { get; set; }

        /// <summary>
        /// Gets or Sets SkinId
        /// </summary>
        [DataMember(Name="skinId", EmitDefaultValue=false)]
        public int? SkinId { get; set; }

        /// <summary>
        /// Gets or Sets Sources
        /// </summary>
        [DataMember(Name="sources", EmitDefaultValue=false)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// Gets or Sets StillObtainable
        /// </summary>
        [DataMember(Name="stillObtainable", EmitDefaultValue=false)]
        public bool? StillObtainable { get; set; }

        /// <summary>
        /// Gets or Sets WinCountRemaining
        /// </summary>
        [DataMember(Name="winCountRemaining", EmitDefaultValue=false)]
        public int? WinCountRemaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectionsLcdsChampionSkinDTO {\n");
            sb.Append("  ChampionId: ").Append(ChampionId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  FreeToPlayReward: ").Append(FreeToPlayReward).Append("\n");
            sb.Append("  LastSelected: ").Append(LastSelected).Append("\n");
            sb.Append("  Owned: ").Append(Owned).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  SkinId: ").Append(SkinId).Append("\n");
            sb.Append("  Sources: ").Append(Sources).Append("\n");
            sb.Append("  StillObtainable: ").Append(StillObtainable).Append("\n");
            sb.Append("  WinCountRemaining: ").Append(WinCountRemaining).Append("\n");
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
            return this.Equals(obj as CollectionsLcdsChampionSkinDTO);
        }

        /// <summary>
        /// Returns true if CollectionsLcdsChampionSkinDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of CollectionsLcdsChampionSkinDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectionsLcdsChampionSkinDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChampionId == other.ChampionId ||
                    this.ChampionId != null &&
                    this.ChampionId.Equals(other.ChampionId)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.FreeToPlayReward == other.FreeToPlayReward ||
                    this.FreeToPlayReward != null &&
                    this.FreeToPlayReward.Equals(other.FreeToPlayReward)
                ) && 
                (
                    this.LastSelected == other.LastSelected ||
                    this.LastSelected != null &&
                    this.LastSelected.Equals(other.LastSelected)
                ) && 
                (
                    this.Owned == other.Owned ||
                    this.Owned != null &&
                    this.Owned.Equals(other.Owned)
                ) && 
                (
                    this.PurchaseDate == other.PurchaseDate ||
                    this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(other.PurchaseDate)
                ) && 
                (
                    this.SkinId == other.SkinId ||
                    this.SkinId != null &&
                    this.SkinId.Equals(other.SkinId)
                ) && 
                (
                    this.Sources == other.Sources ||
                    this.Sources != null &&
                    this.Sources.SequenceEqual(other.Sources)
                ) && 
                (
                    this.StillObtainable == other.StillObtainable ||
                    this.StillObtainable != null &&
                    this.StillObtainable.Equals(other.StillObtainable)
                ) && 
                (
                    this.WinCountRemaining == other.WinCountRemaining ||
                    this.WinCountRemaining != null &&
                    this.WinCountRemaining.Equals(other.WinCountRemaining)
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
                if (this.ChampionId != null)
                    hash = hash * 59 + this.ChampionId.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.FreeToPlayReward != null)
                    hash = hash * 59 + this.FreeToPlayReward.GetHashCode();
                if (this.LastSelected != null)
                    hash = hash * 59 + this.LastSelected.GetHashCode();
                if (this.Owned != null)
                    hash = hash * 59 + this.Owned.GetHashCode();
                if (this.PurchaseDate != null)
                    hash = hash * 59 + this.PurchaseDate.GetHashCode();
                if (this.SkinId != null)
                    hash = hash * 59 + this.SkinId.GetHashCode();
                if (this.Sources != null)
                    hash = hash * 59 + this.Sources.GetHashCode();
                if (this.StillObtainable != null)
                    hash = hash * 59 + this.StillObtainable.GetHashCode();
                if (this.WinCountRemaining != null)
                    hash = hash * 59 + this.WinCountRemaining.GetHashCode();
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
