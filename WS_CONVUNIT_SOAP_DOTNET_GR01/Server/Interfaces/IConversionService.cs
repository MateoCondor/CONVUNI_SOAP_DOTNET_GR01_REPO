using CoreWCF;
using Server.Models.Dto;

namespace Server.Interfaces;

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