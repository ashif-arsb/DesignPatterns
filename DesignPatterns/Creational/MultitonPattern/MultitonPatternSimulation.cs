namespace DesignPatterns.Creational.MultitonPattern
{
    public class MultitonPatternSimulation
    {
        public void Simulate()
        {
            Logger moduleALogger = Logger.GetInstance("ModuleA");
            Logger moduleBLogger = Logger.GetInstance("ModuleB");
            Logger moduleALoggerAgain = Logger.GetInstance("ModuleA");

            Console.WriteLine($"Are moduleALogger and moduleALoggerAgain the same instance? {ReferenceEquals(moduleALogger, moduleALoggerAgain)}");

            moduleALogger.Log("This is a log message from Module A.");
            moduleBLogger.Log("This is a log message from Module B.");
            moduleALoggerAgain.Log("Another log message from Module A using the same instance.");

            Logger moduleCLogger = Logger.GetInstance("ModuleC");
            moduleCLogger.Log("Log from Module C.");
        }
    }
}
