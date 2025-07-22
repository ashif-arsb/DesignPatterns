using DesignPatterns.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.AbstractFactoryPattern.ConcreteProducts
{
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore herbivore)
        {
            Console.WriteLine($"Wolf eats {herbivore.GetType().Name}");
        }
    }
}
