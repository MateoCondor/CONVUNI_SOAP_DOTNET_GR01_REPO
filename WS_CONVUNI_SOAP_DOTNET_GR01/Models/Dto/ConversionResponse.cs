using System.Runtime.Serialization;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

[DataContract]
public class ConversionResponse
{
    [DataMember]
    public double Result { get; set; }

    [DataMember]
    public required string Message { get; set; }
}