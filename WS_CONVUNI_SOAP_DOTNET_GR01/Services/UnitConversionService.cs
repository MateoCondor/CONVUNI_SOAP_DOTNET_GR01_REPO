using WS_CONVUNI_SOAP_DOTNET_GR01.Enums;
using WS_CONVUNI_SOAP_DOTNET_GR01.Interfaces;
using WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Services;

public class UnitConversionService : IUnitConversionService
{
    private readonly IUnitConverter<MassUnit> _massConverter;
    private readonly IUnitConverter<LengthUnit> _lengthConverter;
    private readonly IUnitConverter<TemperatureUnit> _temperatureConverter;

    public UnitConversionService(
        IUnitConverter<MassUnit> massConverter,
        IUnitConverter<LengthUnit> lengthConverter,
        IUnitConverter<TemperatureUnit> temperatureConverter)
    {
        _massConverter = massConverter;
        _lengthConverter = lengthConverter;
        _temperatureConverter = temperatureConverter;
    }

    private static UnitConversionResponse Convert<T>(T from, T to, double value, IUnitConverter<T> converter) where T : struct
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

        return new UnitConversionResponse()
        {
            Message = message,
            Result = Math.Round(result, 8)
        };
    }

    public UnitConversionResponse ConvertLength(LengthRequest dto)
    {
        return Convert(dto.From, dto.To, dto.Value, _lengthConverter);
    }

    public UnitConversionResponse ConvertMass(MassRequest dto)
    {
        return Convert(dto.From, dto.To, dto.Value, _massConverter);
    }

    public UnitConversionResponse ConvertTemperature(TemperatureRequest dto)
    {
        return Convert(dto.From, dto.To, dto.Value, _temperatureConverter);
    }
}