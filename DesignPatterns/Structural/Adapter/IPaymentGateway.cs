namespace DesignPatterns.Structural.Adapter
{
    public interface IPaymentGateway
    {
        string ProcessPayment(string cardNumber, string expiryDate, string cvv, decimal amount);
        bool VerifyPayment(string transactionId);
    }
}
