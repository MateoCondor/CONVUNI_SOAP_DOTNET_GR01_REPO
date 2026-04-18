using CoreWCF;
using CoreWCF.Configuration;
using WS_CONVUNI_SOAP_DOTNET_GR01.Enums;
using WS_CONVUNI_SOAP_DOTNET_GR01.Interfaces;
using WS_CONVUNI_SOAP_DOTNET_GR01.Models;
using WS_CONVUNI_SOAP_DOTNET_GR01.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IUnitConverter<MassUnit>, MassConverter>();
builder.Services.AddSingleton<IUnitConverter<LengthUnit>, LengthConverter>();
builder.Services.AddSingleton<IUnitConverter<TemperatureUnit>, TemperatureConverter>();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();

builder.Services.AddSingleton<UnitConversionService>();
builder.Services.AddSingleton<AuthService>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<UnitConversionService>();
    serviceBuilder.AddServiceEndpoint<UnitConversionService, IUnitConversionService>(new BasicHttpBinding(), "/UnitConversion");

    serviceBuilder.AddService<AuthService>();
    serviceBuilder.AddServiceEndpoint<AuthService, IAuthService>(new BasicHttpBinding(), "/Auth");

    var serviceMetadataBehavior = app.Services.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpGetEnabled = true;
});

app.Run();