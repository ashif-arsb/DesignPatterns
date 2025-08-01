using DesignPatterns.Creational.AbstractFactoryPattern.AbstractProducts;

namespace DesignPatterns.Creational.AbstractFactoryPattern.AbstractFactory
{
    public interface IContinentFactory
    {
        ICarnivore CreateCarnivore();
        IHerbivore CreateHerbivore();
    }
}
