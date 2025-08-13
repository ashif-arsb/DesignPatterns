namespace DesignPatterns.Behavioral.Strategy
{
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        // Concrete Strategy
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Credit Card payment of ${amount:F2}.");
            Console.WriteLine("Credit Card payment successful.");
        }
    }
}
