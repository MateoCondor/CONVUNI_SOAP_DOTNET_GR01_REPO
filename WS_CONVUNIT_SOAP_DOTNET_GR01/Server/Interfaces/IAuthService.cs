using CoreWCF;
using Server.Models.Dto;

namespace Server.Interfaces;

[ServiceContract]
public interface IAuthService
{
    [OperationContract]
    LoginResponse Login(LoginRequest dto);
}