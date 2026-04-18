using CoreWCF;
using WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Interfaces;

[ServiceContract]
public interface IAuthService
{
    [OperationContract]
    LoginResponse Login(LoginRequest dto);
}