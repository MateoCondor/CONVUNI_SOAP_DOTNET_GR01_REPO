using System.Runtime.Serialization;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

[DataContract]
public class UnitConversionResponse
{
    [DataMember]
    public double Result { get; set; }

    [DataMember]
    public required string Message { get; set; }
}