using WS_CONVUNI_REST_DOTNET_GR01.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddScoped<UnitConversionClient.UnitConversionServiceClient>();
builder.Services.AddScoped<UnitConversionService>();

builder.Services.AddScoped<AuthClient.AuthServiceClient>();
builder.Services.AddScoped<AuthService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
