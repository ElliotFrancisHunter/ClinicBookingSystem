// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Clinic.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="Clinic" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Clinic"/> class.
    /// </summary>
   public class Clinic
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        public virtual string ClinicId { get; set; }

        /// <summary>
        /// Gets or sets the CodeDescription.
        /// </summary>
        public virtual string CodeDescription { get; set; }
    }
}
