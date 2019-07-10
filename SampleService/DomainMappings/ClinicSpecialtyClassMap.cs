// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClinicSpecialtyClassMap.cs" company="Servelec">
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
    /// Appointment class map. Maps this class to the corresponding database table.
    /// </summary>
    public class ClinicSpecialtyClassMap : ClassMap<ClinicSpecialty>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClinicSpecialtyClassMap"/> class.
        /// </summary>
        public ClinicSpecialtyClassMap()
        {
            this.Id(x => x.ClinicSpecialtyId).Column("ClinicSpecialtyID");
            this.References(x => x.Clinic).Column("ClinicID").Not.LazyLoad();
            this.References(x => x.Specialty).Column("SpecialtyID").Not.LazyLoad();
        }
    }
}
