// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClinicDataContract.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The clinic data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The clinic data contract.
    /// </summary>
    [DataContract]
   public class ClinicDataContract
    {
        /// <summary>
        /// Gets or sets the ClinicId.
        /// </summary>
        [DataMember]
        public virtual string ClinicId { get; set; }

        /// <summary>
        /// Gets or sets the CodeDescription.
        /// </summary>
        [DataMember]
        public virtual string CodeDescription { get; set; }
    }
}
