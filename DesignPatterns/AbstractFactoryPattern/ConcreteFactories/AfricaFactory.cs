using DesignPatterns.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.AbstractFactoryPattern.AbstractProducts;
using DesignPatterns.AbstractFactoryPattern.ConcreteProducts;

namespace DesignPatterns.AbstractFactoryPattern.ConcreteFactories
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
