using WebServer.Interfaces;
using WebServer.Models.Dto;

namespace WebServer.Services;

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