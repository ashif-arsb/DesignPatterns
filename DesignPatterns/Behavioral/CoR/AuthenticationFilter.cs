namespace DesignPatterns.Behavioral.CoR
{
    public class AuthenticationFilter : BaseRequestHandler
    {
        public override void Handle(WebRequest request)
        {
            Console.WriteLine($"Authentication Filter: Checking user '{request.User}'");

            if (!string.IsNullOrEmpty(request.User))
            {
                request.IsAuthenticated = true;
                base.Handle(request);
            }
            else
            {
                Console.WriteLine("Authentication failed. Request denied.");
            }
        }
    }
}
