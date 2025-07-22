using DesignPatterns.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.AbstractFactoryPattern.ConcreteProducts
{
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"Lion eats {herbivore.GetType().Name}");
        }
    }
}
