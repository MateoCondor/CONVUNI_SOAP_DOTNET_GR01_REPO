using System.Runtime.Serialization;
using WS_CONVUNI_SOAP_DOTNET_GR01.Enums;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

[DataContract]
public class LengthRequest
{

    [DataMember]
    public required LengthUnit From { get; set; }

    [DataMember]
    public required LengthUnit To { get; set; }

    [DataMember]
    public required double Value { get; set; }
}