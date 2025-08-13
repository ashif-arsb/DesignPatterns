namespace DesignPatterns.Behavioral.CoR
{
    public class WebRequest
    {
        public string User { get; set; } = string.Empty;
        public string Resource { get; set; } = string.Empty;
        public bool IsAuthenticated { get; set; }
        public bool IsAuthorized { get; set; }
        public bool IsProcessed { get; set; }
    }
}
