using CoreWCF;
using WebServer.Models.Dto;

namespace WebServer.Interfaces;

[ServiceContract]
public interface IAuthService
{
    [OperationContract]
    LoginResponse Login(LoginRequest dto);
}