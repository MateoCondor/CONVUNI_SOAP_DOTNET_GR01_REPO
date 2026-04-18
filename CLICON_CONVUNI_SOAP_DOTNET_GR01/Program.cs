using AuthClient;
using CLICON_CONVUNI_SOAP_DOTNET_GR01.Services;
using CLICON_CONVUNI_SOAP_DOTNET_GR01.Views;
using CLICON_CONVUNI_SOAP_DOTNET_GR01.Controllers;
using UnitConversionClient;

// 1. Configurar el Cliente SOAP (Generado automáticamente)
var authClient = new AuthServiceClient();

// 2. Instanciar capas
var authService = new AuthService(authClient);
var loginView = new LoginView();

// 3. Inyectar en el Controlador
var authController = new AuthController(authService, loginView);

// 4. Iniciar sesion
var user = await authController.RunLogin();

if (user.IsAuth)
{
    // 5. Instanciar el nuevo servicio SOAP (UnitConversionServiceClient es de tu Reference.cs)
    var unitConversionClient = new UnitConversionServiceClient();
    var unitConversionService = new UnitConversionService(unitConversionClient);

    // 6. Instanciar Vista y Controlador
    var unitConversionView = new UnitConversionView();
    var unitConversionController = new UnitConversionController(unitConversionService, unitConversionView);

    // 7. Iniciar el flujo de conversiones
    await unitConversionController.Run();
}