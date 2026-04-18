using Microsoft.AspNetCore.Mvc;
using WS_CONVUNI_REST_DOTNET_GR01.Dto;
using WS_CONVUNI_REST_DOTNET_GR01.Services;

namespace WS_CONVUNI_REST_DOTNET_GR01.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService service;

    public AuthController(AuthService service)
    {
        this.service = service;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest dto)
    {
        var result = await service.Login(dto);
        return Ok(result);
    }
}