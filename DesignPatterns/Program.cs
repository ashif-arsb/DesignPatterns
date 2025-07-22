using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.DependencyInjectionPattern;
using DesignPatterns.Factory;
using DesignPatterns.LazyInitializationPattern;
using DesignPatterns.ObjectPoolPattern;
using DesignPatterns.PrototypePattern;
using DesignPatterns.Singleton;

namespace DesignPatterns
{
    public class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            /*****************************************************
             * Singleton simulation bolck
             * ***************************************************/

            var singletonSimulation = new SingletonSimulation();
            singletonSimulation.SimulateDoubleChedkedLockingObject();
            singletonSimulation.SimulateEgarInitialization();
            singletonSimulation.SimulateLazyInitialization();

            /*****************************************************
             * Factory simulation bolck
             * ***************************************************/

            var windowsButtonSimulation = new FactorySimulation("Windows");
            var macButtonSimulation = new FactorySimulation("MacOS");
            var linuxButtonSimulation = new FactorySimulation("Linux");

            windowsButtonSimulation.Simulate();
            macButtonSimulation.Simulate();
            linuxButtonSimulation.Simulate();

            /*****************************************************
             * Abstract Factory simulation bolck
             * ***************************************************/

            var abstractFactory = new AbstractFactoryPatternSimulation();
            abstractFactory.Simulate();

            /*****************************************************
             * Builder simulation bolck
             * ***************************************************/

            var builderPatternSimulation = new BuilderPatternSimulation();
            builderPatternSimulation.BuildCustomComputer();
            builderPatternSimulation.BuildComputersByDirector();

            /*****************************************************
             * Protype pattern simulation bolck
             * ***************************************************/

            var prototypePatternSimulation = new PrototypePatternSimulation();
            prototypePatternSimulation.Simulate();

            /*****************************************************
             * Dependecny Injection pattern simulation bolck
             * ***************************************************/

            var dependencyInjectionPatternSimulation = new DependencyInjectionPatternSimulation();
            dependencyInjectionPatternSimulation.Simulate();

            /*****************************************************
             * Lazy Initialization pattern simulation bolck
             * ***************************************************/

            var lazyInitializationSimulation = new LazyInitializationSimulation();
            lazyInitializationSimulation.Simulate();

            /*****************************************************
             * Object Pool pattern simulation bolck
             * ***************************************************/

            var objectPoolPatternSimulation = new ObjectPoolPatternSimulation();
            objectPoolPatternSimulation.Simulate();
        }
    }
}
