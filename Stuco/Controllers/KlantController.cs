using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KlantController : ControllerBase
{
    private readonly IGetHandler<List<KlantDto>> _getHandler;
    private readonly IGetByIdHandler<KlantDto> _getByIdHandler;
    private readonly IPostHandler<CreateKlantDto, KlantDto> _postHandler;

    public KlantController(
        IGetHandler<List<KlantDto>> getHandler,
        IGetByIdHandler<KlantDto> getByIdHandler,
        IPostHandler<CreateKlantDto, KlantDto> postHandler)
    {
        _getHandler = getHandler;
        _getByIdHandler = getByIdHandler;
        _postHandler = postHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetKlanten()
    {
        var result = await _getHandler.ExecuteAsync();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetKlantById(int id)
    {
        var result = await _getByIdHandler.ExecuteAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateKlant([FromBody] CreateKlantDto klant)
    {
        if (klant == null)
        {
            return BadRequest();
        }

        var result = await _postHandler.ExecuteAsync(klant);
        return CreatedAtAction(nameof(GetKlantById), new { id = result.Id }, result);
    }
}