// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PatientLabResultDocument
    {
        /// <summary>
        /// Initializes a new instance of the PatientLabResultDocument class.
        /// </summary>
        public PatientLabResultDocument()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatientLabResultDocument class.
        /// </summary>
        /// <param name="createddate">Date the document was created. Please use
        /// createddatetime instead.</param>
        /// <param name="documentroute">Explains method by which the document
        /// was entered into the AthenaNet (INTERFACE (digital), FAX,
        /// etc.)</param>
        /// <param name="documentsubclass">Specific type of document</param>
        /// <param name="resultstatus">The status of the result.</param>
        /// <param name="providerid">Provider ID for this document</param>
        /// <param name="externalaccessionid">The external accession ID for
        /// this document. Format depends on the system the ID belongs
        /// to.</param>
        /// <param name="ordertype">Order type group name</param>
        /// <param name="status">Status of the document</param>
        /// <param name="externalnoteonly">External note for the
        /// patient.</param>
        /// <param name="patientid">The athenaNet patient ID.</param>
        /// <param name="internalaccessionid">The internal accession ID for
        /// this document. Format depends on the system the ID belongs
        /// to.</param>
        /// <param name="isconfidential">If true, this result document should
        /// not be shown to the patient.</param>
        /// <param name="createddatetime">Date/Time (ISO 8601) the document was
        /// created</param>
        /// <param name="encounterid">Encounter ID</param>
        /// <param name="appointmentid">The appointment ID for this
        /// document</param>
        /// <param name="documentsource">Explains where this document
        /// originated.</param>
        /// <param name="documenttypeid">The ID of the description for this
        /// document</param>
        /// <param name="internalnote">The 'Internal Note' attached to this
        /// document</param>
        /// <param name="reportstatus">The status of the report.</param>
        /// <param name="subject">Subject of the document</param>
        /// <param name="departmentid">Department for the document</param>
        /// <param name="encounterdate">Date of the encounter associated with
        /// this document</param>
        /// <param name="lastmodifieddate">Date/time (ISO 8601) the document
        /// was last modified</param>
        /// <param name="deleteddatetime">Date/time (ISO 8601) the document was
        /// deleted</param>
        /// <param name="documentclass">Class of document</param>
        /// <param name="assignedto">Person the document is assigned to</param>
        /// <param name="facilityid">The ID of the clinical provider associated
        /// with this clinical document. Clinical providers are a master list
        /// of providers throughout the country. These include providers as
        /// well as radiology centers, labs and pharmacies.</param>
        /// <param name="observationdate">Date/time the observation was
        /// taken</param>
        /// <param name="interpretation">The practice entered interpretation of
        /// this result.</param>
        /// <param name="labresultid">The primary key for labresult class of
        /// documents</param>
        /// <param name="labresultloinc">Laboratory code that identifies the
        /// overall result.</param>
        /// <param name="lastmodifieddatetime">Date/time (ISO 8601) the
        /// document was last modified</param>
        /// <param name="notefromlab">A note from lab.</param>
        /// <param name="priority">Document priority, when available. 1 is
        /// high, 2 is normal. Some labs use other numbers or characters that
        /// are lab-specific.</param>
        /// <param name="observationdatetime">Date/time (ISO 8601) the
        /// observation was taken</param>
        /// <param name="description">Description of the document type</param>
        /// <param name="patientnote">External note for the patient.</param>
        /// <param name="tietoorderid">Order ID of the order this document is
        /// tied to, if any</param>
        public PatientLabResultDocument(string createddate = default(string), string documentroute = default(string), string documentsubclass = default(string), string resultstatus = default(string), int? providerid = default(int?), string externalaccessionid = default(string), string ordertype = default(string), string status = default(string), string externalnoteonly = default(string), int? patientid = default(int?), string internalaccessionid = default(string), bool? isconfidential = default(bool?), string createddatetime = default(string), string encounterid = default(string), int? appointmentid = default(int?), string documentsource = default(string), int? documenttypeid = default(int?), string internalnote = default(string), string reportstatus = default(string), string subject = default(string), string departmentid = default(string), string encounterdate = default(string), string lastmodifieddate = default(string), string deleteddatetime = default(string), string documentclass = default(string), string assignedto = default(string), string facilityid = default(string), string observationdate = default(string), string interpretation = default(string), int? labresultid = default(int?), string labresultloinc = default(string), string lastmodifieddatetime = default(string), string notefromlab = default(string), string priority = default(string), string observationdatetime = default(string), string description = default(string), string patientnote = default(string), int? tietoorderid = default(int?))
        {
            Createddate = createddate;
            Documentroute = documentroute;
            Documentsubclass = documentsubclass;
            Resultstatus = resultstatus;
            Providerid = providerid;
            Externalaccessionid = externalaccessionid;
            Ordertype = ordertype;
            Status = status;
            Externalnoteonly = externalnoteonly;
            Patientid = patientid;
            Internalaccessionid = internalaccessionid;
            Isconfidential = isconfidential;
            Createddatetime = createddatetime;
            Encounterid = encounterid;
            Appointmentid = appointmentid;
            Documentsource = documentsource;
            Documenttypeid = documenttypeid;
            Internalnote = internalnote;
            Reportstatus = reportstatus;
            Subject = subject;
            Departmentid = departmentid;
            Encounterdate = encounterdate;
            Lastmodifieddate = lastmodifieddate;
            Deleteddatetime = deleteddatetime;
            Documentclass = documentclass;
            Assignedto = assignedto;
            Facilityid = facilityid;
            Observationdate = observationdate;
            Interpretation = interpretation;
            Labresultid = labresultid;
            Labresultloinc = labresultloinc;
            Lastmodifieddatetime = lastmodifieddatetime;
            Notefromlab = notefromlab;
            Priority = priority;
            Observationdatetime = observationdatetime;
            Description = description;
            Patientnote = patientnote;
            Tietoorderid = tietoorderid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date the document was created. Please use
        /// createddatetime instead.
        /// </summary>
        [JsonProperty(PropertyName = "createddate")]
        public string Createddate { get; set; }

        /// <summary>
        /// Gets or sets explains method by which the document was entered into
        /// the AthenaNet (INTERFACE (digital), FAX, etc.)
        /// </summary>
        [JsonProperty(PropertyName = "documentroute")]
        public string Documentroute { get; set; }

        /// <summary>
        /// Gets or sets specific type of document
        /// </summary>
        [JsonProperty(PropertyName = "documentsubclass")]
        public string Documentsubclass { get; set; }

        /// <summary>
        /// Gets or sets the status of the result.
        /// </summary>
        [JsonProperty(PropertyName = "resultstatus")]
        public string Resultstatus { get; set; }

        /// <summary>
        /// Gets or sets provider ID for this document
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? Providerid { get; set; }

        /// <summary>
        /// Gets or sets the external accession ID for this document. Format
        /// depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "externalaccessionid")]
        public string Externalaccessionid { get; set; }

        /// <summary>
        /// Gets or sets order type group name
        /// </summary>
        [JsonProperty(PropertyName = "ordertype")]
        public string Ordertype { get; set; }

        /// <summary>
        /// Gets or sets status of the document
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets external note for the patient.
        /// </summary>
        [JsonProperty(PropertyName = "externalnoteonly")]
        public string Externalnoteonly { get; set; }

        /// <summary>
        /// Gets or sets the athenaNet patient ID.
        /// </summary>
        [JsonProperty(PropertyName = "patientid")]
        public int? Patientid { get; set; }

        /// <summary>
        /// Gets or sets the internal accession ID for this document. Format
        /// depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "internalaccessionid")]
        public string Internalaccessionid { get; set; }

        /// <summary>
        /// Gets or sets if true, this result document should not be shown to
        /// the patient.
        /// </summary>
        [JsonProperty(PropertyName = "isconfidential")]
        public bool? Isconfidential { get; set; }

        /// <summary>
        /// Gets or sets date/Time (ISO 8601) the document was created
        /// </summary>
        [JsonProperty(PropertyName = "createddatetime")]
        public string Createddatetime { get; set; }

        /// <summary>
        /// Gets or sets encounter ID
        /// </summary>
        [JsonProperty(PropertyName = "encounterid")]
        public string Encounterid { get; set; }

        /// <summary>
        /// Gets or sets the appointment ID for this document
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int? Appointmentid { get; set; }

        /// <summary>
        /// Gets or sets explains where this document originated.
        /// </summary>
        [JsonProperty(PropertyName = "documentsource")]
        public string Documentsource { get; set; }

        /// <summary>
        /// Gets or sets the ID of the description for this document
        /// </summary>
        [JsonProperty(PropertyName = "documenttypeid")]
        public int? Documenttypeid { get; set; }

        /// <summary>
        /// Gets or sets the 'Internal Note' attached to this document
        /// </summary>
        [JsonProperty(PropertyName = "internalnote")]
        public string Internalnote { get; set; }

        /// <summary>
        /// Gets or sets the status of the report.
        /// </summary>
        [JsonProperty(PropertyName = "reportstatus")]
        public string Reportstatus { get; set; }

        /// <summary>
        /// Gets or sets subject of the document
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets department for the document
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public string Departmentid { get; set; }

        /// <summary>
        /// Gets or sets date of the encounter associated with this document
        /// </summary>
        [JsonProperty(PropertyName = "encounterdate")]
        public string Encounterdate { get; set; }

        /// <summary>
        /// Gets or sets date/time (ISO 8601) the document was last modified
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddate")]
        public string Lastmodifieddate { get; set; }

        /// <summary>
        /// Gets or sets date/time (ISO 8601) the document was deleted
        /// </summary>
        [JsonProperty(PropertyName = "deleteddatetime")]
        public string Deleteddatetime { get; set; }

        /// <summary>
        /// Gets or sets class of document
        /// </summary>
        [JsonProperty(PropertyName = "documentclass")]
        public string Documentclass { get; set; }

        /// <summary>
        /// Gets or sets person the document is assigned to
        /// </summary>
        [JsonProperty(PropertyName = "assignedto")]
        public string Assignedto { get; set; }

        /// <summary>
        /// Gets or sets the ID of the clinical provider associated with this
        /// clinical document. Clinical providers are a master list of
        /// providers throughout the country. These include providers as well
        /// as radiology centers, labs and pharmacies.
        /// </summary>
        [JsonProperty(PropertyName = "facilityid")]
        public string Facilityid { get; set; }

        /// <summary>
        /// Gets or sets date/time the observation was taken
        /// </summary>
        [JsonProperty(PropertyName = "observationdate")]
        public string Observationdate { get; set; }

        /// <summary>
        /// Gets or sets the practice entered interpretation of this result.
        /// </summary>
        [JsonProperty(PropertyName = "interpretation")]
        public string Interpretation { get; set; }

        /// <summary>
        /// Gets or sets the primary key for labresult class of documents
        /// </summary>
        [JsonProperty(PropertyName = "labresultid")]
        public int? Labresultid { get; set; }

        /// <summary>
        /// Gets or sets laboratory code that identifies the overall result.
        /// </summary>
        [JsonProperty(PropertyName = "labresultloinc")]
        public string Labresultloinc { get; set; }

        /// <summary>
        /// Gets or sets date/time (ISO 8601) the document was last modified
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddatetime")]
        public string Lastmodifieddatetime { get; set; }

        /// <summary>
        /// Gets or sets a note from lab.
        /// </summary>
        [JsonProperty(PropertyName = "notefromlab")]
        public string Notefromlab { get; set; }

        /// <summary>
        /// Gets or sets document priority, when available. 1 is high, 2 is
        /// normal. Some labs use other numbers or characters that are
        /// lab-specific.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        /// <summary>
        /// Gets or sets date/time (ISO 8601) the observation was taken
        /// </summary>
        [JsonProperty(PropertyName = "observationdatetime")]
        public string Observationdatetime { get; set; }

        /// <summary>
        /// Gets or sets description of the document type
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets external note for the patient.
        /// </summary>
        [JsonProperty(PropertyName = "patientnote")]
        public string Patientnote { get; set; }

        /// <summary>
        /// Gets or sets order ID of the order this document is tied to, if any
        /// </summary>
        [JsonProperty(PropertyName = "tietoorderid")]
        public int? Tietoorderid { get; set; }

    }
}
