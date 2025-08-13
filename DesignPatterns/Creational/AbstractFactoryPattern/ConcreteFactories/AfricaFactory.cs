using DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;
using DesignPatterns.Creational.AbstractFactoryPattern.ConcreteProducts;

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
