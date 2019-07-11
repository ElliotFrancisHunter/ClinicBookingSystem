// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpecialtyDataContract.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The Specialty data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The Specialty data contract.
    /// </summary>
    [DataContract]
    public class SpecialtyDataContract
    {
        /// <summary>
        /// Gets or sets the specialty Id
        /// </summary>
        [DataMember]
        public virtual string SpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the specialty code description
        /// </summary>
        [DataMember]
        public virtual string CodeDescription { get; set; }
    }
}
