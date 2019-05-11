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

    public partial class TemplateInformation
    {
        /// <summary>
        /// Initializes a new instance of the TemplateInformation class.
        /// </summary>
        public TemplateInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TemplateInformation class.
        /// </summary>
        /// <param name="templateid">ID for this social history
        /// template</param>
        /// <param name="templatename">Name for this social history
        /// template</param>
        public TemplateInformation(int templateid, string templatename)
        {
            Templateid = templateid;
            Templatename = templatename;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID for this social history template
        /// </summary>
        [JsonProperty(PropertyName = "templateid")]
        public int Templateid { get; set; }

        /// <summary>
        /// Gets or sets name for this social history template
        /// </summary>
        [JsonProperty(PropertyName = "templatename")]
        public string Templatename { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Templatename == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Templatename");
            }
        }
    }
}
