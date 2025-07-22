using DesignPatterns.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.AbstractFactoryPattern.ConcreteFactories;

namespace DesignPatterns.AbstractFactoryPattern
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
