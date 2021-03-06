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
    /// LolLootRecipeMenuConfig
    /// </summary>
    [DataContract]
    public partial class LolLootRecipeMenuConfig :  IEquatable<LolLootRecipeMenuConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLootRecipeMenuConfig" /> class.
        /// </summary>
        /// <param name="AlwaysShowLootIds">AlwaysShowLootIds.</param>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="LootItemsUsingBreakoutRecipeMenu">LootItemsUsingBreakoutRecipeMenu.</param>
        public LolLootRecipeMenuConfig(List<string> AlwaysShowLootIds = default(List<string>), bool? Enabled = default(bool?), List<string> LootItemsUsingBreakoutRecipeMenu = default(List<string>))
        {
            this.AlwaysShowLootIds = AlwaysShowLootIds;
            this.Enabled = Enabled;
            this.LootItemsUsingBreakoutRecipeMenu = LootItemsUsingBreakoutRecipeMenu;
        }
        
        /// <summary>
        /// Gets or Sets AlwaysShowLootIds
        /// </summary>
        [DataMember(Name="alwaysShowLootIds", EmitDefaultValue=false)]
        public List<string> AlwaysShowLootIds { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or Sets LootItemsUsingBreakoutRecipeMenu
        /// </summary>
        [DataMember(Name="lootItemsUsingBreakoutRecipeMenu", EmitDefaultValue=false)]
        public List<string> LootItemsUsingBreakoutRecipeMenu { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLootRecipeMenuConfig {\n");
            sb.Append("  AlwaysShowLootIds: ").Append(AlwaysShowLootIds).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  LootItemsUsingBreakoutRecipeMenu: ").Append(LootItemsUsingBreakoutRecipeMenu).Append("\n");
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
            return this.Equals(obj as LolLootRecipeMenuConfig);
        }

        /// <summary>
        /// Returns true if LolLootRecipeMenuConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLootRecipeMenuConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLootRecipeMenuConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AlwaysShowLootIds == other.AlwaysShowLootIds ||
                    this.AlwaysShowLootIds != null &&
                    this.AlwaysShowLootIds.SequenceEqual(other.AlwaysShowLootIds)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.LootItemsUsingBreakoutRecipeMenu == other.LootItemsUsingBreakoutRecipeMenu ||
                    this.LootItemsUsingBreakoutRecipeMenu != null &&
                    this.LootItemsUsingBreakoutRecipeMenu.SequenceEqual(other.LootItemsUsingBreakoutRecipeMenu)
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
                if (this.AlwaysShowLootIds != null)
                    hash = hash * 59 + this.AlwaysShowLootIds.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.LootItemsUsingBreakoutRecipeMenu != null)
                    hash = hash * 59 + this.LootItemsUsingBreakoutRecipeMenu.GetHashCode();
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
