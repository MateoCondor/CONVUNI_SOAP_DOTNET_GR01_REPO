using System.Runtime.Serialization;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

[DataContract]
public class LoginResponse
{
    [DataMember]
    public bool IsAuth { get; set; }

    [DataMember]
    public required string Message { get; set; }
}