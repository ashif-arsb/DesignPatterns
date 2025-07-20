namespace DesignPatterns.Singleton
{
    public class SingletonSimulation
    {
        public void SimulateDoubleChedkedLockingObject()
        {
            Console.WriteLine("Simulate Double Chedked Locking Object Start.");

            DatabaseConnection db1 = DatabaseConnection.Instance;
            db1.ExecuteQuery("SELECT * FROM Users");

            DatabaseConnection db2 = DatabaseConnection.Instance;
            db2.ExecuteQuery("INSERT INTO Logs VALUES ('App started')");

            Console.WriteLine($"\nAre db1 and db2 the same object? {ReferenceEquals(db1, db2)}");

            Console.WriteLine("\nSimulate Double Chedked Locking Object End.");
            Console.ReadKey();
        }

        public void SimulateEgarInitialization()
        {
            Console.WriteLine("\nSimulate Eager Initialization Start.");

            ConfigurationManager config1 = ConfigurationManager.Instance;
            config1.DisplaySettings();

            ConfigurationManager config2 = ConfigurationManager.Instance;
            config2.DisplaySettings();
            Console.WriteLine($"\nAre config1 and config2 the same object? {ReferenceEquals(config1, config2)}");

            Console.WriteLine("\nSimulate Eager Initialization End.");
            Console.ReadKey();
        }

        public void SimulateLazyInitialization()
        {
            Console.WriteLine("\nSimulate Lazy Initialization Start.");

            Logger logger1 = Logger.Instance;
            logger1.LogMessage("This is the first log message.");

            Logger logger2 = Logger.Instance;
            logger2.LogMessage("This is the second log message.");

            Console.WriteLine($"\nAre logger1 and logger2 the same object? {ReferenceEquals(logger1, logger2)}");

            Console.WriteLine("\nSimulate Lazy Initialization End.");
            Console.ReadKey();
        }
    }
}
