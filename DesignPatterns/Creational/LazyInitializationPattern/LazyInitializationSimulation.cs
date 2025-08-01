namespace DesignPatterns.Creational.LazyInitializationPattern
{
    public class LazyInitializationSimulation
    {
        public void Simulate()
        {
            Console.WriteLine("Creating MyServiceWithLazy instance...");
            MyServiceWithLazy service = new MyServiceWithLazy(); // ExpensiveResource is NOT created here
            Console.WriteLine("MyServiceWithLazy instance created. Press any key to use resource.");
            Console.ReadKey();

            Console.WriteLine("Accessing resource for the first time...");
            service.PerformOperation(); // ExpensiveResource is created here
            Console.WriteLine("Resource accessed. Press any key to access again.");
            Console.ReadKey();

            Console.WriteLine("Accessing resource for the second time...");
            service.PerformOperation(); // ExpensiveResource is NOT created again, existing instance is used
        }
    }
}
