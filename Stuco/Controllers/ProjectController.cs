using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos;
using Stuco.Application.Dtos.Project;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly IRequestHandler<DtoBase, Project> _handler;

    public ProjectController(IRequestHandler<DtoBase, Project> requestHandler)
    {
        _handler = requestHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetProjects()
    {
        var projects = await _handler.GetAll();
        return Ok(projects);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetProjectById(int id)
    {
        var projects = await _handler.Get(id);
        if (projects == null)
        {
            return NotFound();
        }
        return Ok(projects);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProject([FromBody] CreateProjectDto projects)
    {
        if (projects == null)
        {
            return BadRequest();
        }

        var project = await _handler.Create(projects);
        return new OkObjectResult(project);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateProject([FromBody] UpdateProjectDto projects)
    {
        if (projects == null || !await _handler.Update(projects))
        {
            return BadRequest();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteProject(int id)
    {
        if (!await _handler.Delete(id))
        {
            return BadRequest();
        }

        return NoContent();
    }
}