namespace WS_CONVUNI_REST_DOTNET_GR01.Controllers;

using Microsoft.AspNetCore.Mvc;
using WS_CONVUNI_REST_DOTNET_GR01.Dto;
using WS_CONVUNI_REST_DOTNET_GR01.Services;

[ApiController]
[Route("api/[controller]")]
public class UnitConversionController : ControllerBase
{
    private readonly UnitConversionService _service;

    public UnitConversionController(UnitConversionService service)
    {
        _service = service;
    }

    [HttpPost("Mass")]
    public async Task<IActionResult> ConvertMass([FromBody] MassRequest dto)
    {
        var result = await _service.ConvertMass(dto);
        return Ok(result);
    }

    [HttpPost("Length")]
    public async Task<IActionResult> ConvertLength([FromBody] LengthRequest dto)
    {
        var result = await _service.ConvertLength(dto);
        return Ok(result);
    }

    [HttpPost("Temperature")]
    public async Task<IActionResult> ConvertTemperature([FromBody] TemperatureRequest dto)
    {
        var result = await _service.ConvertTemperature(dto);
        return Ok(result);
    }
}