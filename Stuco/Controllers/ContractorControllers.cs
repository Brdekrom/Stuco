using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[Route("api/[controller]")]
public class ContractorControllers(IRepository repository) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Contractor contractor)
    {
        repository.Contractors.Add(contractor);
        await repository.SaveChangesAsync();
        
        return Created();
    }
}