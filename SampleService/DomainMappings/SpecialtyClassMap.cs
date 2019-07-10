
namespace DomainMappings
{
    using FluentNHibernate.Mapping;

    using SampleDomain;

    /// <summary>
    /// SpecialtyType class map. Maps this class to the corresponding database table. 
    /// </summary>
    public class SpecialtyClassMap : ClassMap<Specialty>
    {
        /// <summary>
        ///  Initializes a new instance of the <see cref="SpecialtyClassMap"/> class.
        /// </summary>
       public SpecialtyClassMap()
        {
            this.Id(x => x.SpecialtyId).Column("SpecialtyID");
            this.Map(x => x.CodeDescription);
        }
    }
}
