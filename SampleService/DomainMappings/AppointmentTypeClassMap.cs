// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentTypeClassMap.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   AppointmentType class map. Maps this class to the corresponding database table.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace DomainMappings
{
    using FluentNHibernate.Mapping;
    using SampleDomain;

    /// <summary>
    /// AppointmentType class map. Maps this class to the corresponding database table.
    /// </summary>
    public class AppointmentTypeClassMap : ClassMap<AppointmentType>
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="AppointmentTypeClassMap"/> class.
        /// </summary>
        public AppointmentTypeClassMap()
        {
            this.Id(x => x.AppointmentTypeId).Column("AppointmentTypeID");
            this.Map(x => x.TypeDescriptor);
        } 
    }
}
