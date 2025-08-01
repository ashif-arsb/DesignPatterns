using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.ConcreteProducts
{
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"Lion eats {herbivore.GetType().Name}");
        }
    }
}
