using DesignPatterns.Behavioral.Command;
using DesignPatterns.Behavioral.CoR;
using DesignPatterns.Behavioral.Interpreter;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Mediator;
using DesignPatterns.Behavioral.Memento;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.State.WithoutPattern;
using DesignPatterns.Behavioral.State.WithPattern;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.TemplateMethod;
using DesignPatterns.Behavioral.Visitor;
using DesignPatterns.Behavioral.Visitor.Application;
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
            SimulateDesignPattern(DesignPattern.Iterator.ToString());
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

                case "statemono":
                    var game = new GameSimulationMonolithic();
                    game.Run();
                    return;

                case "state":
                    var gameStatePattern = new GameSimulationStatePattern();
                    gameStatePattern.Run();
                    return;

                case "cor":
                    var cor = new CoRPatternSimulation();
                    cor.Simulate();
                    return;

                case "observer":
                    var observer = new ObserverPatterSimulation();
                    observer.Simulate();
                    return;

                case "strategy":
                    var startegy = new StrategyPatternSimulation();
                    startegy.Simulate();
                    return;

                case "templatemethod":
                    var tm = new TemplateMethodPatternSimulation();
                    tm.Simulate();
                    return;

                case "command":
                    var command = new CommandPatternSimulation();
                    command.Simulate();
                    return;

                case "memento":
                    var memento = new MementoPatternSimulation();
                    memento.Simulate();
                    return;

                case "visitor":
                    var visitor = new VisitorPatternSimulation();
                    visitor.Simulate();
                    return;

                case "visitorapp":
                    var visitorApp = new AstApplication();
                    visitorApp.Run();
                    return;

                case "interpreter":
                    var interpreter = new InterpreterPatternSimulation();
                    interpreter.Simulate();
                    return;

                case "mediator":
                    var mediator = new MediatorPatternSimulation();
                    mediator.Simulate();
                    return;

                case "iterator":
                    var iterator = new IteratorPatternSimulation();
                    iterator.Simulate();
                    return;

                default:
                    return;
            }
        }
    }

    public enum DesignPattern
    {
        // Creational patterns
        DependencyInjection,
        LazyInitialization,
        Singleton,
        Factory,
        AbstractFactory,
        Builder,
        Prototype,
        ObjectPool,
        Multiton,

        // Structural patterns
        Adapter,
        Bridge,
        Composite,
        Decorator,
        Facade,
        Proxy,
        Flyweight,

        // Behavioral patterns
        StateMono, State,
        CoR,
        Observer,
        Strategy,
        TemplateMethod,
        Command,
        Memento,
        Visitor,
        VisitorApp,
        Interpreter,
        Mediator,
        Iterator
    }
}
