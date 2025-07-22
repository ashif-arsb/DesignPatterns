using DesignPatterns.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.AbstractFactoryPattern.AbstractFactory
{
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}
