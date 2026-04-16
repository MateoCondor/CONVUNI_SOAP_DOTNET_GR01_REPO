using System.Runtime.Serialization;

namespace Server.Enums;

[DataContract]
public enum TemperatureUnit
{
    [EnumMember(Value = "C")] Celsius,
    [EnumMember(Value = "F")] Farenheit,
    [EnumMember(Value = "K")] Kelvin,
    [EnumMember(Value = "Ra")] Rankine,
    [EnumMember(Value = "Re")] Reaumur,
}