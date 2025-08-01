namespace DesignPatterns.Creational.DependencyInjectionPattern
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric Engine started!");
        }
    }
}
