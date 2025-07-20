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


        }
    }
}
