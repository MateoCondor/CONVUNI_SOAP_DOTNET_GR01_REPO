using System.Runtime.Serialization;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Enums;

[DataContract]
public enum MassUnit
{
    [EnumMember(Value = "mg")] Milligrams,
    [EnumMember(Value = "g")] Grams,
    [EnumMember(Value = "kg")] Kilograms,
    [EnumMember(Value = "lb")] Pounds,
    [EnumMember(Value = "oz")] Ounces,
    [EnumMember(Value = "t")] Tons
}