using System.Runtime.Serialization;
using WS_CONVUNI_SOAP_DOTNET_GR01.Enums;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

[DataContract]
public class MassRequest
{

    [DataMember]
    public required MassUnit From { get; set; }

    [DataMember]
    public required MassUnit To { get; set; }

    [DataMember]
    public required double Value { get; set; }
}