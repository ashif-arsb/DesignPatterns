namespace DesignPatterns.AntiPattern.TheBlob.Good
{
    public class OrderService
    {
        private readonly OrderValidator _orderValidator;
        private readonly OrderCalculator _orderCalculator;
        private readonly InventoryService _inventoryService;
        private readonly EmailService _emailService;

        public OrderService(
            OrderValidator orderValidator,
            OrderCalculator orderCalculator,
            InventoryService inventoryService,
            EmailService emailService)
        {
            _orderValidator = orderValidator;
            _orderCalculator = orderCalculator;
            _inventoryService = inventoryService;
            _emailService = emailService;
        }

        public void ProcessOrder(Order order)
        {
            _orderValidator.Validate(order);
            order.TotalAmount = _orderCalculator.CalculateTotal(order);
            _inventoryService.ReduceInventory(order);
            _emailService.SendConfirmationEmail(order);

            Console.WriteLine($"Order '{order.OrderId}' processed successfully. Total: {order.TotalAmount:C}");
        }
    }
}
