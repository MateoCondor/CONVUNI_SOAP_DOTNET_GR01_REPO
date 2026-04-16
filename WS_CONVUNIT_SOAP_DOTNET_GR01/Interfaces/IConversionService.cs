using CoreWCF;
using WebServer.Models.Dto;

namespace WebServer.Interfaces;

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