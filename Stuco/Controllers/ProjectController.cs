using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly IGetHandler<List<ProjectDto>> _getHandler;
    private readonly IGetByIdHandler<ProjectDto> _getByIdHandler;
    private readonly IPostHandler<ProjectDto> _postHandler;

    public ProjectController(
        IGetHandler<List<ProjectDto>> getHandler,
        IGetByIdHandler<ProjectDto> getByIdHandler,
        IPostHandler<ProjectDto> postHandler)
    {
        _getHandler = getHandler;
        _getByIdHandler = getByIdHandler;
        _postHandler = postHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetProjects()
    {
        var projects = await _getHandler.ExecuteAsync();
        return Ok(projects);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProjectById(int id)
    {
        var projects = await _getByIdHandler.ExecuteAsync(id);
        if (projects == null)
        {
            return NotFound();
        }
        return Ok(projects);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProject([FromBody] ProjectDto projects)
    {
        if (projects == null)
        {
            return BadRequest();
        }

        var result = await _postHandler.ExecuteAsync(projects);
        return CreatedAtAction(nameof(GetProjectById), new { id = result.Id }, result);
    }
}