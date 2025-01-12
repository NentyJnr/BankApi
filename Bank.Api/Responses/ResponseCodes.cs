namespace Bank.Api.Responses
{
    public class ResponseCodes
    {
        public const string SUCCESS = "BNK0000";
        public const string FAIL = "BNK0001";
        public const string BAD_REQUEST = "BNK0003";
        public const string NULL_REFERENCE = "BNK004";
        public const string ACCOUNT_NOT_FOUND = "BNK005";
        public const string INSUFFICIENT_BALANCE = "BNK006";
        public const string EMAIL_ALREADY_EXIST = "BNK007";
        public const string REQUEST_NOT_SUCCESSFUL = "BNK008";
        public const string WITHDRAWAL_AMOUNT_MUST_BE_GREATER_THAN_ZERO = "BNK009";
        public const string INSUFFICIENT_BALANCE_MINIMUM_BALANCE_OF_100_IS_REQUIRED = "BNK0010";
        public const string ACCOUNT_CREATED_SUCCESSFULLY = "BNK0011";
        public const string ACCOUNT_CREDITED_SUCCESSFULLY = "BNK0012";
        public const string TRANSFER_SUCCESSFUL = "BNK0013";
        public const string REQUEST_SUCCESSFUL = "BNK0014";



        public const string EXCEPTION = "ZE9999";


    }
}
