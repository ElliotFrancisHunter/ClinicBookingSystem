﻿
namespace SampleRepository
{
    using System.Collections.Generic;

    using NHibernate.Mapping;

    using SampleDomain;

    /// <summary>
    /// The CustomRepository interface.
    /// </summary>
    public interface ICustomRepository
    {
        /// <summary>
        /// Sets a new appointment.
        /// </summary>
        /// <returns>
        /// The new appointment.
        /// </returns>
        Appointment SetAppointment();

        /// <summary>
        /// Get a specific appointment id.
        /// </summary>
        /// <param name="id">
        /// The appointment id.
        /// </param>
        /// <returns>
        /// The <see cref="Appointment"/>
        /// </returns>
        Appointment GetAppointment(int id);

        /// <summary>
        /// Get a list of all appointment instances.
        /// </summary>
        /// <returns>
        /// The list of <see cref="Appointment"/> instances.
        /// </returns>
        List<Appointment> GetAppointments();

        /// <summary>
        /// Get the duration id.
        /// </summary>
        /// <param name="id">
        ///  The id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentDuration"/>.
        /// </returns>
        AppointmentDuration GetAppointmentDurationId(string id);

        /// <summary>
        /// Gets all appointment durations.
        /// </summary>
        /// <returns>
        /// The list of <see cref="AppointmentDuration"/> instances.
        /// </returns>
        List<AppointmentDuration> GetAllAppointmentDurations();

        /// <summary>
        /// Get the appointment type id.
        /// </summary>
        /// <param name="id">
        ///  The id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentType"/>
        /// </returns>
        AppointmentType GetAppointmentTypeId(string id);

        /// <summary>
        /// Get all appointment types.
        /// </summary>
        /// <returns> 
        /// The list of <see cref="AppointmentType"/> instances.
        /// </returns>
        List<AppointmentType> GetAppointmentTypes();

        /// <summary>
        /// Get a specific appointment urgency.
        /// </summary>
        /// <param name="id">
        /// The urgency id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentUrgency"/>.
        /// </returns>
        AppointmentUrgency GetUrgency(string id);

        /// <summary>
        /// Gets all appointment urgencies.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="AppointmentUrgency"/> instances.
        /// </returns>
        List<AppointmentUrgency> GetUrgencies();

        /// <summary>
        /// Get the Clinic id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Clinic"/>
        /// </returns>
        Clinic GetClinicId(string id);

        /// <summary>
        /// Get all Clinics
        /// </summary>
        /// <returns>
        /// The list of <see cref="Clinic"/> instances.
        /// </returns>
        List<Clinic> GetClinics();

        /// <summary>
        /// Get a specific patient.
        /// </summary>
        /// <param name="id">
        /// The patient id.
        /// </param>
        /// <returns>
        /// The <see cref="Patient"/>.
        /// </returns>
        Patient GetPatient(string id);

        /// <summary>
        /// Gets all patients in the database.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Patient"/> instances.
        /// </returns>
        List<Patient> GetPatients();

        /// <summary>
        /// Gets a specific specialty.
        /// </summary>
        /// <param name="id">
        /// The specialty id.
        /// </param>
        /// <returns>
        /// The <see cref="Specialty"/> instance.
        /// </returns>
        Specialty GetSpecialty(string id);

        /// <summary>
        /// Gets all listed specialties.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Specialty"/> instances.
        /// </returns>
        List<Specialty> GetSpecialties();

        /// <summary>
        /// Gets a specific clinic's specialty.
        /// </summary>
        /// <param name="id">
        /// The clinic specialty ID
        /// </param>
        /// <returns>
        /// The <see cref="ClinicSpecialty"/> instance.
        /// </returns>
        ClinicSpecialty GetClinicSpecialty(int id);
        
        /// <summary>
        /// Gets the specialties of all clinics.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="ClinicSpecialty"/> instances.
        /// </returns>
        List<ClinicSpecialty> GetClinicSpecialties();
    }
}
