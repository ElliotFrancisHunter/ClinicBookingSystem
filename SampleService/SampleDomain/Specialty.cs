
namespace SampleDomain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
