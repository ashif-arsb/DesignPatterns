using DesignPatterns.AbstractFactoryPattern.ConcreteProducts;
using DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.ConcreteFactories
{
    public class AfricaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
