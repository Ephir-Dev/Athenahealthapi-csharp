// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.AuthenaHealth.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AthenaHealth.
    /// </summary>
    public static partial class AthenaHealthExtensions
    {
            /// <summary>
            /// Get available practice IDs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='limit'>
            /// Number of entries to return (default 1500, max 5000)
            /// </param>
            /// <param name='offset'>
            /// Starting point of entries; 0-indexed
            /// </param>
            public static PracticesInformationList GetPracticeInfo(this IAthenaHealth operations, int? limit = default(int?), int? offset = default(int?))
            {
                return operations.GetPracticeInfoAsync(limit, offset).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get available practice IDs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='limit'>
            /// Number of entries to return (default 1500, max 5000)
            /// </param>
            /// <param name='offset'>
            /// Starting point of entries; 0-indexed
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PracticesInformationList> GetPracticeInfoAsync(this IAthenaHealth operations, int? limit = default(int?), int? offset = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPracticeInfoWithHttpMessagesAsync(limit, offset, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get department IDs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='limit'>
            /// Number of entries to return (default 1500, max 5000)
            /// </param>
            /// <param name='offset'>
            /// Starting point of entries; 0-indexed
            /// </param>
            /// <param name='hospitalonly'>
            /// If set to true, return hospital only departments.
            /// </param>
            /// <param name='showalldepartments'>
            /// By default, departments hidden in the portal do not appear. When this is
            /// set to true, that restriction is not applied. Default is false.
            /// </param>
            /// <param name='providerlist'>
            /// If set to true, list providers who see patients in this department. Default
            /// is false.
            /// </param>
            public static DepartmentInformationList GetDepartments(this IAthenaHealth operations, int? limit = default(int?), int? offset = default(int?), bool? hospitalonly = default(bool?), bool? showalldepartments = default(bool?), bool? providerlist = default(bool?))
            {
                return operations.GetDepartmentsAsync(limit, offset, hospitalonly, showalldepartments, providerlist).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get department IDs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='limit'>
            /// Number of entries to return (default 1500, max 5000)
            /// </param>
            /// <param name='offset'>
            /// Starting point of entries; 0-indexed
            /// </param>
            /// <param name='hospitalonly'>
            /// If set to true, return hospital only departments.
            /// </param>
            /// <param name='showalldepartments'>
            /// By default, departments hidden in the portal do not appear. When this is
            /// set to true, that restriction is not applied. Default is false.
            /// </param>
            /// <param name='providerlist'>
            /// If set to true, list providers who see patients in this department. Default
            /// is false.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DepartmentInformationList> GetDepartmentsAsync(this IAthenaHealth operations, int? limit = default(int?), int? offset = default(int?), bool? hospitalonly = default(bool?), bool? showalldepartments = default(bool?), bool? providerlist = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDepartmentsWithHttpMessagesAsync(limit, offset, hospitalonly, showalldepartments, providerlist, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Register new patient
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address1'>
            /// Patient's address - 1st line (Max length: 100)
            /// </param>
            /// <param name='address2'>
            /// Patient's address - 2nd line (Max length: 100)
            /// </param>
            /// <param name='city'>
            /// Patient's city (Max length: 30)
            /// </param>
            /// <param name='departmentid'>
            /// Primary (registration) department ID.
            /// </param>
            /// <param name='dob'>
            /// Patient's DOB (mm/dd/yyyy)
            /// </param>
            /// <param name='email'>
            /// Patient's email address. 'declined' can be used to indicate just that.
            /// </param>
            /// <param name='firstname'>
            /// Patient's first name
            /// </param>
            /// <param name='homephone'>
            /// The patient's home phone number. Invalid numbers in a GET will be ignored.
            /// Patient phone numbers and other data may change, and one phone number may
            /// be associated with multiple patients. You are responsible for taking
            /// additional steps to verify patient identity and for using this data in
            /// accordance with applicable law, including HIPAA. Only phone numbers that
            /// exist in the North American Naming Plan (NANP) are acceptable for input.
            /// </param>
            /// <param name='lastname'>
            /// Patient's last name
            /// </param>
            /// <param name='mobilephone'>
            /// The patient's mobile phone number. On input, 'declined' can be used to
            /// indicate no number. (Alternatively, hasmobile can also be set to false.
            /// "declined" simply does this for you.) Invalid numbers in a GET will be
            /// ignored. Patient phone numbers and other data may change, and one phone
            /// number may be associated with multiple patients. You are responsible for
            /// taking additional steps to verify patient identity and for using this data
            /// in accordance with applicable law, including HIPAA. Only phone numbers that
            /// exist in the North American Naming Plan (NANP) are acceptable for input.
            /// </param>
            /// <param name='state'>
            /// Patient's state (2 letter abbreviation)
            /// </param>
            /// <param name='zip'>
            /// Patient's zip. Matching occurs on first 5 characters.
            /// </param>
            public static object CreatePatient(this IAthenaHealth operations, string address1 = default(string), string address2 = default(string), string city = default(string), int? departmentid = default(int?), string dob = default(string), string email = default(string), string firstname = default(string), string homephone = default(string), string lastname = default(string), string mobilephone = default(string), string state = default(string), string zip = default(string))
            {
                return operations.CreatePatientAsync(address1, address2, city, departmentid, dob, email, firstname, homephone, lastname, mobilephone, state, zip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Register new patient
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='address1'>
            /// Patient's address - 1st line (Max length: 100)
            /// </param>
            /// <param name='address2'>
            /// Patient's address - 2nd line (Max length: 100)
            /// </param>
            /// <param name='city'>
            /// Patient's city (Max length: 30)
            /// </param>
            /// <param name='departmentid'>
            /// Primary (registration) department ID.
            /// </param>
            /// <param name='dob'>
            /// Patient's DOB (mm/dd/yyyy)
            /// </param>
            /// <param name='email'>
            /// Patient's email address. 'declined' can be used to indicate just that.
            /// </param>
            /// <param name='firstname'>
            /// Patient's first name
            /// </param>
            /// <param name='homephone'>
            /// The patient's home phone number. Invalid numbers in a GET will be ignored.
            /// Patient phone numbers and other data may change, and one phone number may
            /// be associated with multiple patients. You are responsible for taking
            /// additional steps to verify patient identity and for using this data in
            /// accordance with applicable law, including HIPAA. Only phone numbers that
            /// exist in the North American Naming Plan (NANP) are acceptable for input.
            /// </param>
            /// <param name='lastname'>
            /// Patient's last name
            /// </param>
            /// <param name='mobilephone'>
            /// The patient's mobile phone number. On input, 'declined' can be used to
            /// indicate no number. (Alternatively, hasmobile can also be set to false.
            /// "declined" simply does this for you.) Invalid numbers in a GET will be
            /// ignored. Patient phone numbers and other data may change, and one phone
            /// number may be associated with multiple patients. You are responsible for
            /// taking additional steps to verify patient identity and for using this data
            /// in accordance with applicable law, including HIPAA. Only phone numbers that
            /// exist in the North American Naming Plan (NANP) are acceptable for input.
            /// </param>
            /// <param name='state'>
            /// Patient's state (2 letter abbreviation)
            /// </param>
            /// <param name='zip'>
            /// Patient's zip. Matching occurs on first 5 characters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreatePatientAsync(this IAthenaHealth operations, string address1 = default(string), string address2 = default(string), string city = default(string), int? departmentid = default(int?), string dob = default(string), string email = default(string), string firstname = default(string), string homephone = default(string), string lastname = default(string), string mobilephone = default(string), string state = default(string), string zip = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatePatientWithHttpMessagesAsync(address1, address2, city, departmentid, dob, email, firstname, homephone, lastname, mobilephone, state, zip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a patients by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='patientId'>
            /// Id of the patient for which get information
            /// </param>
            public static IList<PatientInformation> GetPatientById(this IAthenaHealth operations, int patientId)
            {
                return operations.GetPatientByIdAsync(patientId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a patients by ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='patientId'>
            /// Id of the patient for which get information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PatientInformation>> GetPatientByIdAsync(this IAthenaHealth operations, int patientId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPatientByIdWithHttpMessagesAsync(patientId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
