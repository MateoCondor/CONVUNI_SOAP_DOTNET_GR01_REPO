using System.Runtime.Serialization;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

[DataContract]
public class LoginRequest
{
    [DataMember]
    public required string Username { get; set; }

    [DataMember]
    public required string Password { get; set; }
}