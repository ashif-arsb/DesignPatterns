namespace DesignPatterns.AntiPattern.TheBlob.Good
{
    public class OrderCalculator
    {
        public decimal CalculateTotal(Order order)
        {
            decimal total = 0;
            foreach (var item in order.Items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}
