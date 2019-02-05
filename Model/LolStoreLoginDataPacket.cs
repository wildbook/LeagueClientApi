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
    /// LolStoreLoginDataPacket
    /// </summary>
    [DataContract]
    public partial class LolStoreLoginDataPacket :  IEquatable<LolStoreLoginDataPacket>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolStoreLoginDataPacket" /> class.
        /// </summary>
        /// <param name="AllSummonerData">AllSummonerData.</param>
        /// <param name="SimpleMessages">SimpleMessages.</param>
        public LolStoreLoginDataPacket(LolStoreAllSummonerData AllSummonerData = default(LolStoreAllSummonerData), List<LolStoreSimpleDialogMessage> SimpleMessages = default(List<LolStoreSimpleDialogMessage>))
        {
            this.AllSummonerData = AllSummonerData;
            this.SimpleMessages = SimpleMessages;
        }
        
        /// <summary>
        /// Gets or Sets AllSummonerData
        /// </summary>
        [DataMember(Name="allSummonerData", EmitDefaultValue=false)]
        public LolStoreAllSummonerData AllSummonerData { get; set; }

        /// <summary>
        /// Gets or Sets SimpleMessages
        /// </summary>
        [DataMember(Name="simpleMessages", EmitDefaultValue=false)]
        public List<LolStoreSimpleDialogMessage> SimpleMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolStoreLoginDataPacket {\n");
            sb.Append("  AllSummonerData: ").Append(AllSummonerData).Append("\n");
            sb.Append("  SimpleMessages: ").Append(SimpleMessages).Append("\n");
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
            return this.Equals(obj as LolStoreLoginDataPacket);
        }

        /// <summary>
        /// Returns true if LolStoreLoginDataPacket instances are equal
        /// </summary>
        /// <param name="other">Instance of LolStoreLoginDataPacket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolStoreLoginDataPacket other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AllSummonerData == other.AllSummonerData ||
                    this.AllSummonerData != null &&
                    this.AllSummonerData.Equals(other.AllSummonerData)
                ) && 
                (
                    this.SimpleMessages == other.SimpleMessages ||
                    this.SimpleMessages != null &&
                    this.SimpleMessages.SequenceEqual(other.SimpleMessages)
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
                if (this.AllSummonerData != null)
                    hash = hash * 59 + this.AllSummonerData.GetHashCode();
                if (this.SimpleMessages != null)
                    hash = hash * 59 + this.SimpleMessages.GetHashCode();
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
