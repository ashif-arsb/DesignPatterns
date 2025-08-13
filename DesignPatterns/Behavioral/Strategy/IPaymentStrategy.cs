namespace DesignPatterns.Behavioral.Strategy
{
    // 1. Strategy Interface
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
