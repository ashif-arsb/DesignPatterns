namespace DesignPatterns.AntiPattern.TheBlob.Good
{
    public class EmailService
    {
        public void SendConfirmationEmail(Order order)
        {
            Console.WriteLine($"Sending confirmation email to '{order.CustomerEmail}'.");
            // Logic to send email...
        }
    }
}
