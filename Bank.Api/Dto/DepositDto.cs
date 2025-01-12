using Bank.Api.Contracts;
using Bank.Api.Helpers;
using Bank.Api.Responses;

namespace Bank.Api.Dto
{
    public class DepositDto
    {
        public string? AccountNumber { get; set; }

        public decimal? Amount { get; set; }

    }
}
