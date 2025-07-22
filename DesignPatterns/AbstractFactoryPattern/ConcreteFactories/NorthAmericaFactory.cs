using DesignPatterns.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.AbstractFactoryPattern.AbstractProducts;
using DesignPatterns.AbstractFactoryPattern.ConcreteProducts;

namespace DesignPatterns.AbstractFactoryPattern.ConcreteFactories
{
    public class NorthAmericaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
