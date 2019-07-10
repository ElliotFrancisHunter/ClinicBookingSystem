

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
    /// AppointmentUrgency class map. Maps this class to the corresponding database table.
    /// </summary>
    public class AppointmentUrgencyClassMap : ClassMap<AppointmentUrgency>
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="AppointmentUrgencyClassMap"/> class.
        /// </summary>
        public AppointmentUrgencyClassMap()
        {
            this.Id(x => x.UrgencyId).Column("UrgencyID");
            this.Map(x => x.UrgencyDescriptor);
        }
    }
}
