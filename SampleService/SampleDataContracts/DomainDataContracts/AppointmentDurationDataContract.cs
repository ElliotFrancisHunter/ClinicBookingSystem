// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentDurationDataContract.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The AppointmentDuration data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The AppointmentDuration data contract.
    /// </summary>
    public class AppointmentDurationDataContract
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        [DataMember]
        public virtual string DurationId { get; set; }

        /// <summary>
        /// Gets or sets the AppointmentLength.
        /// </summary>
        [DataMember]
        public virtual string AppointmentLength { get; set; }
    }
}
