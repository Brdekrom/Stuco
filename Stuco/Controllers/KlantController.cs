using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class KlantController : ControllerBase
{
    private readonly IGetHandler<List<Klant>> _getHandler;
    private readonly IGetByIdHandler<Klant> _getByIdHandler;
    private readonly ICreateHandler<KlantDto, Klant> _createHandler;
    private readonly IUpdateHandler<Klant> _updateHandler;
    private readonly IDeleteHandler<Klant> _deleteHandler;

    public KlantController(
        IGetHandler<List<Klant>> getHandler,
        IGetByIdHandler<Klant> getByIdHandler,
        ICreateHandler<KlantDto, Klant> createHandler,
        IUpdateHandler<Klant> updateHandler,
        IDeleteHandler<Klant> deleteHandler)
    {
        _getHandler = getHandler;
        _getByIdHandler = getByIdHandler;
        _createHandler = createHandler;
        _updateHandler = updateHandler;
        _deleteHandler = deleteHandler;
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
    public async Task<IActionResult> CreateKlant([FromBody] KlantDto klant)
    {
        if (klant == null)
        {
            return BadRequest();
        }

        var result = await _createHandler.ExecuteAsync(klant);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateKlant([FromBody] Klant klant)
    {
        // TODO: Handler needs a DTO
        if (klant == null || !await _updateHandler.ExecuteAsync(klant))
        {
            return BadRequest();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteKlant(int id)
    {
        if (!await _deleteHandler.ExecuteAsync(id))
        {
            return BadRequest();
        }

        return NoContent();
    }
}