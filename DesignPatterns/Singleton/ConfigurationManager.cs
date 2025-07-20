namespace DesignPatterns.Singleton
{
    public sealed class ConfigurationManager
    {
        private static readonly ConfigurationManager _instance = new ConfigurationManager();

        public static ConfigurationManager Instance
        {
            get { return _instance; }
        }

        public string AppName { get; private set; }
        public int MaxConnections { get; private set; }

        private ConfigurationManager()
        {
            Console.WriteLine("ConfigurationManager instance created (eagerly).");
            AppName = "My Awesome App";
            MaxConnections = 10;
        }

        public static void AccessEagerClassStaticMethod()
        {
            Console.WriteLine("AccessEagerClassStaticMethod accessed");
        }

        public void DisplaySettings()
        {
            Console.WriteLine($"App Name: {AppName}, Max Connections: {MaxConnections}");
        }
    }
}
