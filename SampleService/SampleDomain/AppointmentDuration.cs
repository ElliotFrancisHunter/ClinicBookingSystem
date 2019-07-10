// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentDuration.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Initializes a new instance of the <see cref="AppointmentDuration" /> class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDomain
{
    using System;

    /// <summary>
    /// Initializes a new instance of the <see cref="AppointmentDuration"/> class.
    /// </summary>
    public class AppointmentDuration
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        public virtual string DurationId { get; set; }

        /// <summary>
        /// Gets or sets the AppointmentLength.
        /// </summary>
        public virtual TimeSpan AppointmentLength { get; set; }
    }
}
