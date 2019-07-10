// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvalidPatientFault.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The InvalidPatientFault data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.FaultDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The InvalidPatientFault data contract.
    /// </summary>
    [DataContract]
    public class InvalidPatientFault
    {
        /// <summary>
        /// Gets or sets a value indicating whether there is a result.
        /// </summary>
        [DataMember]
        public bool Result { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
