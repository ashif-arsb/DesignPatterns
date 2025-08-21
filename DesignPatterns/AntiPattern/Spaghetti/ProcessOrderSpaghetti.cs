using DesignPatterns.AntiPattern.TheBlob;

namespace DesignPatterns.AntiPattern.Spaghetti
{
    public class ProcessOrderSpaghetti
    {
        public void ProcessOrder(Order order)
        {
            // A single, long, and tangled method
            if (order == null || order.Items.Count == 0)
            {
                Console.WriteLine("Error: Order is invalid.");
                return;
            }

            bool isDiscountApplied = false;
            decimal finalPrice = 0;

            // Check for a special discount code
            if (order.DiscountCode == "PROMO20")
            {
                finalPrice = order.TotalPrice * 0.8m;
                isDiscountApplied = true;
                goto ApplyDiscount;
            }

            // A separate, unrelated calculation block
            finalPrice = order.TotalPrice;
            if (order.Customer.IsPremium)
            {
                finalPrice -= 10;
                goto ProcessPayment;
            }

            ApplyDiscount:
            if (isDiscountApplied)
            {
                Console.WriteLine("20% discount applied.");
            }

            ProcessPayment:
            // A mix of unrelated logic and side effects
            Console.WriteLine($"Processing payment for {finalPrice:C}");

            // ... complex nested logic for shipping and inventory ...
            if (order.ShippingMethod == "Express")
            {
                if (CheckInventory(order.Items))
                {
                    Console.WriteLine("Express shipping and inventory confirmed.");
                }
                else
                {
                    Console.WriteLine("Not enough stock for express shipping.");
                }
            }

            // ... more scattered logic ...
            Console.WriteLine("Order processing complete.");
        }

        private bool CheckInventory(List<OrderItem> items)
        {
            throw new NotImplementedException();
        }

        // Good example in replace of Spaghetti code

        public void ProcessOrderGood(Order order)
        {
            if (!IsValidOrder(order))
            {
                Console.WriteLine("Error: Order is invalid.");
                return;
            }

            decimal finalPrice = CalculateFinalPrice(order);

            ProcessPayment(finalPrice);

            HandleShippingAndInventory(order);

            Console.WriteLine("Order processing complete.");
        }

        // Separated into a clear, single-purpose method
        private bool IsValidOrder(Order order)
        {
            return order != null && order.Items.Count > 0;
        }

        // Separated into a clear, single-purpose method
        private decimal CalculateFinalPrice(Order order)
        {
            decimal finalPrice = order.TotalPrice;

            if (order.DiscountCode == "PROMO20")
            {
                Console.WriteLine("20% discount applied.");
                finalPrice *= 0.8m;
            }

            if (order.Customer.IsPremium)
            {
                finalPrice -= 10;
            }

            return finalPrice;
        }

        // Separated into a clear, single-purpose method
        private void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment for {amount:C}");
            // ... payment processing logic ...
        }

        // Separated into a clear, single-purpose method
        private void HandleShippingAndInventory(Order order)
        {
            if (order.ShippingMethod == "Express")
            {
                if (CheckInventory(order.Items))
                {
                    Console.WriteLine("Express shipping and inventory confirmed.");
                }
                else
                {
                    Console.WriteLine("Not enough stock for express shipping.");
                }
            }
        }
    }
}
