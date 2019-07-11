// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PatientDataContract.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The Patient data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The Patient data contract.
    /// </summary>
    [DataContract]
    public class PatientDataContract
    {
        /// <summary>
        /// Gets or sets the id for the class.
        /// </summary>
        [DataMember]
        public virtual string PatientId { get; set; }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        [DataMember]
        public virtual string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Surname.
        /// </summary>
        [DataMember]
        public virtual string Surname { get; set; }
    }
}
