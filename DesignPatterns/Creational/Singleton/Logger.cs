namespace DesignPatterns.Creational.Singleton
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> lazyInstance = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get { return lazyInstance.Value; }
        }

        private Logger()
        {
            Console.WriteLine("Logger instance created.");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] Log: {message}");
        }
    }
}
