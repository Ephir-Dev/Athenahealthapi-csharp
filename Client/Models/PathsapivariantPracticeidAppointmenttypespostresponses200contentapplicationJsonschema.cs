// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PathsapivariantPracticeidAppointmenttypespostresponses200contentapplicationJsonschema
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PathsapivariantPracticeidAppointmenttypespostresponses200contentapplicationJsonschema
        /// class.
        /// </summary>
        public PathsapivariantPracticeidAppointmenttypespostresponses200contentapplicationJsonschema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PathsapivariantPracticeidAppointmenttypespostresponses200contentapplicationJsonschema
        /// class.
        /// </summary>
        public PathsapivariantPracticeidAppointmenttypespostresponses200contentapplicationJsonschema(int? appointmenttypeid = default(int?))
        {
            Appointmenttypeid = appointmenttypeid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appointmenttypeid")]
        public int? Appointmenttypeid { get; set; }

    }
}
