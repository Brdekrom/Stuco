using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Stukadoor;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StukadoorController : ControllerBase
{
    private readonly IRequestHandler<DtoBase, Stukadoor> _handler;

    public StukadoorController(IRequestHandler<DtoBase, Stukadoor> handler)
    {
        _handler = handler;
    }

    [HttpGet]
    public async Task<IActionResult> GetStukadoors()
    {
        var result = await _handler.GetAll();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetStukadoorById(int id)
    {
        var result = await _handler.Get(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateStukadoor([FromBody] CreateStukadoorDto stukadoor)
    {
        if (stukadoor == null)
        {
            return BadRequest();
        }

        var result = await _handler.Create(stukadoor);
        return CreatedAtAction(nameof(GetStukadoorById), result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateStukadoor([FromBody] UpdateStukadoorDto stukadoor)
    {
        if (stukadoor == null || !await _handler.Update(stukadoor))
        {
            return BadRequest();
        }
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteStukadoor(int id)
    {
        if (!await _handler.Delete(id))
        {
            return BadRequest();
        }
        return NoContent();
    }
}