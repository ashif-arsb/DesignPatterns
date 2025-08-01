using DesignPatterns.AbstractFactoryPattern.ConcreteFactories;
using DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public class AbstractFactoryPatternSimulation
    {
        public AbstractFactoryPatternSimulation() { }

        public void Simulate()
        {
            IContinentFactory africaFactory = new AfricaFactory();
            AnimalWorld africaWorld = new AnimalWorld(africaFactory);
            africaWorld.RunFoodChain();

            IContinentFactory northAmericaFactory = new NorthAmericaFactory();
            AnimalWorld northAmericaWorld = new AnimalWorld(northAmericaFactory);
            northAmericaWorld.RunFoodChain();
        }
    }
}
