using System.Runtime.Serialization;
using Server.Enums;

namespace Server.Models.Dto;

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