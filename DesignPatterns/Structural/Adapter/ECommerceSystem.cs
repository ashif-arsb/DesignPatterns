namespace DesignPatterns.Structural.Adapter
{
    public class ECommerceSystem
    {
        private readonly IPaymentGateway _paymentGateway;

        public ECommerceSystem(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public void Checkout(string cardNumber, string expiryDate, string cvv, decimal orderTotal)
        {
            Console.WriteLine("\nE-Commerce System: Initiating checkout process...");

            string transactionId = _paymentGateway.ProcessPayment(cardNumber, expiryDate, cvv, orderTotal);

            if (!string.IsNullOrEmpty(transactionId) && _paymentGateway.VerifyPayment(transactionId))
            {
                Console.WriteLine($"E-Commerce System: Payment successful for order total ${orderTotal} (Transaction: {transactionId}).");
            }
            else
            {
                Console.WriteLine($"E-Commerce System: Payment failed for order total ${orderTotal} (Transaction: {transactionId ?? "N/A"}).");
            }
        }
    }
}
