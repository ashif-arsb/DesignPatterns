namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyPatternSimulation
    {
        public void Simulate()
        {
            var paymentContext = new PaymentContext();
            var amountToPay = 99.99m;

            Console.WriteLine("Customer chooses to pay with PayPal:");
            paymentContext.SetPaymentStrategy(new PayPalPaymentStrategy());
            paymentContext.ExecutePayment(amountToPay);

            Console.WriteLine("\nCustomer then chooses to pay with Credit Card:");
            paymentContext.SetPaymentStrategy(new CreditCardPaymentStrategy());
            paymentContext.ExecutePayment(amountToPay);
        }
    }
}
