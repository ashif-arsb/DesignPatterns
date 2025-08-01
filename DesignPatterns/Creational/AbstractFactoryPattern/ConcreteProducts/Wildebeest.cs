using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.ConcreteProducts
{
    public class Wildebeest : IHerbivore
    {
        public void Graze()
        {
            Console.WriteLine("Wildebeest grazes on the savanna.");
        }
    }
}
