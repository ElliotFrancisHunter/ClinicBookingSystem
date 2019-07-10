// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Patient.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="Patient" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Patient"/> class.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        public virtual string PatientId { get; set; }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Surname.
        /// </summary>
        public virtual string Surname { get; set; }
    }
}
