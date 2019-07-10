
namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The AppointmentUrgency data contract.
    /// </summary>
    [DataContract]
    public class AppointmentUrgencyDataContract
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        [DataMember]
        public virtual string UrgencyId { get; set; }

        /// <summary>
        /// Gets or sets the UrgencyDescriptor.
        /// </summary>
        [DataMember]
        public virtual string UrgencyDescriptor { get; set; }
    }
}
