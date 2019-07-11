// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClinicSpecialty.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="ClinicSpecialty" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClinicSpecialty"/> class.
    /// </summary>
    public class ClinicSpecialty
    {
        /// <summary>
        /// Gets or sets the ClinicSpecialty id.
        /// </summary>
        public virtual int ClinicSpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the reference to Clinic to act as a foreign key.
        /// </summary>
        public virtual Clinic Clinic { get; set; }

        /// <summary>
        /// Gets or sets the reference to Specialty to act as a foreign key.
        /// </summary>
        public virtual Specialty Specialty { get; set; }
    }
}
