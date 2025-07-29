using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.DependencyInjectionPattern;
using DesignPatterns.Factory;
using DesignPatterns.LazyInitializationPattern;
using DesignPatterns.MultitonPattern;
using DesignPatterns.ObjectPoolPattern;
using DesignPatterns.PrototypePattern;
using DesignPatterns.Singleton;
using DesignPatterns.Structural.Adapter;

namespace DesignPatterns
{
    public class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            //SimulateCreationalPattern(DesignPattern.Singleton.ToString());
            SimulateStructuralPattern(DesignPattern.Adapter.ToString());
        }

        static void SimulateCreationalPattern(string patternName)
        {
            if (string.IsNullOrEmpty(patternName))
                patternName = string.Empty;
            else
                patternName = patternName.ToLower();

            switch (patternName)
            {
                /*****************************************************
                * Singleton simulation bolck
                * ***************************************************/
                case "singleton":
                    var singletonSimulation = new SingletonSimulation();
                    singletonSimulation.SimulateDoubleChedkedLockingObject();
                    singletonSimulation.SimulateEgarInitialization();
                    singletonSimulation.SimulateLazyInitialization();
                    break;

                /*****************************************************
                 * Factory simulation bolck
                 * ***************************************************/
                case "factory":
                    var windowsButtonSimulation = new FactorySimulation("Windows");
                    var macButtonSimulation = new FactorySimulation("MacOS");
                    var linuxButtonSimulation = new FactorySimulation("Linux");

                    windowsButtonSimulation.Simulate();
                    macButtonSimulation.Simulate();
                    linuxButtonSimulation.Simulate();
                    break;

                /*****************************************************
                 * Abstract Factory simulation bolck
                 * ***************************************************/
                case "abstractfactory":
                    var abstractFactory = new AbstractFactoryPatternSimulation();
                    abstractFactory.Simulate();
                    break;

                /*****************************************************
                 * Builder simulation bolck
                 * ***************************************************/
                case "builder":
                    var builderPatternSimulation = new BuilderPatternSimulation();
                    builderPatternSimulation.BuildCustomComputer();
                    builderPatternSimulation.BuildComputersByDirector();
                    break;

                /*****************************************************
                 * Protype pattern simulation bolck
                 * ***************************************************/
                case "prototype":
                    var prototypePatternSimulation = new PrototypePatternSimulation();
                    prototypePatternSimulation.Simulate();
                    break;

                /*****************************************************
                 * Dependecny Injection pattern simulation bolck
                 * ***************************************************/
                case "dependencyinjection":
                case "di":
                    var dependencyInjectionPatternSimulation = new DependencyInjectionPatternSimulation();
                    dependencyInjectionPatternSimulation.Simulate();
                    break;

                /*****************************************************
                 * Lazy Initialization pattern simulation bolck
                 * ***************************************************/
                case "lazy":
                case "lazyinitialization":
                    var lazyInitializationSimulation = new LazyInitializationSimulation();
                    lazyInitializationSimulation.Simulate();
                    break;

                /*****************************************************
                 * Object Pool pattern simulation bolck
                 * ***************************************************/
                case "objectpool":
                    var objectPoolPatternSimulation = new ObjectPoolPatternSimulation();
                    objectPoolPatternSimulation.Simulate();
                    break;

                /*****************************************************
                 * Multiton pattern simulation bolck
                 * ***************************************************/
                case "multiton":
                    var multitonPatternSimulation = new MultitonPatternSimulation();
                    multitonPatternSimulation.Simulate();
                    break;
                default:
                    return;
            }
        }

        static void SimulateStructuralPattern(string patternName)
        {
            if (string.IsNullOrEmpty(patternName))
                patternName = string.Empty;
            else
                patternName = patternName.ToLower();

            switch (patternName)
            {
                case "adapter":
                    var adapterPatternSimulation = new AdapterPatternSimulation();
                    adapterPatternSimulation.Simulate();
                    return;

                default:
                    return;
            }
        }
    }

    public enum DesignPattern
    {
        //Creational patterns
        DependencyInjection,
        LazyInitialization,
        Singleton,
        Factory,
        AbstractFactory,
        Builder,
        Prototype,
        ObjectPool,
        Multiton,

        //Structural patterns
        Adapter,
        Bridge,
        Composite,
        Decorator,
        Facade,
        Proxy,
        Flyweight
    }
}
