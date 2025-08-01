using System.Collections.Concurrent;
namespace DesignPatterns.Creational.MultitonPattern
{
    public sealed class Logger
    {
        private static readonly ConcurrentDictionary<string, Logger> _instances = new ConcurrentDictionary<string, Logger>();

        private Logger(string moduleName)
        {
            ModuleName = moduleName;
            Console.WriteLine($"Logger for module '{ModuleName}' created.");
        }

        public string ModuleName { get; private set; }

        public static Logger GetInstance(string moduleName)
        {
            return _instances.GetOrAdd(moduleName, key => new Logger(key));
        }

        public void Log(string message)
        {
            Console.WriteLine($"[{ModuleName} Logger]: {message}");
        }
    }
}
