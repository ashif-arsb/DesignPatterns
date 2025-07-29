namespace DesignPatterns.Structural.Adapter
{
    public class LegacyPaymentProcessorAdapter : IPaymentGateway
    {
        private readonly LegacyPaymentProcessor _legacyProcessor;
        private static int InternalTransactionCounter { get; set; } = 0;

        public LegacyPaymentProcessorAdapter(LegacyPaymentProcessor legacyProcessor)
        {
            _legacyProcessor = legacyProcessor;
        }

        public string ProcessPayment(string cardNumber, string expiryDate, string cvv, decimal amount)
        {
            string accountDetails = $"{cardNumber.Substring(cardNumber.Length - 4)} (Expires {expiryDate})";
            double legacyAmount = (double)amount;

            _legacyProcessor.MakePayment(accountDetails, legacyAmount);
            Console.WriteLine("Adapter: Payment processed via legacy system.");

            InternalTransactionCounter++;
            string transactionId = "TRX" + InternalTransactionCounter;
            Console.WriteLine($"Adapter: Generated Transaction ID: {transactionId}");
            return transactionId;
        }

        public bool VerifyPayment(string transactionId)
        {
            string legacyReference = transactionId;
            string status = _legacyProcessor.CheckTransactionStatus(legacyReference);
            return status == "SUCCESS";
        }
    }
}
