using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.ConcreteProducts
{
    public class Bison : IHerbivore
    {
        public void Graze()
        {
            Console.WriteLine("Bison grazes on the plains.");
        }
    }
}
