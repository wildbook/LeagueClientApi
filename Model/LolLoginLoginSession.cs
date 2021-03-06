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
    /// LolLoginLoginSession
    /// </summary>
    [DataContract]
    public partial class LolLoginLoginSession :  IEquatable<LolLoginLoginSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LolLoginLoginSession" /> class.
        /// </summary>
        /// <param name="AccountId">AccountId.</param>
        /// <param name="Connected">Connected.</param>
        /// <param name="Error">Error.</param>
        /// <param name="GasToken">GasToken.</param>
        /// <param name="IdToken">IdToken.</param>
        /// <param name="IsNewPlayer">IsNewPlayer.</param>
        /// <param name="Puuid">Puuid.</param>
        /// <param name="QueueStatus">QueueStatus.</param>
        /// <param name="State">State.</param>
        /// <param name="SummonerId">SummonerId.</param>
        /// <param name="UserAuthToken">UserAuthToken.</param>
        /// <param name="Username">Username.</param>
        public LolLoginLoginSession(long? AccountId = default(long?), bool? Connected = default(bool?), LolLoginLoginError Error = default(LolLoginLoginError), Object GasToken = default(Object), string IdToken = default(string), bool? IsNewPlayer = default(bool?), string Puuid = default(string), LolLoginLoginQueue QueueStatus = default(LolLoginLoginQueue), LolLoginLoginSessionStates State = default(LolLoginLoginSessionStates), long? SummonerId = default(long?), string UserAuthToken = default(string), string Username = default(string))
        {
            this.AccountId = AccountId;
            this.Connected = Connected;
            this.Error = Error;
            this.GasToken = GasToken;
            this.IdToken = IdToken;
            this.IsNewPlayer = IsNewPlayer;
            this.Puuid = Puuid;
            this.QueueStatus = QueueStatus;
            this.State = State;
            this.SummonerId = SummonerId;
            this.UserAuthToken = UserAuthToken;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Connected
        /// </summary>
        [DataMember(Name="connected", EmitDefaultValue=false)]
        public bool? Connected { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public LolLoginLoginError Error { get; set; }

        /// <summary>
        /// Gets or Sets GasToken
        /// </summary>
        [DataMember(Name="gasToken", EmitDefaultValue=false)]
        public Object GasToken { get; set; }

        /// <summary>
        /// Gets or Sets IdToken
        /// </summary>
        [DataMember(Name="idToken", EmitDefaultValue=false)]
        public string IdToken { get; set; }

        /// <summary>
        /// Gets or Sets IsNewPlayer
        /// </summary>
        [DataMember(Name="isNewPlayer", EmitDefaultValue=false)]
        public bool? IsNewPlayer { get; set; }

        /// <summary>
        /// Gets or Sets Puuid
        /// </summary>
        [DataMember(Name="puuid", EmitDefaultValue=false)]
        public string Puuid { get; set; }

        /// <summary>
        /// Gets or Sets QueueStatus
        /// </summary>
        [DataMember(Name="queueStatus", EmitDefaultValue=false)]
        public LolLoginLoginQueue QueueStatus { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public LolLoginLoginSessionStates State { get; set; }

        /// <summary>
        /// Gets or Sets SummonerId
        /// </summary>
        [DataMember(Name="summonerId", EmitDefaultValue=false)]
        public long? SummonerId { get; set; }

        /// <summary>
        /// Gets or Sets UserAuthToken
        /// </summary>
        [DataMember(Name="userAuthToken", EmitDefaultValue=false)]
        public string UserAuthToken { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LolLoginLoginSession {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Connected: ").Append(Connected).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  GasToken: ").Append(GasToken).Append("\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  IsNewPlayer: ").Append(IsNewPlayer).Append("\n");
            sb.Append("  Puuid: ").Append(Puuid).Append("\n");
            sb.Append("  QueueStatus: ").Append(QueueStatus).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  SummonerId: ").Append(SummonerId).Append("\n");
            sb.Append("  UserAuthToken: ").Append(UserAuthToken).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(obj as LolLoginLoginSession);
        }

        /// <summary>
        /// Returns true if LolLoginLoginSession instances are equal
        /// </summary>
        /// <param name="other">Instance of LolLoginLoginSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LolLoginLoginSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.Connected == other.Connected ||
                    this.Connected != null &&
                    this.Connected.Equals(other.Connected)
                ) && 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.GasToken == other.GasToken ||
                    this.GasToken != null &&
                    this.GasToken.Equals(other.GasToken)
                ) && 
                (
                    this.IdToken == other.IdToken ||
                    this.IdToken != null &&
                    this.IdToken.Equals(other.IdToken)
                ) && 
                (
                    this.IsNewPlayer == other.IsNewPlayer ||
                    this.IsNewPlayer != null &&
                    this.IsNewPlayer.Equals(other.IsNewPlayer)
                ) && 
                (
                    this.Puuid == other.Puuid ||
                    this.Puuid != null &&
                    this.Puuid.Equals(other.Puuid)
                ) && 
                (
                    this.QueueStatus == other.QueueStatus ||
                    this.QueueStatus != null &&
                    this.QueueStatus.Equals(other.QueueStatus)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.SummonerId == other.SummonerId ||
                    this.SummonerId != null &&
                    this.SummonerId.Equals(other.SummonerId)
                ) && 
                (
                    this.UserAuthToken == other.UserAuthToken ||
                    this.UserAuthToken != null &&
                    this.UserAuthToken.Equals(other.UserAuthToken)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.Connected != null)
                    hash = hash * 59 + this.Connected.GetHashCode();
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.GasToken != null)
                    hash = hash * 59 + this.GasToken.GetHashCode();
                if (this.IdToken != null)
                    hash = hash * 59 + this.IdToken.GetHashCode();
                if (this.IsNewPlayer != null)
                    hash = hash * 59 + this.IsNewPlayer.GetHashCode();
                if (this.Puuid != null)
                    hash = hash * 59 + this.Puuid.GetHashCode();
                if (this.QueueStatus != null)
                    hash = hash * 59 + this.QueueStatus.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.SummonerId != null)
                    hash = hash * 59 + this.SummonerId.GetHashCode();
                if (this.UserAuthToken != null)
                    hash = hash * 59 + this.UserAuthToken.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
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
