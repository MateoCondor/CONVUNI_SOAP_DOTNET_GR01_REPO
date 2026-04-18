
using WS_CONVUNI_REST_DOTNET_GR01.Dto;

namespace WS_CONVUNI_REST_DOTNET_GR01.Services;

public class ConversionService
{
    private readonly ConversionClient.ConversionServiceClient conversionServiceClient;

    public ConversionService(ConversionClient.ConversionServiceClient conversionServiceClient)
    {
        this.conversionServiceClient = conversionServiceClient;
    }

    public async Task<ConversionResponse> ConvertMass(MassRequest dto)
    {
        var clientDto = new ConversionClient.MassRequest()
        {
            From = (ConversionClient.MassUnit)dto.From,
            To = (ConversionClient.MassUnit)dto.To,
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
        var clientDto = new ConversionClient.LengthRequest()
        {
            From = (ConversionClient.LengthUnit)dto.From,
            To = (ConversionClient.LengthUnit)dto.To,
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
        var clientDto = new ConversionClient.TemperatureRequest()
        {
            From = (ConversionClient.TemperatureUnit)dto.From,
            To = (ConversionClient.TemperatureUnit)dto.To,
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