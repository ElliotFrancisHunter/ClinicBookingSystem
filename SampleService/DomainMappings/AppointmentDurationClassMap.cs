// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentDurationClassMap.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   AppointmentDuration class map. Maps this class to the corresponding database table.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DomainMappings
{
    using FluentNHibernate.Mapping;
    using NHibernate.Type;
    using SampleDomain;

    /// <summary>
    /// AppointmentDuration class map. Maps this class to the corresponding database table.
    /// </summary>
    public class AppointmentDurationClassMap : ClassMap<AppointmentDuration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentDurationClassMap"/> class.
        /// </summary>
        public AppointmentDurationClassMap()
        {
            this.Id(x => x.DurationId).Column("DurationID");
            this.Map(x => x.AppointmentLength).CustomType(typeof(TimeAsTimeSpanType));
        }
    } 
}
