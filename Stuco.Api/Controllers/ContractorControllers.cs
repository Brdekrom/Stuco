using Microsoft.AspNetCore.Mvc;
using Stuco.Application.Abstractions;
using Stuco.Application.Dtos.Contractor;
using Stuco.Domain.Entities;

namespace Stuco.Api.Controllers;

[Route("api/[controller]")]
public class ContractorControllers(IRepository repository) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateContractorRequest request)
    {
        var contact = new Contact()
        {
            Email = request.Contact.Email,
            FirstName = request.Contact.FirstName,
            LastName = request.Contact.LastName,
            PhoneNumber = request.Contact.PhoneNumber,
        };

        var fiscalInformation = new FiscalInformation()
        {
            BankName = request.FiscalInformation.BankName,
            BankAccountNumber = request.FiscalInformation.BankAccountNumber,
            BtwNumber = request.FiscalInformation.BtwNumber,
            KvkNumber = request.FiscalInformation.KvkNumber,
        };
        var contractor = new Contractor()
        {
            CompanyName = request.CompanyName,
            Contact = contact,
            FiscalInformation = fiscalInformation,
        };
        
        repository.Contractors.Add(contractor);
        await repository.SaveChangesAsync();
        
        return Created();
    }
}