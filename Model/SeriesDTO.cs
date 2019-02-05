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
    /// SeriesDTO
    /// </summary>
    [DataContract]
    public partial class SeriesDTO :  IEquatable<SeriesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesDTO" /> class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="EndDate">EndDate.</param>
        /// <param name="Id">Id.</param>
        /// <param name="InternalName">InternalName.</param>
        /// <param name="Media">Media.</param>
        /// <param name="ParentName">ParentName.</param>
        /// <param name="StartDate">StartDate.</param>
        /// <param name="Tags">Tags.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Warnings">Warnings.</param>
        public SeriesDTO(string Description = default(string), long? EndDate = default(long?), string Id = default(string), string InternalName = default(string), SeriesMediaDTO Media = default(SeriesMediaDTO), string ParentName = default(string), long? StartDate = default(long?), List<string> Tags = default(List<string>), string Title = default(string), List<SeriesAlertDTO> Warnings = default(List<SeriesAlertDTO>))
        {
            this.Description = Description;
            this.EndDate = EndDate;
            this.Id = Id;
            this.InternalName = InternalName;
            this.Media = Media;
            this.ParentName = ParentName;
            this.StartDate = StartDate;
            this.Tags = Tags;
            this.Title = Title;
            this.Warnings = Warnings;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InternalName
        /// </summary>
        [DataMember(Name="internalName", EmitDefaultValue=false)]
        public string InternalName { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public SeriesMediaDTO Media { get; set; }

        /// <summary>
        /// Gets or Sets ParentName
        /// </summary>
        [DataMember(Name="parentName", EmitDefaultValue=false)]
        public string ParentName { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name="warnings", EmitDefaultValue=false)]
        public List<SeriesAlertDTO> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeriesDTO {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  ParentName: ").Append(ParentName).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(obj as SeriesDTO);
        }

        /// <summary>
        /// Returns true if SeriesDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of SeriesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SeriesDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.InternalName == other.InternalName ||
                    this.InternalName != null &&
                    this.InternalName.Equals(other.InternalName)
                ) && 
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) && 
                (
                    this.ParentName == other.ParentName ||
                    this.ParentName != null &&
                    this.ParentName.Equals(other.ParentName)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Warnings == other.Warnings ||
                    this.Warnings != null &&
                    this.Warnings.SequenceEqual(other.Warnings)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.InternalName != null)
                    hash = hash * 59 + this.InternalName.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                if (this.ParentName != null)
                    hash = hash * 59 + this.ParentName.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Warnings != null)
                    hash = hash * 59 + this.Warnings.GetHashCode();
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