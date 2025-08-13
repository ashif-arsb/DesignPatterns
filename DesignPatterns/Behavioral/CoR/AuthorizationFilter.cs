namespace DesignPatterns.Behavioral.CoR
{
    public class AuthorizationFilter : BaseRequestHandler
    {
        public override void Handle(WebRequest request)
        {
            Console.WriteLine($"Authorization Filter: Checking permissions for resource '{request.Resource}'");

            if (request.IsAuthenticated)
            {
                if (request.Resource == "home" || request.Resource == "dashboard")
                {
                    request.IsAuthorized = true;
                    base.Handle(request);
                }
                else
                {
                    Console.WriteLine("Authorization failed. Access to this resource is denied.");
                }
            }
        }
    }
}
