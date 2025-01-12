using Bank.Api.Contracts;
using Bank.Api.Responses;

namespace Bank.Api.Dto
{
    public class AccountCreationDto
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public decimal AccountBalance { get; set; }
 
    }
}
