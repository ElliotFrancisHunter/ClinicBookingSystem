
namespace SampleRepository
{
    using System.Collections.Generic;
    using System.Linq;

    using Core;

    using SampleDomain;

    /// <summary>
    /// The custom repository.
    /// </summary>
    public class CustomRepository : ICustomRepository
    {
        /// <summary>
        /// The unit of work.
        /// </summary>
        private readonly IUnitOfWork unitOfWork;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomRepository"/> class.
        /// </summary>
        /// <param name="unitOfWork">
        /// The unit of work.
        /// </param>
        public CustomRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
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
            return this.unitOfWork.Session.Get<Appointment>(id);
        }

        /// <summary>
        /// Get a list of all appointment instances.
        /// </summary>
        /// <returns>
        /// The list of <see cref="Appointment"/> instances.
        /// </returns>
        public List<Appointment> GetAppointments()
        {
            return this.unitOfWork.Session.Query<Appointment>().ToList();
        }

        /// <summary>
        /// Get the custom data.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The AppointmentDuration data object.
        /// </returns>
        public AppointmentDuration GetAppointmentDurationId(string id)
        {
            return this.unitOfWork.Session.Get<AppointmentDuration>(id);
        }

        /// <summary>
        /// Gets all appointment durations
        /// </summary>
        /// <returns>
        /// The list of <see cref="AppointmentDuration"/> as a data object.
        /// </returns>
        public List<AppointmentDuration> GetAllAppointmentDurations()
        {
            return this.unitOfWork.Session.Query<AppointmentDuration>().ToList();
        }

        /// <summary>
        /// Gets the appointment type id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The AppointmentType data object.
        /// </returns>
        public AppointmentType GetAppointmentTypeId(string id)
        {
            return this.unitOfWork.Session.Get<AppointmentType>(id);
        }

        /// <summary>
        /// Get all appointment types.
        /// </summary>
        /// <returns> 
        /// The list of <see cref="AppointmentType"/> as a data object.
        /// </returns>
        public List<AppointmentType> GetAppointmentTypes()
        {
            return this.unitOfWork.Session.Query<AppointmentType>().ToList();
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
            return this.unitOfWork.Session.Get<AppointmentUrgency>(id);
        }

        /// <summary>
        /// Gets all appointment urgencies.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="AppointmentUrgency"/> instances.
        /// </returns>
        public List<AppointmentUrgency> GetUrgencies()
        {
            return this.unitOfWork.Session.Query<AppointmentUrgency>().ToList();
        }

        /// <summary>
        /// Gets the clinic id.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="Clinic"/>.
        /// </returns>
        public Clinic GetClinicId(string id)
        {
            return this.unitOfWork.Session.Get<Clinic>(id);
        }

        /// <summary>
        /// Gets a list of all clinics.
        /// </summary>
        /// <returns>
        /// The list of <see cref="Clinic"/> instances.
        /// </returns>
        public List<Clinic> GetClinics()
        {
            return this.unitOfWork.Session.Query<Clinic>().ToList();
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
            return this.unitOfWork.Session.Get<Patient>(id);
        }

        /// <summary>
        /// Gets all patients in the database.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Patient"/> instances.
        /// </returns>
        public List<Patient> GetPatients()
        {
            return this.unitOfWork.Session.Query<Patient>().ToList();
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
            return this.unitOfWork.Session.Get<Specialty>(id);
        }

        /// <summary>
        /// Gets all listed specialties.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Specialty"/> instances.
        /// </returns>
        public List<Specialty> GetSpecialties()
        {
            return this.unitOfWork.Session.Query<Specialty>().ToList();
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
            return this.unitOfWork.Session.QueryOver<ClinicSpecialty>()
                .Where(x => x.ClinicSpecialtyId == id).SingleOrDefault();
        }

        /// <summary>
        /// Gets the specialties of all clinics.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="ClinicSpecialty"/> instances.
        /// </returns>
        public List<ClinicSpecialty> GetClinicSpecialties()
        {
            return this.unitOfWork.Session.Query<ClinicSpecialty>().ToList();
        } 
    }
}
