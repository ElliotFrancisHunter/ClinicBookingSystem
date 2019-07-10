
namespace SampleDomain
{
    using System;

    /// <summary>
    /// Initializes a new instance of the <see cref="Appointment"/> class.
    /// </summary>
    public class Appointment
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        public virtual int AppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the StartDateTime.
        /// </summary>
        public virtual DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a logical deletion has occurred. 
        /// </summary>
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the reference to AppointmentType to act as foreign key.
        /// </summary>
        public virtual AppointmentType AppointmentType { get; set; }

        /// <summary>
        /// Gets or sets the reference to Patient to act as foreign key.
        /// </summary>
        public virtual Patient Patient { get; set; }

        /// <summary>
        /// Gets or sets the reference to AppointmentDuration to act as foreign key.
        /// </summary>
        public virtual AppointmentDuration Duration { get; set; }

        /// <summary>
        /// Gets or sets the reference to AppointmentUrgency to act as foreign key.
        /// </summary>
        public virtual AppointmentUrgency Urgency { get; set; }

        /// <summary>
        /// Gets or sets the reference to Clinic to act as foreign key. 
        /// </summary>
        public virtual Clinic Clinic { get; set; }

        /// <summary>
        /// Gets or sets the reference to Specialty to act as foreign key.
        /// </summary>
        public virtual Specialty Specialty { get; set; }

        ////public virtual void AddAppointment()
        ////{
            
        ////}

        ////public virtual void AddStartDateTime()
        ////{
            
        ////}

        ////public virtual void AddActiveStatus()
        ////{
            
        ////}

        ////public void AddAppointmentType()
        ////{
            
        ////}

        ////public void AddPatient()
        ////{
            
        ////}

        ////public void AddDuration()
        ////{
            
        ////}

        ////public void AddUrgency()
        ////{
            
        ////}

        ////public void AddClinic()
        ////{
            
        ////}

        ////public void AddSpecialty()
        ////{
            
        ////}
    }
}
