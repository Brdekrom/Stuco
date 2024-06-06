using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Klant;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KlantController : ControllerBase
{
    private readonly IRequestHandler<DtoBase, ViewKlantDto> _handler;

    public KlantController(IRequestHandler<DtoBase, ViewKlantDto> handler)
    {
        _handler = handler;
    }

    [HttpGet]
    public async Task<IActionResult> GetKlanten()
    {
        var result = await _handler.GetAll();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetKlantById(int id)
    {
        var result = await _handler.Get(id);
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

        var result = await _handler.Create(klant);
        return new OkObjectResult(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateKlant([FromBody] UpdateKlantDto klant)
    {
        if (klant == null || !await _handler.Update(klant))
        {
            return BadRequest();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteKlant(int id)
    {
        if (!await _handler.Delete(id))
        {
            return BadRequest();
        }

        return NoContent();
    }
}