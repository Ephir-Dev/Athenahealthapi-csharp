// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatientMedicalHistoryQuestion
    {
        /// <summary>
        /// Initializes a new instance of the PatientMedicalHistoryQuestion
        /// class.
        /// </summary>
        public PatientMedicalHistoryQuestion()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientMedicalHistoryQuestion
        /// class.
        /// </summary>
        /// <param name="questionId">Athena ID for the question</param>
        /// <param name="question">Disease being inquired about</param>
        /// <param name="answer">The answer given by the patient to the
        /// question</param>
        /// <param name="note">Any special notes</param>
        /// <param name="diagnosiscode">Diagnosis code</param>
        /// <param name="codeset">Codeset the diagnosis code belongs to</param>
        /// <param name="description">Description of the code</param>
        public PatientMedicalHistoryQuestion(int questionId, string question = default(string), string answer = default(string), string note = default(string), string diagnosiscode = default(string), string codeset = default(string), string description = default(string))
        {
            QuestionId = questionId;
            Question = question;
            Answer = answer;
            Note = note;
            Diagnosiscode = diagnosiscode;
            Codeset = codeset;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets athena ID for the question
        /// </summary>
        [JsonProperty(PropertyName = "questionid")]
        public int QuestionId { get; set; }

        /// <summary>
        /// Gets or sets disease being inquired about
        /// </summary>
        [JsonProperty(PropertyName = "question")]
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the answer given by the patient to the question
        /// </summary>
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or sets any special notes
        /// </summary>
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Gets or sets diagnosis code
        /// </summary>
        [JsonProperty(PropertyName = "diagnosiscode")]
        public string Diagnosiscode { get; set; }

        /// <summary>
        /// Gets or sets codeset the diagnosis code belongs to
        /// </summary>
        [JsonProperty(PropertyName = "codeset")]
        public string Codeset { get; set; }

        /// <summary>
        /// Gets or sets description of the code
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

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