using CoreWCF;
using WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Interfaces;

[ServiceContract]
public interface IConversionService
{
    [OperationContract]
    ConversionResponse ConvertMass(MassRequest dto);

    [OperationContract]
    ConversionResponse ConvertLength(LengthRequest dto);

    [OperationContract]
    ConversionResponse ConvertTemperature(TemperatureRequest dto);
}