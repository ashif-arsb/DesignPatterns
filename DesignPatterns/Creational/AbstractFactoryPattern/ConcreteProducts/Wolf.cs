using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.ConcreteProducts
{
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"Wolf eats {herbivore.GetType().Name}");
        }
    }
}
