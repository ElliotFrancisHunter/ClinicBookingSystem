

namespace DomainMappings
{
    using FluentNHibernate.Mapping;

    using SampleDomain;

    /// <summary>
    /// Patient class map. Maps this class to the corresponding database table. 
    /// </summary>
    public class PatientClassMap : ClassMap<Patient>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientClassMap"/> class.
        /// </summary>
        /// 
        public PatientClassMap()
        {
            this.Id(x => x.PatientId).Column("PatientID");
            this.Map(x => x.FirstName);
            this.Map(x => x.Surname);
        }
    }
}
