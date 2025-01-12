using Bank.Api.Contracts;
using Bank.Api.Dto;
using Bank.Api.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bank.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IHttpContextAccessor _httpContext;


        public AccountController(IAccountService accountService, IHttpContextAccessor httpContext)
        {
            _accountService = accountService;
            _httpContext = httpContext;
        }



        [HttpPost("create-account")]
        public async Task<IActionResult> Create([FromBody] AccountCreationDto request)
        {
            var response = await _accountService.CreateAccountAsync(request);

            if (response != null)
            {
                if (response.IsSuccessful)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            else
            {
                return BadRequest(new ErrorResponse { ResponseCode = ResponseCodes.EXCEPTION, ResponseDescription = (ResponseCodes.EXCEPTION) });
            }
        }


        [HttpPut("deposit")]
        public async Task<IActionResult> Deposit([FromBody] DepositDto request)
        {
            var response = await _accountService.DepositAsync(request);

            if (response != null)
            {
                if (response.IsSuccessful)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            else
            {
                return BadRequest(new ErrorResponse { ResponseCode = ResponseCodes.EXCEPTION, ResponseDescription = (ResponseCodes.EXCEPTION) });
            }
        }

        [HttpPost("transfer")]
        public async Task<IActionResult> Transfer([FromBody] TransferDto request)
        {
            var response = await _accountService.TransferAsync(request);

            if (response != null)
            {
                if (response.IsSuccessful)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            else
            {
                return BadRequest(new ErrorResponse { ResponseCode = ResponseCodes.EXCEPTION, ResponseDescription = (ResponseCodes.EXCEPTION) });
            }
        }

        [HttpPut("withdraw")]
        public async Task<IActionResult> Withdrawal([FromBody] WithdrawalDto request)
        {
            var response = await _accountService.WithdrawAsync(request);

            if (response != null)
            {
                if (response.IsSuccessful)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            else
            {
                return BadRequest(new ErrorResponse { ResponseCode = ResponseCodes.EXCEPTION, ResponseDescription = (ResponseCodes.EXCEPTION) });
            }
        }

        [HttpGet("check-balance")]
        public async Task<IActionResult> Balance([FromQuery] string request)
        {
            var response = await _accountService.CheckAccountBalanceAsync(request);

            if (response != null)
            {
                if (response.IsSuccessful)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            else
            {
                return BadRequest(new ErrorResponse { ResponseCode = ResponseCodes.EXCEPTION, ResponseDescription = (ResponseCodes.EXCEPTION) });
            }
        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _accountService.DeleteAccountAsync(id);

            if (response != null)
            {
                if (response.IsSuccessful)
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            else
            {
                return BadRequest(new ErrorResponse { ResponseCode = ResponseCodes.EXCEPTION, ResponseDescription = (ResponseCodes.EXCEPTION) });
            }
        }
    }
}
