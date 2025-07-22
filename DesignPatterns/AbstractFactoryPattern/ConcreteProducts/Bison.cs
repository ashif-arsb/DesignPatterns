using DesignPatterns.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.AbstractFactoryPattern.ConcreteProducts
{
    public class Bison : IHerbivore
    {
        public void Graze()
        {
            Console.WriteLine("Bison grazes on the plains.");
        }
    }
}
