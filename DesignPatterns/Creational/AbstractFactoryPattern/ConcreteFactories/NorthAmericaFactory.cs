using DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;
using DesignPatterns.Creational.AbstractFactoryPattern.ConcreteProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.ConcreteFactories
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
