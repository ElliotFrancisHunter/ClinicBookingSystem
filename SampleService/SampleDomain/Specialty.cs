// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Specialty.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="Specialty" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Specialty"/> class.
    /// </summary>
    public class Specialty
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        public virtual string SpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the CodeDescription.
        /// </summary>
        public virtual string CodeDescription { get; set; }
    }
}
