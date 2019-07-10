

namespace SampleDomain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
