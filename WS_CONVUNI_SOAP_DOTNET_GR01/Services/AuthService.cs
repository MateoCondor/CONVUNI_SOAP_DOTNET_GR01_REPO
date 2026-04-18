using WS_CONVUNI_SOAP_DOTNET_GR01.Interfaces;
using WS_CONVUNI_SOAP_DOTNET_GR01.Models.Dto;

namespace WS_CONVUNI_SOAP_DOTNET_GR01.Services;

public class AuthService : IAuthService
{
    private readonly string _username = "MONSTER";
    private readonly string _passoword = "MONSTER9";

    private bool VerifyCredentials(string username, string password)
    {
        return _username == username && _passoword == password;
    }

    public LoginResponse Login(LoginRequest dto)
    {
        var isAuth = VerifyCredentials(dto.Username, dto.Password);

        return new LoginResponse()
        {
            Message = isAuth ? "Credenciales correctas" : "Credenciales invalidas",
            IsAuth = isAuth
        };
    }
}