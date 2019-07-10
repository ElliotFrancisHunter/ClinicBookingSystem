// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SampleService.svc.cs" company="Servelec">
//   Elliot Hunter 2019
// </copyright>
// <summary>
//   The sample service.
//   NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleService" in code, svc and config file together.
//   NOTE: In order to launch WCF Test Client for testing this service, please select SampleService.svc or SampleService.svc.cs at the Solution Explorer and start debugging.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleService
{
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using Core;
    using SampleBusiness;
    using SampleDataContracts.DomainDataContracts;
    using SampleDataContracts.FaultDataContracts;

    using SampleDomain;

    /// <summary>
    /// The sample service.
    /// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleService" in code, svc and config file together.
    /// NOTE: In order to launch WCF Test Client for testing this service, please select SampleService.svc or SampleService.svc.cs at the Solution Explorer and start debugging.
    /// </summary>
    public class SampleService : ISampleService
    {
        /// <summary>
        /// The logger.
        /// </summary>
        private readonly Logger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleService"/> class.
        /// </summary>
        public SampleService()
        {
            this.logger = new Logger();
        }

        /// <summary>
        /// Sets a new appointment.
        /// </summary>
        /// <returns>
        /// The new appointment.
        /// </returns>
        public AppointmentDataContract SetAppointment()
        {
            this.logger.Log("BEGIN - SetAppointment");

            Appointment domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                domainObject = new BusinessHandler(unitOfWork).SetAppointment();
                unitOfWork.Close();
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
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
        public AppointmentDataContract GetAppointment(int id)
        {
            this.logger.Log("BEGIN - GetAppointment");

            Appointment domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetAppointment(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidAppointmentIdFault>(new InvalidAppointmentIdFault
                    {
                        Result = false,
                        Message = e.Message,
                        Description = "Appointment not found."
                    });
                }
                finally
                {
                    unitOfWork.Close();
                }
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Get a list of all appointment instances.
        /// </summary>
        /// <returns>
        /// The list of <see cref="Appointment"/> instances.
        /// </returns>
        public List<AppointmentDataContract> GetAppointments()
        {
            this.logger.Log("BEGIN - GetAppointments");

            List<Appointment> appointments;

            using (var unitOfWork = new UnitOfWork())
            {
                appointments = new BusinessHandler(unitOfWork).GetAppointments();
                unitOfWork.Close();
            }

            return appointments.Select(this.MapToDataContract).ToList();
        }

        /// <summary>
        /// Gets the appointment data.
        /// </summary>
        /// <param name="id">
        /// The id
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentDurationDataContract"/>.
        /// </returns>
        public AppointmentDurationDataContract GetAppointmentDurationData(string id)
        {
            this.logger.Log("BEGIN - GetAppointmentData");

            AppointmentDuration domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetAppointmentDurationId(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidDurationFault>(new InvalidDurationFault
                        {
                            Result = false,
                            Message = e.Message,
                            Description = "Appointment duration not found."  
                        });
                }
                finally
                {
                    unitOfWork.Close();
                }
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }
      
        /// <summary>
        /// Gets all the appointment duration data.
        /// </summary>
        /// <returns>
        /// The list of <see cref="AppointmentDurationDataContract"/>.
        /// </returns>
        public List<AppointmentDurationDataContract> GetAllAppointmentDurationData()
        {
            this.logger.Log("BEGIN - GetAllAppointmentDurationData");
            List<AppointmentDuration> durationObjects;
            using (var unitOfWork = new UnitOfWork())
            {
                durationObjects = new BusinessHandler(unitOfWork).GetAllAppointmentDurations();
                unitOfWork.Close();
            }

            return durationObjects.Select(this.MapToDataContract).ToList();
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
        public AppointmentTypeDataContract GetAppointmentTypeId(string id)
        {
            this.logger.Log("BEGIN - GetAppointmentTypeId");

            AppointmentType domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetAppointmentTypeId(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidAppointmentTypeFault>(new InvalidAppointmentTypeFault
                    {
                        Result = false,
                        Message = e.Message,
                        Description = "Appointment type not found."
                    });
                }
                finally
                {
                    unitOfWork.Close();
                }
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Get all appointment types.
        /// </summary>
        /// <returns> 
        /// The list of <see cref="AppointmentType"/>
        /// </returns>
        public List<AppointmentTypeDataContract> GetAppointmentTypes()
        {
            this.logger.Log("BEGIN - GetAppointmentTypes");
            List<AppointmentType> typeObjects;

            using (var unitOfWork = new UnitOfWork())
            {
                typeObjects = new BusinessHandler(unitOfWork).GetAppointmentTypes();
                unitOfWork.Close();
            }

            return typeObjects.Select(this.MapToDataContract).ToList();
        }

        /// <summary>
        /// Get the clinic data object and provide a data contract to front end.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="ClinicDataContract"/>
        /// </returns>
        public ClinicDataContract GetClinicId(string id)
        {
            this.logger.Log("BEGIN - GetClinicId");

            Clinic domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetClinicId(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidClinicFault>(
                        new InvalidClinicFault
                            {
                                Result = false,
                                Message = e.Message,
                                Description = "Clinic not found."
                            });
                }
                finally
                {
                    unitOfWork.Close();
                }   
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Gets every Clinic data object and provides a data contract for each in turn.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="ClinicDataContract"/> instances.
        /// </returns>
        public List<ClinicDataContract> GetClinics()
        {
            this.logger.Log("BEGIN - GetClinics");
            List<Clinic> clinicObjects;

            using (var unitOfWork = new UnitOfWork())
            {
                clinicObjects = new BusinessHandler(unitOfWork).GetClinics();
                unitOfWork.Close();
            }

            return clinicObjects.Select(this.MapToDataContract).ToList();
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
        public AppointmentUrgencyDataContract GetUrgency(string id)
        {
            this.logger.Log("BEGIN - GetUrgency");

            AppointmentUrgency domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetUrgency(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidUrgencyFaultDataContract>(
                        new InvalidUrgencyFaultDataContract
                            {
                                Result = false,
                                Message = e.Message,
                                Description = "Appointment urgency not found."
                            });
                }
                finally
                {
                    unitOfWork.Close();
                }
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Gets all appointment urgencies.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="AppointmentUrgency"/> instances.
        /// </returns>
        public List<AppointmentUrgencyDataContract> GetUrgencies()
        {
            this.logger.Log("BEGIN - GetUrgencies");
            List<AppointmentUrgency> urgencies;

            using (var unitOfWork = new UnitOfWork())
            {
                urgencies = new BusinessHandler(unitOfWork).GetUrgencies();
                unitOfWork.Close();
            }

            return urgencies.Select(this.MapToDataContract).ToList();
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
        public PatientDataContract GetPatient(string id)
        {
            this.logger.Log("BEGIN - GetPatient");
            Patient domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetPatient(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidPatientFault>(
                        new InvalidPatientFault
                            {
                                Result = false,
                                Message = e.Message,
                                Description = "Patient not found."
                            });
                }
                finally
                {
                    unitOfWork.Close();
                }         
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Gets all patients in the database.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Patient"/> instances.
        /// </returns>
        public List<PatientDataContract> GetPatients()
        {
            this.logger.Log("BEGIN - GetPatients");
            List<Patient> patients;

            using (var unitOfWork = new UnitOfWork())
            {
                patients = new BusinessHandler(unitOfWork).GetPatients();
                unitOfWork.Close();
            }

            return patients.Select(this.MapToDataContract).ToList();
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
        public SpecialtyDataContract GetSpecialty(string id)
        {
           this.logger.Log("BEGIN - GetSpecialty");
           Specialty domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetSpecialty(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidSpecialtyFault>(new InvalidSpecialtyFault
                    {
                        Result = false,
                        Message = e.Message,
                        Description = "Specialty not found."
                    });
                }
                finally
                {
                     unitOfWork.Close();
                }
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Gets all listed specialties.
        /// </summary>
        /// <returns>
        /// The list of all <see cref="Specialty"/> instances.
        /// </returns>
        public List<SpecialtyDataContract> GetSpecialties()
        {
            this.logger.Log("BEGIN - GetSpecialties");
            List<Specialty> specialties;

            using (var unitOfWork = new UnitOfWork())
            {
                specialties = new BusinessHandler(unitOfWork).GetSpecialties();
                unitOfWork.Close();
            }

            return specialties.Select(this.MapToDataContract).ToList();
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
        public ClinicSpecialtyDataContract GetClinicSpecialty(int id)
        {
            this.logger.Log("BEGIN - GetClinicSpecialty");
            ClinicSpecialty domainObject;

            using (var unitOfWork = new UnitOfWork())
            {
                try
                {
                    domainObject = new BusinessHandler(unitOfWork).GetClinicSpecialty(id);
                }
                catch (ThisIsAnIssueException e)
                {
                    throw new FaultException<InvalidClinicSpecialtyFault>(new InvalidClinicSpecialtyFault
                    {
                        Result = false,
                        Message = e.Message,
                        Description = "Clinic Specialty not found."
                    });
                }
                finally
                {
                  unitOfWork.Close();  
                } 
            }

            var mappedContract = this.MapToDataContract(domainObject);
            return mappedContract;
        }

        /// <summary>
        /// Gets the specialties of all clinics.
        /// </summary>
        /// <returns>
        /// A list of all <see cref="ClinicSpecialty"/> instances.
        /// </returns>
        public List<ClinicSpecialtyDataContract> GetClinicSpecialties()
        {
         this.logger.Log("BEGIN - GetClinicSpecialties");
            List<ClinicSpecialty> clinicSpecialties;

            using (var unitOfWork = new UnitOfWork())
            {
                clinicSpecialties = new BusinessHandler(unitOfWork).GetClinicSpecialties();
                unitOfWork.Close();
            }

            return clinicSpecialties.Select(this.MapToDataContract).ToList();
        }

        /// <summary>
        /// Maps the domain object to the data contract.
        /// </summary>
        /// <param name="domainObject">
        /// The domain object.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentDataContract"/>
        /// </returns>
        private AppointmentDataContract MapToDataContract(Appointment domainObject)
        {
            return new AppointmentDataContract
                       {
                           AppointmentId = domainObject.AppointmentId,
                           StartDateTime = domainObject.StartDateTime,
                           IsActive = domainObject.IsActive,
                           AppointmentType = domainObject.AppointmentType,
                           Patient = domainObject.Patient,
                           Duration = domainObject.Duration,
                           Urgency = domainObject.Urgency,
                           Clinic = domainObject.Clinic,
                           Specialty = domainObject.Specialty
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract
        /// </summary>
        /// <param name="domainObject">
        /// The domain object.
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentDurationDataContract"/>
        /// </returns>
        private AppointmentDurationDataContract MapToDataContract(AppointmentDuration domainObject)
        {
            return new AppointmentDurationDataContract
                       {
                           DurationId = domainObject.DurationId,
                           AppointmentLength = domainObject.AppointmentLength.ToString()
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract.
        /// </summary>
        /// <param name="domainObject">
        /// The domain object
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentTypeDataContract"/>
        /// </returns>
        private AppointmentTypeDataContract MapToDataContract(AppointmentType domainObject)
        {
            return new AppointmentTypeDataContract
                       {
                           AppointmentTypeId = domainObject.AppointmentTypeId,
                           TypeDescriptor = domainObject.TypeDescriptor
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract.
        /// </summary>
        /// <param name="domainObject">
        /// The domain object
        /// </param>
        /// <returns>
        /// The <see cref="AppointmentUrgencyDataContract"/>
        /// </returns>
        private AppointmentUrgencyDataContract MapToDataContract(AppointmentUrgency domainObject)
        {
            return new AppointmentUrgencyDataContract
                       {
                           UrgencyId = domainObject.UrgencyId,
                           UrgencyDescriptor = domainObject.UrgencyDescriptor
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract
        /// </summary>
        /// <param name="domainObject">
        /// The domain object.
        /// </param>
        /// <returns>
        /// The <see cref="ClinicDataContract"/>
        /// </returns>
        private ClinicDataContract MapToDataContract(Clinic domainObject)
        {
            return new ClinicDataContract
                       {
                           ClinicId = domainObject.ClinicId,
                           CodeDescription = domainObject.CodeDescription
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract
        /// </summary>
        /// <param name="domainObject">
        /// The domain object.
        /// </param>
        /// <returns>
        /// The <see cref="PatientDataContract"/>
        /// </returns>
        private PatientDataContract MapToDataContract(Patient domainObject)
        {
            return new PatientDataContract
                       {
                           PatientId = domainObject.PatientId,
                           FirstName = domainObject.FirstName,
                           Surname = domainObject.Surname
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract.
        /// </summary>
        /// <param name="domainObject">
        /// The domain object.
        /// </param>
        /// <returns>
        /// The <see cref="SpecialtyDataContract"/>.
        /// </returns>
        private SpecialtyDataContract MapToDataContract(Specialty domainObject)
        {
            return new SpecialtyDataContract
                       {
                           SpecialtyId = domainObject.SpecialtyId,
                           CodeDescription = domainObject.CodeDescription
                       };
        }

        /// <summary>
        /// Maps the domain object to the data contract.
        /// </summary>
        /// <param name="domainobject">
        /// The domain object
        /// </param>
        /// <returns>
        /// The <see cref="ClinicSpecialtyDataContract"/>.
        /// </returns>
        private ClinicSpecialtyDataContract MapToDataContract(ClinicSpecialty domainobject)
        {
            return new ClinicSpecialtyDataContract
                       {
                           ClinicSpecialtyId = domainobject.ClinicSpecialtyId,
                           Clinic = domainobject.Clinic,
                           Specialty = domainobject.Specialty
                       };
        }
    }
}
