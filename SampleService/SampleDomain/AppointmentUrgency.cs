// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentUrgency.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="AppointmentUrgency" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AppointmentUrgency"/> class.
    /// </summary>
    public class AppointmentUrgency
    {
        /// <summary>
        ///  Gets or sets id for this class
        /// </summary>
        public virtual string UrgencyId { get; set; }

        /// <summary>
        ///  Gets or sets the UrgencyDescriptor.
        /// </summary>
        public virtual string UrgencyDescriptor { get; set; }
    }
}
