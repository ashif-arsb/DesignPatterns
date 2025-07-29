namespace DesignPatterns.Structural.Adapter
{
    public class AdapterPatternSimulation
    {
        public void Simulate()
        {
            LegacyPaymentProcessor legacyProcessor = new LegacyPaymentProcessor();
            IPaymentGateway adaptedGateway = new LegacyPaymentProcessorAdapter(legacyProcessor);

            ECommerceSystem eCommerceSystem = new ECommerceSystem(adaptedGateway);

            eCommerceSystem.Checkout("1234-5678-9012-3456", "12/25", "123", 99.99m);
            eCommerceSystem.Checkout("9876-5432-1098-7654", "01/26", "456", 250.50m);

            Console.ReadKey();
        }
    }
}
