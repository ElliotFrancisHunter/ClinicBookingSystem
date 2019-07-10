

namespace SampleDomain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

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
