

namespace SampleDomain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
