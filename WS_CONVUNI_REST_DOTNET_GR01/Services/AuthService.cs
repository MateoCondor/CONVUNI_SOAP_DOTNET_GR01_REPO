using WS_CONVUNI_REST_DOTNET_GR01.Dto;

namespace WS_CONVUNI_REST_DOTNET_GR01.Services;

public class AuthService
{
    private readonly ConnectedServices.Auth.AuthServiceClient authServiceClient;

    public AuthService(ConnectedServices.Auth.AuthServiceClient authServiceClient)
    {
        this.authServiceClient = authServiceClient;
    }

    public async Task<LoginResponse> Login(LoginRequest dto)
    {
        var clientDto = new ConnectedServices.Auth.LoginRequest()
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