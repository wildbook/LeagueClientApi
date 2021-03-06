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
    /// PatcherStatus
    /// </summary>
    [DataContract]
    public partial class PatcherStatus :  IEquatable<PatcherStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatcherStatus" /> class.
        /// </summary>
        /// <param name="ConnectedToPatchServer">ConnectedToPatchServer.</param>
        /// <param name="HasUpdatesOnRestart">HasUpdatesOnRestart.</param>
        /// <param name="SuccessfullyInstalledVersion">SuccessfullyInstalledVersion.</param>
        /// <param name="WillRestartOnSelfUpdate">WillRestartOnSelfUpdate.</param>
        public PatcherStatus(bool? ConnectedToPatchServer = default(bool?), bool? HasUpdatesOnRestart = default(bool?), int? SuccessfullyInstalledVersion = default(int?), bool? WillRestartOnSelfUpdate = default(bool?))
        {
            this.ConnectedToPatchServer = ConnectedToPatchServer;
            this.HasUpdatesOnRestart = HasUpdatesOnRestart;
            this.SuccessfullyInstalledVersion = SuccessfullyInstalledVersion;
            this.WillRestartOnSelfUpdate = WillRestartOnSelfUpdate;
        }
        
        /// <summary>
        /// Gets or Sets ConnectedToPatchServer
        /// </summary>
        [DataMember(Name="connectedToPatchServer", EmitDefaultValue=false)]
        public bool? ConnectedToPatchServer { get; set; }

        /// <summary>
        /// Gets or Sets HasUpdatesOnRestart
        /// </summary>
        [DataMember(Name="hasUpdatesOnRestart", EmitDefaultValue=false)]
        public bool? HasUpdatesOnRestart { get; set; }

        /// <summary>
        /// Gets or Sets SuccessfullyInstalledVersion
        /// </summary>
        [DataMember(Name="successfullyInstalledVersion", EmitDefaultValue=false)]
        public int? SuccessfullyInstalledVersion { get; set; }

        /// <summary>
        /// Gets or Sets WillRestartOnSelfUpdate
        /// </summary>
        [DataMember(Name="willRestartOnSelfUpdate", EmitDefaultValue=false)]
        public bool? WillRestartOnSelfUpdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatcherStatus {\n");
            sb.Append("  ConnectedToPatchServer: ").Append(ConnectedToPatchServer).Append("\n");
            sb.Append("  HasUpdatesOnRestart: ").Append(HasUpdatesOnRestart).Append("\n");
            sb.Append("  SuccessfullyInstalledVersion: ").Append(SuccessfullyInstalledVersion).Append("\n");
            sb.Append("  WillRestartOnSelfUpdate: ").Append(WillRestartOnSelfUpdate).Append("\n");
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
            return this.Equals(obj as PatcherStatus);
        }

        /// <summary>
        /// Returns true if PatcherStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of PatcherStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatcherStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConnectedToPatchServer == other.ConnectedToPatchServer ||
                    this.ConnectedToPatchServer != null &&
                    this.ConnectedToPatchServer.Equals(other.ConnectedToPatchServer)
                ) && 
                (
                    this.HasUpdatesOnRestart == other.HasUpdatesOnRestart ||
                    this.HasUpdatesOnRestart != null &&
                    this.HasUpdatesOnRestart.Equals(other.HasUpdatesOnRestart)
                ) && 
                (
                    this.SuccessfullyInstalledVersion == other.SuccessfullyInstalledVersion ||
                    this.SuccessfullyInstalledVersion != null &&
                    this.SuccessfullyInstalledVersion.Equals(other.SuccessfullyInstalledVersion)
                ) && 
                (
                    this.WillRestartOnSelfUpdate == other.WillRestartOnSelfUpdate ||
                    this.WillRestartOnSelfUpdate != null &&
                    this.WillRestartOnSelfUpdate.Equals(other.WillRestartOnSelfUpdate)
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
                if (this.ConnectedToPatchServer != null)
                    hash = hash * 59 + this.ConnectedToPatchServer.GetHashCode();
                if (this.HasUpdatesOnRestart != null)
                    hash = hash * 59 + this.HasUpdatesOnRestart.GetHashCode();
                if (this.SuccessfullyInstalledVersion != null)
                    hash = hash * 59 + this.SuccessfullyInstalledVersion.GetHashCode();
                if (this.WillRestartOnSelfUpdate != null)
                    hash = hash * 59 + this.WillRestartOnSelfUpdate.GetHashCode();
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
