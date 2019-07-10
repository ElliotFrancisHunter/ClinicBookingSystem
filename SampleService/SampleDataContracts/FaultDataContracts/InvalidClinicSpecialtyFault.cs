
namespace SampleDataContracts.FaultDataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The InvalidClinicSpecialtyFault data contract.
    /// </summary>
    [DataContract]
    public class InvalidClinicSpecialtyFault
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
