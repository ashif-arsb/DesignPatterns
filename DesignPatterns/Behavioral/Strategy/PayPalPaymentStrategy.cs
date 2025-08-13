namespace DesignPatterns.Behavioral.Strategy
{
    // Concrete Strategy
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount:F2}.");
            Console.WriteLine("PayPal payment successful.");
        }
    }
}
