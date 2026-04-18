using WS_CONVUNI_REST_DOTNET_GR01.Enums;

namespace WS_CONVUNI_REST_DOTNET_GR01.Dto;

public class MassRequest
{
    public MassUnit From { get; set; }
    public MassUnit To { get; set; }
    public double Value { get; set; }
}