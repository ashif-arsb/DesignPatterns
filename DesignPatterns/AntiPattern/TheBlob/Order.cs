namespace DesignPatterns.AntiPattern.TheBlob
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public string CustomerEmail { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public string DiscountCode { get; set; } = string.Empty;
        public decimal TotalPrice { get; internal set; }
        public Customer Customer { get; internal set; } = new();
        public string ShippingMethod { get; internal set; }
    }

    public class Customer
    {
        public bool IsPremium { get; internal set; }
    }
}
