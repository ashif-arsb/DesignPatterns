using DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.Creational.AbstractFactoryPattern.ConcreteFactories;

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
