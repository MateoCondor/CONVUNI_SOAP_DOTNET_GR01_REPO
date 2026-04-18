using System.Text.Json.Serialization;

namespace WS_CONVUNI_REST_DOTNET_GR01.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TemperatureUnit
{
    C,
    F,
    K,
    Ra,
    Re,
}