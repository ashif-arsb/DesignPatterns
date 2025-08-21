namespace DesignPatterns.AntiPattern.TheBlob.Good
{
    public class InventoryService
    {
        public void ReduceInventory(Order order)
        {
            Console.WriteLine($"Reducing inventory for order '{order.OrderId}'.");
            // Logic to update inventory...
        }
    }
}
