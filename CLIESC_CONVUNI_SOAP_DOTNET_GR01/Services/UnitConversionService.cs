using System.ServiceModel;
using CLIESC_CONVUNI_SOAP_DOTNET_GR01.Models;
using UnitConversionClient;

namespace CLIESC_CONVUNI_SOAP_DOTNET_GR01.Services;

public class UnitConversionService
{
    private readonly UnitConversionServiceClient _client;

    public UnitConversionService(UnitConversionServiceClient client)
    {
        _client = client;
    }

    public async Task<UnitConversionResult> ConvertMass(MassConversion conversion)
    {
        try
        {
            var dto = new MassRequest()
            {
                From = (MassUnit)conversion.From,
                To = (MassUnit)conversion.To,
                Value = conversion.Value,
            };

            var response = await _client.ConvertMassAsync(dto);
            return new UnitConversionResult()
            {
                Message = response.Message,
                Result = response.Result
            };
        }
        catch (FaultException ex)
        {
            throw new Exception($"Error en el servidor de conversión: {ex.Reason}");
        }
        catch (CommunicationException)
        {
            throw new Exception("No se pudo establecer comunicación con el servicio SOAP. Verifique su conexión.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inesperado: {ex.Message}");
        }
    }

    public async Task<UnitConversionResult> ConvertLength(LengthConversion conversion)
    {
        try
        {
            var dto = new LengthRequest()
            {
                From = (LengthUnit)conversion.From,
                To = (LengthUnit)conversion.To,
                Value = conversion.Value,
            };

            var response = await _client.ConvertLengthAsync(dto);
            return new UnitConversionResult()
            {
                Message = response.Message,
                Result = response.Result
            };
        }
        catch (FaultException ex)
        {
            throw new Exception($"Error en el servidor de conversión: {ex.Reason}");
        }
        catch (CommunicationException)
        {
            throw new Exception("No se pudo establecer comunicación con el servicio SOAP. Verifique su conexión.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inesperado: {ex.Message}");
        }
    }

    public async Task<UnitConversionResult> ConvertTemperature(TemperatureConversion conversion)
    {
        try
        {
            var dto = new TemperatureRequest()
            {
                From = (TemperatureUnit)conversion.From,
                To = (TemperatureUnit)conversion.To,
                Value = conversion.Value,
            };

            var response = await _client.ConvertTemperatureAsync(dto);
            return new UnitConversionResult()
            {
                Message = response.Message,
                Result = response.Result
            };
        }
        catch (FaultException ex)
        {
            throw new Exception($"Error en el servidor de conversión: {ex.Reason}");
        }
        catch (CommunicationException)
        {
            throw new Exception("No se pudo establecer comunicación con el servicio SOAP. Verifique su conexión.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inesperado: {ex.Message}");
        }
    }
}