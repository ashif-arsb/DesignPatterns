namespace DesignPatterns.Structural.Adapter
{
    public class LegacyPaymentProcessor
    {
        public void MakePayment(string accountDetails, double totalAmount)
        {
            Console.WriteLine($"Legacy Payment Processor: Processing payment of ${totalAmount} for account {accountDetails}.");
            //Complex legacy payment logic goes here
        }

        public string CheckTransactionStatus(string transactionReference)
        {
            Console.WriteLine($"Legacy Payment Processor: Checking status for transaction {transactionReference}.");
            return "SUCCESS"; // Or "FAILED", "PENDING"
        }
    }
}
