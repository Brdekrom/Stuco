namespace Stuco.Application.Dtos.Contractor;

public record CreateContractorRequest(string CompanyName, CreateContractorContactRequest Contact, CreateContractorFiscalInformationRequest FiscalInformation);
public record CreateContractorContactRequest(string FirstName, string LastName, string Email, string PhoneNumber);
public record CreateContractorFiscalInformationRequest(string BankName, string BankAccountNumber, string KvkNumber, string BtwNumber);