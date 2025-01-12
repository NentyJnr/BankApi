using Bank.Api.Dto;
using Bank.Api.Entities;
using Bank.Api.Responses;

namespace Bank.Api.Contracts
{
    public interface IAccountService
    {
        Task<ServerResponse<bool>> CreateAccountAsync(AccountCreationDto request);
        Task<ServerResponse<bool>> DepositAsync(DepositDto request);
        Task<ServerResponse<BalanceDto>> CheckAccountBalanceAsync(string accountNumber);
        Task<ServerResponse<bool>> TransferAsync(TransferDto request);
        Task<ServerResponse<bool>> WithdrawAsync(WithdrawalDto request);
        Task<ServerResponse<bool>> DeleteAccountAsync(Guid id);

    }
}
