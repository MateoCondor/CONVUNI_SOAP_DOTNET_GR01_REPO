using WS_CONVUNI_REST_DOTNET_GR01.Dto;

namespace WS_CONVUNI_REST_DOTNET_GR01.Services;

public class AuthService
{
    private readonly AuthClient.AuthServiceClient authServiceClient;

    public AuthService(AuthClient.AuthServiceClient authServiceClient)
    {
        this.authServiceClient = authServiceClient;
    }

    public async Task<LoginResponse> Login(LoginRequest dto)
    {
        var clientDto = new AuthClient.LoginRequest()
        {
            Password = dto.Password,
            Username = dto.Username,
        };

        var response = await authServiceClient.LoginAsync(clientDto);

        return new LoginResponse()
        {
            IsAuth = response.IsAuth,
            Message = response.Message
        };
    }
}