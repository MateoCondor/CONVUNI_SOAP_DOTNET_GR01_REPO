using System.Runtime.Serialization;

namespace WebServer.Models.Dto;

[DataContract]
public class LoginRequest
{
    [DataMember]
    public required string Username { get; set; }

    [DataMember]
    public required string Password { get; set; }
}