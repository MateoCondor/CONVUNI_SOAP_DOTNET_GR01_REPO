using System.Runtime.Serialization;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Enums;

[DataContract]
public enum LengthUnit
{
    [EnumMember(Value = "mm")] Millimeters,
    [EnumMember(Value = "cm")] Centimeters,
    [EnumMember(Value = "m")] Meters,
    [EnumMember(Value = "km")] Kilometers,
    [EnumMember(Value = "ft")] Feet,
    [EnumMember(Value = "in")] Inches,
    [EnumMember(Value = "yd")] Yards,
    [EnumMember(Value = "mi")] Miles,
}