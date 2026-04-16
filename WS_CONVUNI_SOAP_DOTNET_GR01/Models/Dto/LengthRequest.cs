using System.Runtime.Serialization;
using WebServer.Enums;

namespace WebServer.Models.Dto;

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