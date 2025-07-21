using DesignPatterns.Factory;
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

            //var singletonSimulation = new SingletonSimulation();
            //singletonSimulation.SimulateDoubleChedkedLockingObject();
            //singletonSimulation.SimulateEgarInitialization();
            //singletonSimulation.SimulateLazyInitialization();

            /*****************************************************
             * Factory simulation bolck
             * ***************************************************/

            var windowsButtonSimulation = new FactorySimulation("Windows");
            var macButtonSimulation = new FactorySimulation("MacOS");
            var linuxButtonSimulation = new FactorySimulation("Linux");

            windowsButtonSimulation.Simulate();
            macButtonSimulation.Simulate();
            linuxButtonSimulation.Simulate();
        }
    }
}
