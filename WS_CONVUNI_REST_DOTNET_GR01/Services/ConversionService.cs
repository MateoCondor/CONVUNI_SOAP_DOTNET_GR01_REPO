
using WS_CONVUNI_REST_DOTNET_GR01.Dto;

namespace WS_CONVUNI_REST_DOTNET_GR01.Services;

public class ConversionService
{
    private readonly ConnectedServices.UnitConversion.ConversionServiceClient conversionServiceClient;

    public ConversionService(ConnectedServices.UnitConversion.ConversionServiceClient conversionServiceClient)
    {
        this.conversionServiceClient = conversionServiceClient;
    }

    public async Task<ConversionResponse> ConvertMass(MassRequest dto)
    {
        var clientDto = new ConnectedServices.UnitConversion.MassRequest()
        {
            From = (ConnectedServices.UnitConversion.MassUnit)dto.From,
            To = (ConnectedServices.UnitConversion.MassUnit)dto.To,
            Value = dto.Value
        };

        var response = await conversionServiceClient.ConvertMassAsync(clientDto);

        return new ConversionResponse()
        {
            Message = response.Message,
            Result = response.Result
        };
    }

    public async Task<ConversionResponse> ConvertLength(LengthRequest dto)
    {
        var clientDto = new ConnectedServices.UnitConversion.LengthRequest()
        {
            From = (ConnectedServices.UnitConversion.LengthUnit)dto.From,
            To = (ConnectedServices.UnitConversion.LengthUnit)dto.To,
            Value = dto.Value
        };

        var response = await conversionServiceClient.ConvertLengthAsync(clientDto);

        return new ConversionResponse()
        {
            Message = response.Message,
            Result = response.Result
        };
    }

    public async Task<ConversionResponse> ConvertTemperature(TemperatureRequest dto)
    {
        var clientDto = new ConnectedServices.UnitConversion.TemperatureRequest()
        {
            From = (ConnectedServices.UnitConversion.TemperatureUnit)dto.From,
            To = (ConnectedServices.UnitConversion.TemperatureUnit)dto.To,
            Value = dto.Value
        };

        var response = await conversionServiceClient.ConvertTemperatureAsync(clientDto);

        return new ConversionResponse()
        {
            Message = response.Message,
            Result = response.Result
        };
    }
}