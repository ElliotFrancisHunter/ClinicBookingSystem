
namespace SampleDataContracts.DomainDataContracts
{
    using System;
    using System.Runtime.Serialization;

    using SampleDomain;

    /// <summary>
    /// The Appointment data contract.
    /// </summary>
    [DataContract]
    public class AppointmentDataContract
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        [DataMember]
        public virtual int AppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the StartDateTime.
        /// </summary>
        [DataMember]
        public virtual DateTime StartDateTime { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether a logical deletion has occurred. 
        /// </summary>
        [DataMember]
        public virtual bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the reference to AppointmentType to act as foreign key.
        /// </summary>
        [DataMember]
        public virtual AppointmentType AppointmentType { get; set; }

        /// <summary>
        /// Gets or sets the reference to Patient to act as foreign key.
        /// </summary>
        [DataMember]
        public virtual Patient Patient { get; set; }

        /// <summary>
        /// Gets or sets the reference to AppointmentDuration to act as foreign key.
        /// </summary>
        [DataMember]
        public virtual AppointmentDuration Duration { get; set; }

        /// <summary>
        /// Gets or sets the reference to AppointmentUrgency to act as foreign key.
        /// </summary>
        [DataMember]
        public virtual AppointmentUrgency Urgency { get; set; }

        /// <summary>
        /// Gets or sets the reference to Clinic to act as foreign key. 
        /// </summary>
        [DataMember]
        public virtual Clinic Clinic { get; set; }

        /// <summary>
        /// Gets or sets the reference to Specialty to act as foreign key.
        /// </summary>
        [DataMember]
        public virtual Specialty Specialty { get; set; }
    }
}
