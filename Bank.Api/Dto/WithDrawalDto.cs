using Bank.Api.Contracts;
using Bank.Api.Responses;

namespace Bank.Api.Dto
{
    public class WithdrawalDto
    {
        public string? AccountNumber { get; set; }

       public decimal? Amount { get; set; }

    }
}
