// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AppointmentTypeInformation
    {
        /// <summary>
        /// Initializes a new instance of the AppointmentTypeInformation class.
        /// </summary>
        public AppointmentTypeInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AppointmentTypeInformation class.
        /// </summary>
        /// <param name="name">The name of the appointment type.</param>
        /// <param name="appointmenttypeid">The appointment type ID.</param>
        /// <param name="duration">Expected duration of the appointment in
        /// minutes.</param>
        /// <param name="genericyn">If true, this type is a "generic" type able
        /// to be filled with other types of appointments.</param>
        /// <param name="shortname">The short name code of the appointment
        /// type.</param>
        /// <param name="patientyn">If true, this type is a patient-facing
        /// type.</param>
        /// <param name="patientdisplayname">Patient friendly appointment type
        /// name. Defaults to regular name.</param>
        /// <param name="templatetypeonlyyn">If true, this type is a
        /// "template-only" type, and must be filled with a different
        /// appointment type upon booking.</param>
        /// <param name="createencounteroncheckin">If true, then this
        /// appointments of this type will generated an encounter when checked
        /// in, with certain conditions. It's rather complex, but the rendering
        /// provider on the appointment must also have the create encounter
        /// feature set, the department must have athena Clinicals enabled, and
        /// other rarer and less visible settings.
        /// </param>
        public AppointmentTypeInformation(string name, int appointmenttypeid, int? duration = default(int?), bool? genericyn = default(bool?), string shortname = default(string), bool? patientyn = default(bool?), string patientdisplayname = default(string), bool? templatetypeonlyyn = default(bool?), bool? createencounteroncheckin = default(bool?))
        {
            Name = name;
            Duration = duration;
            Genericyn = genericyn;
            Shortname = shortname;
            Patientyn = patientyn;
            Patientdisplayname = patientdisplayname;
            Appointmenttypeid = appointmenttypeid;
            Templatetypeonlyyn = templatetypeonlyyn;
            Createencounteroncheckin = createencounteroncheckin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the appointment type.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets expected duration of the appointment in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or sets if true, this type is a "generic" type able to be
        /// filled with other types of appointments.
        /// </summary>
        [JsonProperty(PropertyName = "genericyn")]
        public bool? Genericyn { get; set; }

        /// <summary>
        /// Gets or sets the short name code of the appointment type.
        /// </summary>
        [JsonProperty(PropertyName = "shortname")]
        public string Shortname { get; set; }

        /// <summary>
        /// Gets or sets if true, this type is a patient-facing type.
        /// </summary>
        [JsonProperty(PropertyName = "patientyn")]
        public bool? Patientyn { get; set; }

        /// <summary>
        /// Gets or sets patient friendly appointment type name. Defaults to
        /// regular name.
        /// </summary>
        [JsonProperty(PropertyName = "patientdisplayname")]
        public string Patientdisplayname { get; set; }

        /// <summary>
        /// Gets or sets the appointment type ID.
        /// </summary>
        [JsonProperty(PropertyName = "appointmenttypeid")]
        public int Appointmenttypeid { get; set; }

        /// <summary>
        /// Gets or sets if true, this type is a "template-only" type, and must
        /// be filled with a different appointment type upon booking.
        /// </summary>
        [JsonProperty(PropertyName = "templatetypeonlyyn")]
        public bool? Templatetypeonlyyn { get; set; }

        /// <summary>
        /// Gets or sets if true, then this appointments of this type will
        /// generated an encounter when checked in, with certain conditions.
        /// It's rather complex, but the rendering provider on the appointment
        /// must also have the create encounter feature set, the department
        /// must have athena Clinicals enabled, and other rarer and less
        /// visible settings.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "createencounteroncheckin")]
        public bool? Createencounteroncheckin { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}