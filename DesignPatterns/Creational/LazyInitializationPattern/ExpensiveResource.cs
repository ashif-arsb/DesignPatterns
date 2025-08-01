namespace DesignPatterns.Creational.LazyInitializationPattern
{
    public class ExpensiveResource
    {
        public ExpensiveResource()
        {
            Console.WriteLine("ExpensiveResource instance created.");
            Thread.Sleep(2000); // Simulate a costly operation
        }

        public void DoSomething()
        {
            Console.WriteLine("ExpensiveResource is doing something.");
        }
    }
}
