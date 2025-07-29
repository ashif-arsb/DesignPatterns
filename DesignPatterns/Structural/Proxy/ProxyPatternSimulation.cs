namespace DesignPatterns.Structural.Proxy
{
    public class ProxyPatternSimulation
    {
        public void Simulate()
        {
            Console.WriteLine("Client: Creating a bank account proxy for 'Alice'.");
            IAccount account = new BankAccountProxy("Alice");
            Console.WriteLine("---");

            Console.WriteLine("Client: Asking for account holder name.");
            Console.WriteLine($"Name: {account.GetAccountHolderName()}");
            Console.WriteLine("---");

            Console.WriteLine("Client: Asking for balance.");
            Console.WriteLine($"Balance: {account.GetBalance():C}");
            Console.WriteLine("---");

            Console.WriteLine("Client: Now asking for the full transaction history.");
            Console.WriteLine(account.GetTransactionHistory());
            Console.WriteLine("---");

            Console.WriteLine("Client: Asking for history again.");
            Console.WriteLine(account.GetTransactionHistory());
        }
    }
}
