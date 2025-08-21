namespace DesignPatterns.AntiPattern.TheBlob.Bad
{
    public class OrderProcessorBad
    {
        public void ProcessOrder(Order order)
        {
            // Step 1: Validate the order
            if (order.Items == null || order.Items.Count == 0)
            {
                throw new ArgumentException("Order must contain items.");
            }

            // Step 2: Calculate the total price
            decimal total = 0;
            foreach (var item in order.Items)
            {
                total += item.Price * item.Quantity;
            }
            order.TotalAmount = total;

            // Step 3: Handle inventory
            foreach (var item in order.Items)
            {
                // Simulate inventory reduction
                Console.WriteLine($"Reducing inventory for item '{item.Name}'.");
            }

            // Step 4: Send confirmation email
            // Simulate sending an email
            Console.WriteLine($"Sending confirmation email to '{order.CustomerEmail}'.");

            // Step 5: Save to database
            // Simulate saving the order
            Console.WriteLine("Saving order to the database.");

            Console.WriteLine($"Order '{order.OrderId}' processed successfully. Total: {order.TotalAmount:C}");
        }
    }
}
