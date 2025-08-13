namespace DesignPatterns.Behavioral.Strategy
{
    // Context
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy not set.");
            }
            _paymentStrategy.ProcessPayment(amount);
        }
    }

}
