using System.Runtime.Serialization;

namespace Server.Enums;

[DataContract]
public enum LengthUnit
{
    [EnumMember(Value = "mm")] Millimeters,
    [EnumMember(Value = "cm")] Centimeters,
    [EnumMember(Value = "m")] Meters,
    [EnumMember(Value = "km")] Kilometers,
    [EnumMember(Value = "ft")] Feet
}