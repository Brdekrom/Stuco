using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StukadoorController : ControllerBase
{
    private readonly IGetHandler<List<StukadoorDto>> _getHandler;
    private readonly IGetByIdHandler<StukadoorDto> _getByIdHandler;
    private readonly ICreateHandler<StukadoorDto, Stukadoor> _postHandler;
    private readonly IUpdateHandler<Stukadoor> _updateHandler;
    private readonly IDeleteHandler<Stukadoor> _deleteHandler;

    public StukadoorController(
        IGetHandler<List<StukadoorDto>> getHandler,
        IGetByIdHandler<StukadoorDto> getByIdHandler,
        ICreateHandler<StukadoorDto, Stukadoor> postHandler,
        IUpdateHandler<Stukadoor> updateHandler,
        IDeleteHandler<Stukadoor> deleteHandler)
    {
        _getHandler = getHandler;
        _getByIdHandler = getByIdHandler;
        _postHandler = postHandler;
        _updateHandler = updateHandler;
        _deleteHandler = deleteHandler;
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
        return CreatedAtAction(nameof(GetStukadoorById), result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateStukadoor([FromBody] Stukadoor stukadoor)
    {
        if (stukadoor == null || !await _updateHandler.ExecuteAsync(stukadoor))
        {
            return BadRequest();
        }
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteStukadoor(int id)
    {
        if (!await _deleteHandler.ExecuteAsync(id))
        {
            return BadRequest();
        }
        return NoContent();
    }
}