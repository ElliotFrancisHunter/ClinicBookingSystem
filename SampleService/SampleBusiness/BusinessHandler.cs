// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BusinessHandler.cs" company="Servelec">
//   Elliot Hunter 2019
// </copyright>
// <summary>
//   The BusinessHandler. Handles business logic.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleBusiness
{
    using System;
    using System.Collections.Generic;
    using Core;
    using SampleDomain;
    using SampleRepository;

    /// <summary>
    /// The BusinessHandler. Handles business logic.
    /// </summary>
    public class BusinessHandler : IBusinessHandler
    {
        /// <summary>
        /// The unit of work.
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessHandler"/> class. 
        /// </summary>
        /// <param name="unitOfWork">
        /// The unit of work.
        /// </param>
        public BusinessHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

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
        public Appointment SetAppointment(
            bool isActive,
            string patientId,
            DateTime startDateTime,
            string durationId,
            string clinicId,
            string urgencyId,
            string appointmentTypeId)
        {
            var setStartTime = startDateTime.TimeOfDay;
            var setStartDate = startDateTime.Date;

            if ()
            {
                return null;
            }

            return new CustomRepository(this.unitOfWork).SetAppointment(
          isActive,
          patientId,
          startDateTime,
          durationId,
          clinicId,
          urgencyId,
          appointmentTypeId);
        }

        /// <summary>
        /// Alters appointment of given id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The appointment.
        /// </returns>
        public Appointment AlterAppointment(int id)
        {
            return new CustomRepository(this.unitOfWork).AlterAppointment(id);
        }

        /// <summary>
        /// Get a specific appointment id.
        /// </summary>
        /// <param name="id">
        /// The appointment id.
        /// </param>
        /// <returns>
        /// The <see cref="Appointment"/>
        /// </returns>
        public Appointment GetAppointment(int id)
        {
            if (id == default(int))
            {
                throw new ThisIsAnIssueException("AppointmentID is not valid.");
            }

            return new CustomRepository(this.unitOfWork).GetAppointment(id);
        }

        /// <summary>
        /// Get a list of all appointment instances.
        /// </summary>
        /// <returns>
        /// The list of <see cref="Appointment"/> instances.
        /// </returns>
        public List<Appointment> GetAppointments()
        {
            return new CustomRepository(this.unitOfWork).GetAppointments();
        }

        /// <summary>
        /// Deletes an appointment instance by id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// A boolean value indicating whether instance has been deleted.
        /// </returns>
        public bool DeleteAppointment(int id)
        {
            if (id == default(int))
            {
                throw new ThisIsAnIssueException("AppointmentID is not valid");
            }

            return new CustomRepository(this.unitOfWork).DeleteAppointment(id);
        }

        /// <summary>
        /// Get the custom data
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The AppointmentDuration
        /// </returns>
        public AppointmentDuration GetAppointmentDurationId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ThisIsAnIssueException("AppointmentDurationID string is empty or null.");
            }

            var duration = new CustomRepository(this.unitOfWork).GetAppointmentDurationId(id);

            if (duration == null)
            {
                throw new ThisIsAnIssueException("No corresponding appointment duration-OOPS!");
            }

            return duration;
        }

        /// <summary>
        /// Gets all appointment durations.
        /// </summary>
        /// <returns>
        /// A list of the <see cref="AppointmentDuration"/>
        /// </returns>
        public List<AppointmentDuration> GetAllAppointmentDurations()
        {
            return new CustomRepository(this.unitOfWork).GetAllAppointmentDurations();
        }

        /// <summary>
        /// Get the appointment type id.
        /// </summary>
        /// <param name="id">
        ///  The id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentType"/>
        /// </returns>
        public AppointmentType GetAppointmentTypeId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
               throw new ThisIsAnIssueException("AppointmentTypeID string is empty or null.");
            }

            var appointment = new CustomRepository(this.unitOfWork).GetAppointmentTypeId(id);

            if (appointment == null)
            {
                throw new ThisIsAnIssueException("No corresponding appointment type-OOPS!");               
            }

            return appointment;
        }

        /// <summary>
        /// Get all appointment types.
        /// </summary>
        /// <returns> 
        /// The list of <see cref="AppointmentType"/>
        /// </returns>
        public List<AppointmentType> GetAppointmentTypes()
        {
            return new CustomRepository(this.unitOfWork).GetAppointmentTypes();
        }

        /// <summary>
        /// Get a specific appointment urgency.
        /// </summary>
        /// <param name="id">
        /// The urgency id.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentUrgency"/>.
        /// </returns>
        public AppointmentUrgency GetUrgency(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ThisIsAnIssueException("UrgencyID string is empty or null.");
            }
            
            var urgency = new CustomRepository(this.unitOfWork).GetUrgency(id);
            if (urgency == null)
            {
                throw new ThisIsAnIssueException("No corresponding Urgency-OOPS!");
            }

            return urgency;
        }

        /// <summary>
        /// Gets all appointment urgencies.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="AppointmentUrgency"/> instances.
        /// </returns>
        public List<AppointmentUrgency> GetUrgencies()
        {
            return new CustomRepository(this.unitOfWork).GetUrgencies();
        }

        /// <summary>
        /// Get a specific clinic id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Clinic"/>.
        /// </returns>
        public Clinic GetClinicId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ThisIsAnIssueException("ClinicID string is empty or null.");
            }

            var clinic = new CustomRepository(this.unitOfWork).GetClinicId(id);
            if (clinic == null)
            {
                throw new ThisIsAnIssueException("No corresponding Clinic-OOPS!");
            }

            return clinic;
        }

        /// <summary>
        /// Gets all clinics
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Clinic"/> instances.
        /// </returns>
        public List<Clinic> GetClinics()
        {
            return new CustomRepository(this.unitOfWork).GetClinics();
        }

        /// <summary>
        /// Get a specific patient.
        /// </summary>
        /// <param name="id">
        /// The patient id.
        /// </param>
        /// <returns>
        /// The <see cref="Patient"/>.
        /// </returns>
        public Patient GetPatient(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ThisIsAnIssueException("PatientID string is empty or null.");
            }

            var patient = new CustomRepository(this.unitOfWork).GetPatient(id);

            if (patient == null)
            {
                throw new ThisIsAnIssueException("No corresponding Patient-OOPS!");
            }

            return patient;
        }

        /// <summary>
        /// Gets all patients in the database.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Patient"/> instances.
        /// </returns>
        public List<Patient> GetPatients()
        {
            return new CustomRepository(this.unitOfWork).GetPatients();
        }

        /// <summary>
        /// Gets a specific specialty.
        /// </summary>
        /// <param name="id">
        /// The specialty id.
        /// </param>
        /// <returns>
        /// The <see cref="Specialty"/> instance.
        /// </returns>
        public Specialty GetSpecialty(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ThisIsAnIssueException("SpecialtyID string is empty or null.");
            }

            var specialty = new CustomRepository(this.unitOfWork).GetSpecialty(id);

            if (specialty == null)
            {
                throw new ThisIsAnIssueException("No corresponding Specialty-OOPS!");
            }

            return specialty;
        }

        /// <summary>
        /// Gets all listed specialties.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Specialty"/> instances.
        /// </returns>
        public List<Specialty> GetSpecialties()
        {
            return new CustomRepository(this.unitOfWork).GetSpecialties();
        }

        /// <summary>
        /// Gets a specific clinic's specialty.
        /// </summary>
        /// <param name="id">
        /// The clinic specialty ID
        /// </param>
        /// <returns>
        /// The <see cref="ClinicSpecialty"/> instance.
        /// </returns>
        public ClinicSpecialty GetClinicSpecialty(int id)
        {
            if (id == default(int))
            {
                throw new ThisIsAnIssueException("ClinicSpecialtyID is not valid.");
            }

            return new CustomRepository(this.unitOfWork).GetClinicSpecialty(id);
        }

        /// <summary>
        /// Gets the specialties of all clinics.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="ClinicSpecialty"/> instances.
        /// </returns>
        public List<ClinicSpecialty> GetClinicSpecialties()
        {
            return new CustomRepository(this.unitOfWork).GetClinicSpecialties();
        }

        /// <summary>
        /// Gets a filtered list of specialties based on a clinic code.
        /// </summary>
        /// <param name="clinicCode">
        /// The clinic code.
        /// </param>
        /// <returns>
        /// A list of specialties related to the clinic code.
        /// </returns>
        public List<ClinicSpecialty> GetFilteredClinicSpecialties(string clinicCode)
        {
            return new CustomRepository(this.unitOfWork).GetFilteredClinicSpecialties(clinicCode);
        }

        /// <summary>
        /// Gets the filtered appointments.
        /// </summary>
        /// <param name="filterColumn">
        /// The filter column
        /// </param>
        /// <param name="searchTerm">
        /// The search term.
        /// </param>
        /// <returns>
        /// A list of filtered <see cref="Appointment"/> instances.
        /// </returns>
        public List<Appointment> GetFilteredAppointments(string filterColumn, string searchTerm)
        {
            return new CustomRepository(this.unitOfWork).GetFilteredAppointments(filterColumn, searchTerm);
        }
    }
}
