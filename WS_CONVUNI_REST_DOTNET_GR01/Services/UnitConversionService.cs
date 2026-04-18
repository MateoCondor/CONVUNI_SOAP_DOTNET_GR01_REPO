
using WS_CONVUNI_REST_DOTNET_GR01.Dto;

namespace WS_CONVUNI_REST_DOTNET_GR01.Services;

public class UnitConversionService
{
    private readonly UnitConversionClient.UnitConversionServiceClient _client;

    public UnitConversionService(UnitConversionClient.UnitConversionServiceClient conversionServiceClient)
    {
        _client = conversionServiceClient;
    }

    public async Task<UnitConversionResponse> ConvertMass(MassRequest dto)
    {
        var clientDto = new UnitConversionClient.MassRequest()
        {
            From = (UnitConversionClient.MassUnit)dto.From,
            To = (UnitConversionClient.MassUnit)dto.To,
            Value = dto.Value
        };

        var response = await _client.ConvertMassAsync(clientDto);

        return new UnitConversionResponse()
        {
            Message = response.Message,
            Result = response.Result
        };
    }

    public async Task<UnitConversionResponse> ConvertLength(LengthRequest dto)
    {
        var clientDto = new UnitConversionClient.LengthRequest()
        {
            From = (UnitConversionClient.LengthUnit)dto.From,
            To = (UnitConversionClient.LengthUnit)dto.To,
            Value = dto.Value
        };

        var response = await _client.ConvertLengthAsync(clientDto);

        return new UnitConversionResponse()
        {
            Message = response.Message,
            Result = response.Result
        };
    }

    public async Task<UnitConversionResponse> ConvertTemperature(TemperatureRequest dto)
    {
        var clientDto = new UnitConversionClient.TemperatureRequest()
        {
            From = (UnitConversionClient.TemperatureUnit)dto.From,
            To = (UnitConversionClient.TemperatureUnit)dto.To,
            Value = dto.Value
        };

        var response = await _client.ConvertTemperatureAsync(clientDto);

        return new UnitConversionResponse()
        {
            Message = response.Message,
            Result = response.Result
        };
    }
}