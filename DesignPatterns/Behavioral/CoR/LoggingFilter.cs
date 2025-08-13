namespace DesignPatterns.Behavioral.CoR
{
    public class LoggingFilter : BaseRequestHandler
    {
        public override void Handle(WebRequest request)
        {
            Console.WriteLine("Logging Filter: Logging request details.");

            Console.WriteLine($"[LOG] Request for user '{request.User}' to resource '{request.Resource}' was received.");

            base.Handle(request);
        }
    }
}
