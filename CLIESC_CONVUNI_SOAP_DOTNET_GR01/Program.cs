using AuthClient;
using CLIESC_CONVUNI_SOAP_DOTNET_GR01.Controllers;
using CLIESC_CONVUNI_SOAP_DOTNET_GR01.Services;
using CLIESC_CONVUNI_SOAP_DOTNET_GR01.Views;

namespace CLIESC_CONVUNI_SOAP_DOTNET_GR01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var authClient = new AuthServiceClient();
            var authService = new AuthService(authClient);
            var loginView = new LoginView();
            var authController = new AuthController(loginView, authService);

            Application.Run(loginView);
        }
    }
}