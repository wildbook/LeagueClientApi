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
    /// LootLcdsRecipeClientDTO
    /// </summary>
    [DataContract]
    public partial class LootLcdsRecipeClientDTO :  IEquatable<LootLcdsRecipeClientDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LootLcdsRecipeClientDTO" /> class.
        /// </summary>
        /// <param name="CrafterName">CrafterName.</param>
        /// <param name="DisplayCategories">DisplayCategories.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Outputs">Outputs.</param>
        /// <param name="RecipeName">RecipeName.</param>
        /// <param name="Slots">Slots.</param>
        /// <param name="Type">Type.</param>
        public LootLcdsRecipeClientDTO(string CrafterName = default(string), string DisplayCategories = default(string), LootLcdsRecipeMetadata Metadata = default(LootLcdsRecipeMetadata), List<LootLcdsRecipeOutputDTO> Outputs = default(List<LootLcdsRecipeOutputDTO>), string RecipeName = default(string), List<LootLcdsRecipeSlotClientDTO> Slots = default(List<LootLcdsRecipeSlotClientDTO>), string Type = default(string))
        {
            this.CrafterName = CrafterName;
            this.DisplayCategories = DisplayCategories;
            this.Metadata = Metadata;
            this.Outputs = Outputs;
            this.RecipeName = RecipeName;
            this.Slots = Slots;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets CrafterName
        /// </summary>
        [DataMember(Name="crafterName", EmitDefaultValue=false)]
        public string CrafterName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayCategories
        /// </summary>
        [DataMember(Name="displayCategories", EmitDefaultValue=false)]
        public string DisplayCategories { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public LootLcdsRecipeMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=false)]
        public List<LootLcdsRecipeOutputDTO> Outputs { get; set; }

        /// <summary>
        /// Gets or Sets RecipeName
        /// </summary>
        [DataMember(Name="recipeName", EmitDefaultValue=false)]
        public string RecipeName { get; set; }

        /// <summary>
        /// Gets or Sets Slots
        /// </summary>
        [DataMember(Name="slots", EmitDefaultValue=false)]
        public List<LootLcdsRecipeSlotClientDTO> Slots { get; set; }

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
            sb.Append("class LootLcdsRecipeClientDTO {\n");
            sb.Append("  CrafterName: ").Append(CrafterName).Append("\n");
            sb.Append("  DisplayCategories: ").Append(DisplayCategories).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  RecipeName: ").Append(RecipeName).Append("\n");
            sb.Append("  Slots: ").Append(Slots).Append("\n");
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
            return this.Equals(obj as LootLcdsRecipeClientDTO);
        }

        /// <summary>
        /// Returns true if LootLcdsRecipeClientDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of LootLcdsRecipeClientDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LootLcdsRecipeClientDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CrafterName == other.CrafterName ||
                    this.CrafterName != null &&
                    this.CrafterName.Equals(other.CrafterName)
                ) && 
                (
                    this.DisplayCategories == other.DisplayCategories ||
                    this.DisplayCategories != null &&
                    this.DisplayCategories.Equals(other.DisplayCategories)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Outputs == other.Outputs ||
                    this.Outputs != null &&
                    this.Outputs.SequenceEqual(other.Outputs)
                ) && 
                (
                    this.RecipeName == other.RecipeName ||
                    this.RecipeName != null &&
                    this.RecipeName.Equals(other.RecipeName)
                ) && 
                (
                    this.Slots == other.Slots ||
                    this.Slots != null &&
                    this.Slots.SequenceEqual(other.Slots)
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
                if (this.CrafterName != null)
                    hash = hash * 59 + this.CrafterName.GetHashCode();
                if (this.DisplayCategories != null)
                    hash = hash * 59 + this.DisplayCategories.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Outputs != null)
                    hash = hash * 59 + this.Outputs.GetHashCode();
                if (this.RecipeName != null)
                    hash = hash * 59 + this.RecipeName.GetHashCode();
                if (this.Slots != null)
                    hash = hash * 59 + this.Slots.GetHashCode();
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
