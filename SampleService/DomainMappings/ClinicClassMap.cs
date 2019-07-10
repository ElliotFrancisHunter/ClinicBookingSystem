
namespace DomainMappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using FluentNHibernate.Mapping;

    using SampleDomain;

    /// <summary>
    /// Clinic class map. Maps this class to the corresponding database table.
    /// </summary>
    public class ClinicClassMap : ClassMap<Clinic>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClinicClassMap"/> class.
        /// </summary>
        public ClinicClassMap()
        {
            this.Id(x => x.ClinicId).Column("ClinicID");
            this.Map(x => x.CodeDescription);
        }
    }
}
