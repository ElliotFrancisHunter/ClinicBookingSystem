// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentType.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="AppointmentType" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppointmentType"/> class.
    /// </summary>
    public class AppointmentType
    {
        /// <summary>
        /// Gets or sets the id for the class
        /// </summary>
        public virtual string AppointmentTypeId { get; set; }

        /// <summary>
        ///  Gets or sets the TypeDescriptor.
        /// </summary>
        public virtual string TypeDescriptor { get; set; }
    }
}
