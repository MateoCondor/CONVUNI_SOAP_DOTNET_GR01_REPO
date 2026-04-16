using WebServer.Enums;
using WebServer.Interfaces;
using WebServer.Models.Dto;

namespace WebServer.Services;

public class ConversionService : IConversionService
{
    private readonly IUnitConverter<MassUnit> _massConverter;
    private readonly IUnitConverter<LengthUnit> _lengthConverter;
    private readonly IUnitConverter<TemperatureUnit> _temperatureConverter;

    public ConversionService(
        IUnitConverter<MassUnit> massConverter,
        IUnitConverter<LengthUnit> lengthConverter,
        IUnitConverter<TemperatureUnit> temperatureConverter)
    {
        _massConverter = massConverter;
        _lengthConverter = lengthConverter;
        _temperatureConverter = temperatureConverter;
    }

    private static ConversionResponse Convert<T>(T from, T to, double value, IUnitConverter<T> converter) where T : struct
    {
        string message = "OK";
        double result = 0;

        try
        {
            result = converter.Convert(from, to, value);
        }
        catch (Exception e)
        {
            message = e.Message;
        }

        return new ConversionResponse()
        {
            Message = message,
            Result = Math.Round(result, 8)
        };
    }

    public ConversionResponse ConvertLength(LengthRequest dto)
    {
        return Convert(dto.From, dto.To, dto.Value, _lengthConverter);
    }

    public ConversionResponse ConvertMass(MassRequest dto)
    {
        return Convert(dto.From, dto.To, dto.Value, _massConverter);
    }

    public ConversionResponse ConvertTemperature(TemperatureRequest dto)
    {
        return Convert(dto.From, dto.To, dto.Value, _temperatureConverter);
    }
}