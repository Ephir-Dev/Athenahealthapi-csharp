// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MedicationInformation
    {
        /// <summary>
        /// Initializes a new instance of the MedicationInformation class.
        /// </summary>
        public MedicationInformation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MedicationInformation class.
        /// </summary>
        /// <param name="events">The list of events for this medication. Can be
        /// START, END, ORDER, ENTER, FILL, or HIDE.
        /// </param>
        /// <param name="medicationid">Athena ID for this medication.</param>
        /// <param name="structuredsig">Components of the structured sig.
        /// </param>
        /// <param name="medicationentryid">Primary ID for this medication
        /// entry. Those starting with C are clinical prescriptions, and those
        /// starting with H are historical (entered, downloaded, etc).
        /// </param>
        /// <param name="medication">The name of the medication.</param>
        /// <param name="isstructuredsig">Whether the sig for this entry is
        /// structured.</param>
        /// <param name="unstructuredsig">The unstructured sig for this
        /// medication, if any. If there is a structured sig, this will contain
        /// the formatted version of that sig.
        /// </param>
        /// <param name="source">How this medication was entered. This can be
        /// the ordering provider, a medication history download (express
        /// scripts, medco, etc),  ATHENA (which means it was entered
        /// manually), etc.
        /// </param>
        /// <param name="status">The status of this medication. Medications in
        /// PEND status are associated with approved future orders and have not
        /// yet been submitted.
        /// </param>
        /// <param name="organclass">The organ class for this medication. This
        /// is equivalent to a medication class.</param>
        /// <param name="therapeuticclass">The therapeutic class for this
        /// medication. This is equivalent to a medication subclass.</param>
        /// <param name="futuresubmitdate">The date a medication will be
        /// submitted. Included if the medication is in PEND status and
        /// attached to a approved future order.</param>
        /// <param name="encounterid">If this was a prescription, this contains
        /// the ID of the encounter where it was ordered or
        /// administered</param>
        /// <param name="createdby">The athenaNet username of the person who
        /// entered or ordered the medication. Downloaded medications have
        /// INTERFACE for this field.
        /// </param>
        /// <param name="approvedby">For clinical prescriptions, the athenaNet
        /// username of the person who approved this prescription.</param>
        /// <param name="billingndc">The billing NDC code for this
        /// medication.</param>
        /// <param name="orderingmode">The ordering mode for prescriptions. Can
        /// be PRESCRIBE, DISPENSE, or ADMINISTER.</param>
        /// <param name="quantity">The total quantity prescribed, dispensed,
        /// administered. This is not currently available for historical
        /// (downloaded) medications.</param>
        /// <param name="quantityunit">The unit of the quantity. Example:
        /// tablets, sprays, etc.
        /// </param>
        /// <param name="refillsallowed">The number of refills allowed when
        /// this medication was ordered.</param>
        /// <param name="issafetorenew">Is this medication safe to
        /// renew?</param>
        /// <param name="stopreason">The reason why this medication was
        /// stopped.</param>
        /// <param name="providernote">Non-patient facing note for ths
        /// prescription. Labeled "internal note" in the UI.</param>
        /// <param name="patientnote">Patient-facing note for this
        /// prescription. Labeled "note" in the UI.</param>
        /// <param name="pharmacy">The name of the pharmacy where this
        /// medication was filled.</param>
        /// <param name="pharmacyncpdpid">The NCPDP ID of the pharmacy for this
        /// medication.. See http://www.ncpdp.org/ for details.</param>
        /// <param name="prescribedby">The user who prescribed this
        /// medication.</param>
        /// <param name="ndcoptions">The list of NDC numbers that correspond to
        /// this medication.</param>
        /// <param name="rxnorm">The list of RxNorm Identifiers that correspond
        /// to this medication. This list may contain both branded and generic
        /// identifiers</param>
        /// <param name="route">The route for the prescription.</param>
        public MedicationInformation(IList<MedicationEvent> events, int medicationid, IList<DosageInformation> structuredsig = default(IList<DosageInformation>), string medicationentryid = default(string), string medication = default(string), bool? isstructuredsig = default(bool?), string unstructuredsig = default(string), string source = default(string), string status = default(string), string organclass = default(string), string therapeuticclass = default(string), string futuresubmitdate = default(string), int? encounterid = default(int?), string createdby = default(string), string approvedby = default(string), string billingndc = default(string), string orderingmode = default(string), int? quantity = default(int?), string quantityunit = default(string), int? refillsallowed = default(int?), bool? issafetorenew = default(bool?), string stopreason = default(string), string providernote = default(string), string patientnote = default(string), string pharmacy = default(string), string pharmacyncpdpid = default(string), string prescribedby = default(string), string ndcoptions = default(string), IList<string> rxnorm = default(IList<string>), string route = default(string))
        {
            Events = events;
            Structuredsig = structuredsig;
            Medicationentryid = medicationentryid;
            Medicationid = medicationid;
            Medication = medication;
            Isstructuredsig = isstructuredsig;
            Unstructuredsig = unstructuredsig;
            Source = source;
            Status = status;
            Organclass = organclass;
            Therapeuticclass = therapeuticclass;
            Futuresubmitdate = futuresubmitdate;
            Encounterid = encounterid;
            Createdby = createdby;
            Approvedby = approvedby;
            Billingndc = billingndc;
            Orderingmode = orderingmode;
            Quantity = quantity;
            Quantityunit = quantityunit;
            Refillsallowed = refillsallowed;
            Issafetorenew = issafetorenew;
            Stopreason = stopreason;
            Providernote = providernote;
            Patientnote = patientnote;
            Pharmacy = pharmacy;
            Pharmacyncpdpid = pharmacyncpdpid;
            Prescribedby = prescribedby;
            Ndcoptions = ndcoptions;
            Rxnorm = rxnorm;
            Route = route;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of events for this medication. Can be START,
        /// END, ORDER, ENTER, FILL, or HIDE.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<MedicationEvent> Events { get; set; }

        /// <summary>
        /// Gets or sets components of the structured sig.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "structuredsig")]
        public IList<DosageInformation> Structuredsig { get; set; }

        /// <summary>
        /// Gets or sets primary ID for this medication entry. Those starting
        /// with C are clinical prescriptions, and those starting with H are
        /// historical (entered, downloaded, etc).
        ///
        /// </summary>
        [JsonProperty(PropertyName = "medicationentryid")]
        public string Medicationentryid { get; set; }

        /// <summary>
        /// Gets or sets athena ID for this medication.
        /// </summary>
        [JsonProperty(PropertyName = "medicationid")]
        public int Medicationid { get; set; }

        /// <summary>
        /// Gets or sets the name of the medication.
        /// </summary>
        [JsonProperty(PropertyName = "medication")]
        public string Medication { get; set; }

        /// <summary>
        /// Gets or sets whether the sig for this entry is structured.
        /// </summary>
        [JsonProperty(PropertyName = "isstructuredsig")]
        public bool? Isstructuredsig { get; set; }

        /// <summary>
        /// Gets or sets the unstructured sig for this medication, if any. If
        /// there is a structured sig, this will contain the formatted version
        /// of that sig.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "unstructuredsig")]
        public string Unstructuredsig { get; set; }

        /// <summary>
        /// Gets or sets how this medication was entered. This can be the
        /// ordering provider, a medication history download (express scripts,
        /// medco, etc),  ATHENA (which means it was entered manually), etc.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the status of this medication. Medications in PEND
        /// status are associated with approved future orders and have not yet
        /// been submitted.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the organ class for this medication. This is
        /// equivalent to a medication class.
        /// </summary>
        [JsonProperty(PropertyName = "organclass")]
        public string Organclass { get; set; }

        /// <summary>
        /// Gets or sets the therapeutic class for this medication. This is
        /// equivalent to a medication subclass.
        /// </summary>
        [JsonProperty(PropertyName = "therapeuticclass")]
        public string Therapeuticclass { get; set; }

        /// <summary>
        /// Gets or sets the date a medication will be submitted. Included if
        /// the medication is in PEND status and attached to a approved future
        /// order.
        /// </summary>
        [JsonProperty(PropertyName = "futuresubmitdate")]
        public string Futuresubmitdate { get; set; }

        /// <summary>
        /// Gets or sets if this was a prescription, this contains the ID of
        /// the encounter where it was ordered or administered
        /// </summary>
        [JsonProperty(PropertyName = "encounterid")]
        public int? Encounterid { get; set; }

        /// <summary>
        /// Gets or sets the athenaNet username of the person who entered or
        /// ordered the medication. Downloaded medications have INTERFACE for
        /// this field.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public string Createdby { get; set; }

        /// <summary>
        /// Gets or sets for clinical prescriptions, the athenaNet username of
        /// the person who approved this prescription.
        /// </summary>
        [JsonProperty(PropertyName = "approvedby")]
        public string Approvedby { get; set; }

        /// <summary>
        /// Gets or sets the billing NDC code for this medication.
        /// </summary>
        [JsonProperty(PropertyName = "billingndc")]
        public string Billingndc { get; set; }

        /// <summary>
        /// Gets or sets the ordering mode for prescriptions. Can be PRESCRIBE,
        /// DISPENSE, or ADMINISTER.
        /// </summary>
        [JsonProperty(PropertyName = "orderingmode")]
        public string Orderingmode { get; set; }

        /// <summary>
        /// Gets or sets the total quantity prescribed, dispensed,
        /// administered. This is not currently available for historical
        /// (downloaded) medications.
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets the unit of the quantity. Example: tablets, sprays,
        /// etc.
        ///
        /// </summary>
        [JsonProperty(PropertyName = "quantityunit")]
        public string Quantityunit { get; set; }

        /// <summary>
        /// Gets or sets the number of refills allowed when this medication was
        /// ordered.
        /// </summary>
        [JsonProperty(PropertyName = "refillsallowed")]
        public int? Refillsallowed { get; set; }

        /// <summary>
        /// Gets or sets is this medication safe to renew?
        /// </summary>
        [JsonProperty(PropertyName = "issafetorenew")]
        public bool? Issafetorenew { get; set; }

        /// <summary>
        /// Gets or sets the reason why this medication was stopped.
        /// </summary>
        [JsonProperty(PropertyName = "stopreason")]
        public string Stopreason { get; set; }

        /// <summary>
        /// Gets or sets non-patient facing note for ths prescription. Labeled
        /// "internal note" in the UI.
        /// </summary>
        [JsonProperty(PropertyName = "providernote")]
        public string Providernote { get; set; }

        /// <summary>
        /// Gets or sets patient-facing note for this prescription. Labeled
        /// "note" in the UI.
        /// </summary>
        [JsonProperty(PropertyName = "patientnote")]
        public string Patientnote { get; set; }

        /// <summary>
        /// Gets or sets the name of the pharmacy where this medication was
        /// filled.
        /// </summary>
        [JsonProperty(PropertyName = "pharmacy")]
        public string Pharmacy { get; set; }

        /// <summary>
        /// Gets or sets the NCPDP ID of the pharmacy for this medication.. See
        /// http://www.ncpdp.org/ for details.
        /// </summary>
        [JsonProperty(PropertyName = "pharmacyncpdpid")]
        public string Pharmacyncpdpid { get; set; }

        /// <summary>
        /// Gets or sets the user who prescribed this medication.
        /// </summary>
        [JsonProperty(PropertyName = "prescribedby")]
        public string Prescribedby { get; set; }

        /// <summary>
        /// Gets or sets the list of NDC numbers that correspond to this
        /// medication.
        /// </summary>
        [JsonProperty(PropertyName = "ndcoptions")]
        public string Ndcoptions { get; set; }

        /// <summary>
        /// Gets or sets the list of RxNorm Identifiers that correspond to this
        /// medication. This list may contain both branded and generic
        /// identifiers
        /// </summary>
        [JsonProperty(PropertyName = "rxnorm")]
        public IList<string> Rxnorm { get; set; }

        /// <summary>
        /// Gets or sets the route for the prescription.
        /// </summary>
        [JsonProperty(PropertyName = "route")]
        public string Route { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Events == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Events");
            }
            if (Events != null)
            {
                foreach (var element in Events)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Structuredsig != null)
            {
                foreach (var element1 in Structuredsig)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
