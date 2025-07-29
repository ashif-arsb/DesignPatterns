namespace DesignPatterns.Structural.Proxy
{
    public class BankAccountProxy : IAccount
    {
        private RealBankAccount? _realAccount;
        private string _accountHolder;
        private decimal _cachedBalance;

        public BankAccountProxy(string accountHolder)
        {
            _accountHolder = accountHolder;
            _cachedBalance = 1250.75m;
            Console.WriteLine("Proxy created. Real account is not yet instantiated.");
        }

        private RealBankAccount GetRealAccount()
        {
            if (_realAccount == null)
            {
                _realAccount = new RealBankAccount(_accountHolder);
            }
            return _realAccount;
        }

        public string GetAccountHolderName()
        {
            return _accountHolder;
        }

        public decimal GetBalance()
        {
            Console.WriteLine("Fetching balance from proxy cache.");
            return _cachedBalance;
        }

        public string GetTransactionHistory()
        {
            Console.WriteLine("Proxy: Request for transaction history received. Delegating to Real Account...");
            return GetRealAccount().GetTransactionHistory();
        }
    }
}
