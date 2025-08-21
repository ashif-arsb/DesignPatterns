namespace DesignPatterns.AntiPattern.TheBlob.Good
{
    public class OrderValidator
    {
        public void Validate(Order order)
        {
            if (order.Items == null || order.Items.Count == 0)
            {
                throw new ArgumentException("Order must contain items.");
            }
        }
    }
}
