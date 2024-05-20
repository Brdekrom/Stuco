using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Features.Dtos;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly IGetHandler<List<Project>> _getHandler;
    private readonly IGetByIdHandler<Project> _getByIdHandler;
    private readonly ICreateHandler<ProjectDto, Project> _createHandler;
    private readonly IUpdateHandler<Project> _updateHandler;
    private readonly IDeleteHandler<Project> _deleteHandler;

    public ProjectController(
        IGetHandler<List<Project>> getHandler,
        IGetByIdHandler<Project> getByIdHandler,
        ICreateHandler<ProjectDto, Project> postHandler,
        IUpdateHandler<Project> updateHandler,
        IDeleteHandler<Project> deleteHandler)
    {
        _getHandler = getHandler;
        _getByIdHandler = getByIdHandler;
        _createHandler = postHandler;
        _updateHandler = updateHandler;
        _deleteHandler = deleteHandler;
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

        var project = await _createHandler.ExecuteAsync(projects);
        return CreatedAtAction(nameof(GetProjectById), project);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProject([FromBody] Project projects)
    {
        if (projects == null || !await _updateHandler.ExecuteAsync(projects))
        {
            return BadRequest();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteProject(int id)
    {
        if (!await _deleteHandler.ExecuteAsync(id))
        {
            return BadRequest();
        }

        return NoContent();
    }
}