using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StukadoorController : ControllerBase
{
    private readonly IGetHandler<List<StukadoorDto>> _getHandler;
    private readonly IGetByIdHandler<StukadoorDto> _getByIdHandler;
    private readonly ICreateHandler<StukadoorDto, StukadoorDto> _postHandler;

    public StukadoorController(
        IGetHandler<List<StukadoorDto>> getHandler,
        IGetByIdHandler<StukadoorDto> getByIdHandler,
        ICreateHandler<StukadoorDto, StukadoorDto> postHandler)
    {
        _getHandler = getHandler;
        _getByIdHandler = getByIdHandler;
        _postHandler = postHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetStukadoors()
    {
        var result = await _getHandler.ExecuteAsync();
        return Ok(result);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetStukadoorById(int id)
    {
        var result = await _getByIdHandler.ExecuteAsync(id);
        if (result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateStukadoor([FromBody] StukadoorDto stukadoor)
    {
        if (stukadoor == null)
        {
            return BadRequest();
        }

        var result = await _postHandler.ExecuteAsync(stukadoor);
        return CreatedAtAction(nameof(GetStukadoorById), new { id = result.Id }, result);
    }
}