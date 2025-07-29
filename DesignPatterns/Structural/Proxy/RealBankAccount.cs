namespace DesignPatterns.Structural.Proxy
{
    public class RealBankAccount : IAccount
    {
        private string _accountHolder;
        private decimal _balance;

        public RealBankAccount(string accountHolder)
        {
            _accountHolder = accountHolder;
            _balance = 1250.75m;

            Console.WriteLine($"[DB] Connecting to database and loading data for {_accountHolder}...");
            Thread.Sleep(3000);
            Console.WriteLine("[DB] Connection successful. RealBankAccount object created.");
        }

        public string GetAccountHolderName() => _accountHolder;
        public decimal GetBalance() => _balance;

        public string GetTransactionHistory()
        {
            return "Transaction History: [... many transactions ...]";
        }
    }
}
