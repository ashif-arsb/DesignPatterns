using DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory;
using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern
{
    public class AnimalWorld
    {
        private readonly ICarnivore _carnivore;
        private readonly IHerbivore _herbivore;

        public AnimalWorld(IContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _herbivore.Graze();
            _carnivore.Eat(_herbivore);
        }
    }
}
