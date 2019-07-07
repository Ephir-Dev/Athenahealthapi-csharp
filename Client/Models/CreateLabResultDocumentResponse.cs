// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateLabResultDocumentResponse
    {
        /// <summary>
        /// Initializes a new instance of the CreateLabResultDocumentResponse
        /// class.
        /// </summary>
        public CreateLabResultDocumentResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateLabResultDocumentResponse
        /// class.
        /// </summary>
        /// <param name="success">Returns true/false if the operation was
        /// successful.</param>
        /// <param name="errormessage">If the operation failed, this will
        /// contain an error message.</param>
        public CreateLabResultDocumentResponse(bool success, int? labresultid = default(int?), string errormessage = default(string))
        {
            Labresultid = labresultid;
            Errormessage = errormessage;
            Success = success;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "labresultid")]
        public int? Labresultid { get; set; }

        /// <summary>
        /// Gets or sets if the operation failed, this will contain an error
        /// message.
        /// </summary>
        [JsonProperty(PropertyName = "errormessage")]
        public string Errormessage { get; set; }

        /// <summary>
        /// Gets or sets returns true/false if the operation was successful.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
