namespace DesignPatterns.Behavioral.CoR
{
    public class CoRPatternSimulation
    {
        public void Simulate()
        {
            var authenticationFilter = new AuthenticationFilter();
            var authorizationFilter = new AuthorizationFilter();
            var loggingFilter = new LoggingFilter();
            var applicationLogicHandler = new ApplicationLogicHandler();

            authenticationFilter.SetNext(authorizationFilter)
                                .SetNext(loggingFilter)
                                .SetNext(applicationLogicHandler);

            // --- Scenario 1: A valid request
            Console.WriteLine("--- Processing a valid request ---");
            var validRequest = new WebRequest { User = "admin", Resource = "dashboard" };
            authenticationFilter.Handle(validRequest);
            Console.WriteLine($"\nRequest was processed: {validRequest.IsProcessed}\n");

            // --- Scenario 2: Unauthenticated request
            Console.WriteLine("--- Processing an unauthenticated request ---");
            var unauthenticatedRequest = new WebRequest { User = null, Resource = "dashboard" };
            authenticationFilter.Handle(unauthenticatedRequest);
            Console.WriteLine($"\nRequest was processed: {unauthenticatedRequest.IsProcessed}\n");

            // --- Scenario 3: Unauthorized request
            Console.WriteLine("--- Processing an unauthorized request ---");
            var unauthorizedRequest = new WebRequest { User = "user1", Resource = "secret_page" };
            authenticationFilter.Handle(unauthorizedRequest);
            Console.WriteLine($"\nRequest was processed: {unauthorizedRequest.IsProcessed}\n");
        }
    }
}
