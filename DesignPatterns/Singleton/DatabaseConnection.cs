namespace DesignPatterns.Singleton
{
    public sealed class DatabaseConnection
    {
        private static DatabaseConnection? _instance;
        private static readonly object _lock = new object();

        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseConnection();
                            Console.WriteLine("DatabaseConnection instance created.");
                        }
                    }
                }
                return _instance;
            }
        }

        private DatabaseConnection()
        {
            Console.WriteLine("Database connection established.");
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing query: '{query}'");
        }
    }
}
