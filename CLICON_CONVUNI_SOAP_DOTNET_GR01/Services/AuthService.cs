using System.ServiceModel;
using AuthClient;
using CLICON_CONVUNI_SOAP_DOTNET_GR01.Models;

namespace CLICON_CONVUNI_SOAP_DOTNET_GR01.Services;

public class AuthService
{
    private readonly AuthServiceClient _client;

    public AuthService(AuthServiceClient client)
    {
        _client = client;
    }

    public async Task<User> Login(string username, string password)
    {
        try
        {
            var dto = new LoginRequest()
            {
                Password = password,
                Username = username
            };

            var response = await _client.LoginAsync(dto);

            if (!response.IsAuth)
                throw new ArgumentException(response.Message);

            return new User()
            {
                Username = username,
                IsAuth = response.IsAuth
            };
        }
        catch (FaultException ex)
        {
            throw new Exception($"Error en el servidor de conversión: {ex.Reason}");
        }
        catch (CommunicationException)
        {
            throw new Exception("No se pudo establecer comunicación con el servicio SOAP. Verifique su conexión.");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error inesperado: {ex.Message}");
        }
    }
}