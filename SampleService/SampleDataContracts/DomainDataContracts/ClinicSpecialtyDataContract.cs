// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClinicSpecialtyDataContract.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The ClinicSpecialty data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

    using SampleDomain;

    /// <summary>
    /// The ClinicSpecialty data contract.
    /// </summary>
    [DataContract]
    public class ClinicSpecialtyDataContract
    {
        /// <summary>
        /// Gets or sets the ClinicSpecialty id.
        /// </summary>
        [DataMember]
        public virtual int ClinicSpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the reference to Clinic to act as a foreign key.
        /// </summary>
        [DataMember]
        public virtual Clinic Clinic { get; set; }

        /// <summary>
        /// Gets or sets the reference to Specialty to act as a foreign key.
        /// </summary>
        [DataMember]
        public virtual Specialty Specialty { get; set; }
    }
}
