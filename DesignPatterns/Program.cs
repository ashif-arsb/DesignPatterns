using DesignPatterns.Creational.AbstractFactoryPattern;
using DesignPatterns.Creational.BuilderPattern;
using DesignPatterns.Creational.DependencyInjectionPattern;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.LazyInitializationPattern;
using DesignPatterns.Creational.MultitonPattern;
using DesignPatterns.Creational.ObjectPoolPattern;
using DesignPatterns.Creational.PrototypePattern;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;

namespace DesignPatterns
{
    public class Program
    {
        protected Program() { }
        static void Main(string[] args)
        {
            SimulateDesignPattern(DesignPattern.Flyweight.ToString());
        }

        static void SimulateDesignPattern(string patternName)
        {
            if (string.IsNullOrEmpty(patternName))
                patternName = string.Empty;
            else
                patternName = patternName.ToLower();

            switch (patternName)
            {
                case "singleton":
                    var singletonSimulation = new SingletonSimulation();
                    singletonSimulation.SimulateDoubleChedkedLockingObject();
                    singletonSimulation.SimulateEgarInitialization();
                    singletonSimulation.SimulateLazyInitialization();
                    break;

                case "factory":
                    var windowsButtonSimulation = new FactorySimulation("Windows");
                    var macButtonSimulation = new FactorySimulation("MacOS");
                    var linuxButtonSimulation = new FactorySimulation("Linux");

                    windowsButtonSimulation.Simulate();
                    macButtonSimulation.Simulate();
                    linuxButtonSimulation.Simulate();
                    break;

                case "abstractfactory":
                    var abstractFactory = new AbstractFactoryPatternSimulation();
                    abstractFactory.Simulate();
                    break;

                case "builder":
                    var builderPatternSimulation = new BuilderPatternSimulation();
                    builderPatternSimulation.BuildCustomComputer();
                    builderPatternSimulation.BuildComputersByDirector();
                    break;

                case "prototype":
                    var prototypePatternSimulation = new PrototypePatternSimulation();
                    prototypePatternSimulation.Simulate();
                    break;

                case "dependencyinjection":
                case "di":
                    var dependencyInjectionPatternSimulation = new DependencyInjectionPatternSimulation();
                    dependencyInjectionPatternSimulation.Simulate();
                    break;

                case "lazy":
                case "lazyinitialization":
                    var lazyInitializationSimulation = new LazyInitializationSimulation();
                    lazyInitializationSimulation.Simulate();
                    break;

                case "objectpool":
                    var objectPoolPatternSimulation = new ObjectPoolPatternSimulation();
                    objectPoolPatternSimulation.Simulate();
                    break;

                case "multiton":
                    var multitonPatternSimulation = new MultitonPatternSimulation();
                    multitonPatternSimulation.Simulate();
                    break;

                case "adapter":
                    var adapterPatternSimulation = new AdapterPatternSimulation();
                    adapterPatternSimulation.Simulate();
                    return;

                case "bridge":
                    var bridgePatternSimulation = new BridgePatternSimulation();
                    bridgePatternSimulation.Simulate();
                    return;

                case "composite":
                    var compositePatternSimulation = new CompositePatternSimulation();
                    compositePatternSimulation.Simulate();
                    return;

                case "decorator":
                    var decoratorPatternSimulation = new DecoratorPatternSimulation();
                    decoratorPatternSimulation.Simulate();
                    return;

                case "facade":
                    var facadePatternSimulation = new FacadePatternSimulation();
                    facadePatternSimulation.Simulate();
                    return;

                case "proxy":
                    var proxyPatternSimulation = new ProxyPatternSimulation();
                    proxyPatternSimulation.Simulate();
                    return;

                case "flyweight":
                    var flyweightPatternSimulation = new FlyweightPatternSimulation();
                    flyweightPatternSimulation.Simulate();
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
