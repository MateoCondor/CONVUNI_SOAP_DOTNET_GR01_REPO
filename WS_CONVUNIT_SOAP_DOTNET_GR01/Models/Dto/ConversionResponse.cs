using System.Runtime.Serialization;

namespace WebServer.Models.Dto;

[DataContract]
public class ConversionResponse
{
    [DataMember]
    public double Result { get; set; }

    [DataMember]
    public required string Message { get; set; }
}