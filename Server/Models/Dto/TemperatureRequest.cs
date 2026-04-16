using System.Runtime.Serialization;
using Server.Enums;

namespace Server.Models.Dto;

[DataContract]
public class TemperatureRequest
{

    [DataMember]
    public required TemperatureUnit From { get; set; }

    [DataMember]
    public required TemperatureUnit To { get; set; }

    [DataMember]
    public required double Value { get; set; }
}