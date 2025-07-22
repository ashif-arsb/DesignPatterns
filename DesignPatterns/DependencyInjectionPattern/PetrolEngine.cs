namespace DesignPatterns.DependencyInjectionPattern
{
    public class PetrolEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Petrol Engine started!");
        }
    }
}
