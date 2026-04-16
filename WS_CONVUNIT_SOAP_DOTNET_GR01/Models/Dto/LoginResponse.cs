using System.Runtime.Serialization;

namespace WebServer.Models.Dto;

[DataContract]
public class LoginResponse
{
    [DataMember]
    public bool IsAuth { get; set; }

    [DataMember]
    public required string Message { get; set; }
}