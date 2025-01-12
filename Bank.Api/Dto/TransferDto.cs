using Bank.Api.Contracts;
using Bank.Api.Responses;

namespace Bank.Api.Dto
{
    public class TransferDto
    {
        public decimal? Amount { get; set; }

        public string? SenderAccountNumber { get; set; }

        public string? ReceiverAccountNumber { get; set; }
 
    }
}

