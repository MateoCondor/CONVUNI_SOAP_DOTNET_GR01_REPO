using System.Runtime.Serialization;

namespace Server.Enums;

[DataContract]
public enum MassUnit
{
    [EnumMember(Value = "mg")] Milligrams,
    [EnumMember(Value = "g")] Grams,
    [EnumMember(Value = "kg")] Kilograms,
    [EnumMember(Value = "lb")] Pounds,
    [EnumMember(Value = "oz")] Ounces,
}