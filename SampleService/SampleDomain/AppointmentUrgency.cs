

namespace SampleDomain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
