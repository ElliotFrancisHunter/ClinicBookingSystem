// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentClassMap.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   Appointment class map. Maps this class to the corresponding database table.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DomainMappings
{
    using FluentNHibernate.Mapping;
    using SampleDomain;

    /// <summary>
    ///  Appointment class map. Maps this class to the corresponding database table.
    /// </summary>
    public class AppointmentClassMap : ClassMap<Appointment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentClassMap"/> class.
        /// </summary>
        public AppointmentClassMap()
        {
            this.Id(x => x.AppointmentId).Column("AppointmentID");
            this.Map(x => x.StartDateTime);
            this.Map(x => x.IsActive).Column("isActive");
            this.References(x => x.AppointmentType).Column("AppointmentTypeID").Not.LazyLoad().Cascade.None();
            this.References(x => x.Patient).Column("PatientID").Not.LazyLoad().Cascade.None();
            this.References(x => x.Duration).Column("DurationID").Not.LazyLoad().Cascade.None();
            this.References(x => x.Urgency).Column("UrgencyID").Not.LazyLoad().Cascade.None();
            this.References(x => x.Clinic).Column("ClinicID").Not.LazyLoad().Cascade.None();
            this.References(x => x.Specialty).Column("SpecialtyID").Not.LazyLoad().Cascade.None();
        }
    }
}
