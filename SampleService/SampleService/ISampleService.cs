// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISampleService.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The SampleService interface.
//   NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISampleService" in both code and config file together.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleService
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;

    using SampleDataContracts.DomainDataContracts;
    using SampleDataContracts.FaultDataContracts;

    using SampleDomain;

    /// <summary>
    /// The SampleService interface.
    /// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISampleService" in both code and config file together.
    /// </summary>
    [ServiceContract]
    public interface ISampleService
    {
        /// <summary>
        /// Sets a new Appointment and passes it to Business layer for any necessary logic.
        /// </summary>
        /// <param name="isActive">
        /// A boolean value deciding whether appointment is active.
        /// </param>
        /// <param name="patientId">
        /// A string containing the patientId to extract the correct patient from database.
        /// </param>
        /// <param name="startDateTime">
        /// A DateTime containing desired appointment date and time time. 
        /// </param>
        /// <param name="durationId">
        /// A string containing the id for the desired duration to be grabbed from the database.
        /// </param>
        /// <param name="clinicId">
        /// A string containing the id for the desired clinic.
        /// </param>
        /// <param name="urgencyId">
        /// A string containing the id for the correct urgency.
        /// </param>
        /// <param name="appointmentTypeId">
        /// A string containing whether appointment is new or a follow up.
        /// </param>
        /// <returns>
        /// The SetAppointment AppointmentDataContract.
        /// </returns>
        [OperationContract]
        AppointmentDataContract SetAppointment(
            bool isActive,
            string patientId,
            DateTime startDateTime,
            string durationId,
            string clinicId,
            string urgencyId,
            string appointmentTypeId);

        /// <summary>
        /// Get a specific appointment id.
        /// </summary>
        /// <param name="id">
        /// The appointment id.
        /// </param>
        /// <returns>
        /// The <see cref="Appointment"/>
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidAppointmentIdFault))]
        AppointmentDataContract GetAppointment(int id);

        /// <summary>
        /// Get a list of all appointment instances.
        /// </summary>
        /// <returns>
        /// The list of <see cref="Appointment"/> instances.
        /// </returns>
        [OperationContract]
        List<AppointmentDataContract> GetAppointments();

        #region Duration

        /// <summary>
        /// The get appointment duration data.
        /// </summary>
        /// <param name="id">
        /// The id
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentDurationDataContract"/>.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidDurationFault))]
        AppointmentDurationDataContract GetAppointmentDurationData(string id);

        /// <summary>
        /// Gets all the appointment duration data.
        /// </summary>
        /// <returns>
        /// The list of <see cref="AppointmentDurationDataContract"/>.
        /// </returns>
        [OperationContract]
        List<AppointmentDurationDataContract> GetAllAppointmentDurationData();

        #endregion

        /// <summary>
        /// Get the appointment type id.
        /// </summary>
        /// <param name="id">
        ///  The id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentType"/>
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidAppointmentTypeFault))]
        AppointmentTypeDataContract GetAppointmentTypeId(string id);

        /// <summary>
        /// Get all appointment types.
        /// </summary>
        /// <returns> 
        /// The list of <see cref="AppointmentType"/>
        /// </returns>
        [OperationContract]
        List<AppointmentTypeDataContract> GetAppointmentTypes();

        /// <summary>
        /// Get a specific appointment urgency.
        /// </summary>
        /// <param name="id">
        /// The urgency id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentUrgency"/>.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidDurationFault))]
        AppointmentUrgencyDataContract GetUrgency(string id);

        /// <summary>
        /// Gets all appointment urgencies.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="AppointmentUrgency"/> instances.
        /// </returns>
        [OperationContract]
        List<AppointmentUrgencyDataContract> GetUrgencies();

        /// <summary>
        /// Get a specific clinic.
        /// </summary>
        /// <param name="id">
        /// Clinic id.
        /// </param>
        /// <returns>
        /// The <see cref="Clinic"/>.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidClinicFault))]
        ClinicDataContract GetClinicId(string id);

        /// <summary>
        /// Gets all clinic instances.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Clinic"/> instances.
        /// </returns>
        [OperationContract]
        List<ClinicDataContract> GetClinics();

        /// <summary>
        /// Get a specific patient.
        /// </summary>
        /// <param name="id">
        /// The patient id.
        /// </param>
        /// <returns>
        /// The <see cref="Patient"/>.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidPatientFault))]
        PatientDataContract GetPatient(string id);

        /// <summary>
        /// Gets all patients in the database.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Patient"/> instances.
        /// </returns>
        [OperationContract]
        List<PatientDataContract> GetPatients();

        /// <summary>
        /// Gets a specific specialty.
        /// </summary>
        /// <param name="id">
        /// The specialty id.
        /// </param>
        /// <returns>
        /// The <see cref="Specialty"/> instance.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidSpecialtyFault))]
        SpecialtyDataContract GetSpecialty(string id);

        /// <summary>
        /// Gets all listed specialties.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Specialty"/> instances.
        /// </returns>
        [OperationContract]
        List<SpecialtyDataContract> GetSpecialties();

        /// <summary>
        /// Gets a specific clinic's specialty.
        /// </summary>
        /// <param name="id">
        /// The clinic specialty ID
        /// </param>
        /// <returns>
        /// The <see cref="ClinicSpecialty"/> instance.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidClinicSpecialtyFault))]
        ClinicSpecialtyDataContract GetClinicSpecialty(int id);

        /// <summary>
        /// Gets the specialties of all clinics.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="ClinicSpecialtyDataContract"/> instances.
        /// </returns>
        [OperationContract]
        List<ClinicSpecialtyDataContract> GetClinicSpecialties();

        /// <summary>
        /// Gets a filtered list of specialties based on a clinic code.
        /// </summary>
        /// <param name="clinicCode">
        /// The clinic code.
        /// </param>
        /// <returns>
        /// A list of specialties related to the clinic code.
        /// </returns>
        [OperationContract]
        [FaultContract(typeof(InvalidClinicSpecialtyFault))]
        List<ClinicSpecialtyDataContract> GetFilteredClinicSpecialties(string clinicCode);

        /// <summary>
        /// Gets a list of filtered appointments.
        /// </summary>
        /// <param name="filterColumn">
        /// The filter column.
        /// </param>
        /// <param name="searchTerm">
        /// The search term.
        /// </param>
        /// <returns>
        /// A list of filtered <see cref="AppointmentDataContract"/> instances.
        /// </returns>
        [FaultContract(typeof(InvalidAppointmentIdFault))]
        [OperationContract]
        List<AppointmentDataContract> GetFilteredAppointments(string filterColumn, string searchTerm);
    }
}
