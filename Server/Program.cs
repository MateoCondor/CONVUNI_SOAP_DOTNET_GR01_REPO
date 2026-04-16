using CoreWCF;
using CoreWCF.Configuration;
using Server.Enums;
using Server.Interfaces;
using Server.Models;
using Server.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IUnitConverter<MassUnit>, MassConverter>();
builder.Services.AddSingleton<IUnitConverter<LengthUnit>, LengthConverter>();
builder.Services.AddSingleton<IUnitConverter<TemperatureUnit>, TemperatureConverter>();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();

builder.Services.AddSingleton<ConversionService>();
builder.Services.AddSingleton<AuthService>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<ConversionService>();
    serviceBuilder.AddServiceEndpoint<ConversionService, IConversionService>(new BasicHttpBinding(), "/UnitConversionService");

    serviceBuilder.AddService<AuthService>();
    serviceBuilder.AddServiceEndpoint<AuthService, IAuthService>(new BasicHttpBinding(), "/AuthService");

    var serviceMetadataBehavior = app.Services.GetRequiredService<CoreWCF.Description.ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpGetEnabled = true;
});

app.Run();