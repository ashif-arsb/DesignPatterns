using DesignPatterns.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.AbstractFactoryPattern.ConcreteProducts
{
    public class Wildebeest : IHerbivore
    {
        public void Graze()
        {
            Console.WriteLine("Wildebeest grazes on the savanna.");
        }
    }
}
