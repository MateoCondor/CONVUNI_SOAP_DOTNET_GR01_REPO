using Microsoft.AspNetCore.Mvc;
using WS_CONVUNI_REST_DOTNET_GR01.Dto;
using WS_CONVUNI_REST_DOTNET_GR01.Services;

namespace WS_CONVUNI_REST_DOTNET_GR01.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _service;

    public AuthController(AuthService service)
    {
        _service = service;
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest dto)
    {
        var result = await _service.Login(dto);
        return Ok(result);
    }
}