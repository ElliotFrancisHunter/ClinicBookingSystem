// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppointmentTypeDataContract.cs" company="Servelec">
//   Elliot Hunter
// </copyright>
// <summary>
//   The AppointmentType data contract.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SampleDataContracts.DomainDataContracts
{
    using System.Runtime.Serialization;

      /// <summary>
      /// The AppointmentType data contract.
      /// </summary>
      [DataContract]
    public class AppointmentTypeDataContract
    {
          /// <summary>
          /// Gets or sets the AppointmentTypeId.
          /// </summary>
          [DataMember]
          public virtual string AppointmentTypeId { get; set; }

          /// <summary>
          /// Gets or sets the TypeDescriptor.
          /// </summary>
          [DataMember]
          public virtual string TypeDescriptor { get; set; }
    }
}
