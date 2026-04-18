using System.Text.Json.Serialization;

namespace WS_CONVUNI_REST_DOTNET_GR01.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LengthUnit
{
    mm,
    cm,
    m,
    km,
    ft,
    @in,
    yd,
    mi,
}