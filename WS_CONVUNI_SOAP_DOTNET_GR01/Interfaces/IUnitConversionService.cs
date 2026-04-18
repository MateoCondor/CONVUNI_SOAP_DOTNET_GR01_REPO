using CoreWCF;
using WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Interfaces;

[ServiceContract]
public interface IUnitConversionService
{
    [OperationContract]
    UnitConversionResponse ConvertMass(MassRequest dto);

    [OperationContract]
    UnitConversionResponse ConvertLength(LengthRequest dto);

    [OperationContract]
    UnitConversionResponse ConvertTemperature(TemperatureRequest dto);
}