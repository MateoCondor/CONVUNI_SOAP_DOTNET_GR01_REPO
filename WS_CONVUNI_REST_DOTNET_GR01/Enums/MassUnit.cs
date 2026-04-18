namespace WS_CONVUNI_REST_DOTNET_GR01.Enums;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MassUnit
{
    mg,
    g,
    kg,
    lb,
    oz,
    t
}