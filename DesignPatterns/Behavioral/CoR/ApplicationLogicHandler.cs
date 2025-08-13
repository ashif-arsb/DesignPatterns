namespace DesignPatterns.Behavioral.CoR
{
    public class ApplicationLogicHandler : BaseRequestHandler
    {
        public override void Handle(WebRequest request)
        {
            if (request.IsAuthenticated && request.IsAuthorized)
            {
                Console.WriteLine("Application Logic: Processing the request and generating a response.");
                request.IsProcessed = true;
            }
            else
            {
                Console.WriteLine("Application Logic: Request could not be processed due to earlier failures.");
            }
        }
    }
}
