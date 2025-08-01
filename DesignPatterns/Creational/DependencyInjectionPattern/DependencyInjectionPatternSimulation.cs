using DesignPatterns.DependencyInjectionPattern;

namespace DesignPatterns.Creational.DependencyInjectionPattern
{
    public class DependencyInjectionPatternSimulation
    {
        public void Simulate()
        {
            IEngine petrolEngine = new PetrolEngine();
            Car petrolCar = new Car(petrolEngine);
            petrolCar.Start();

            IEngine electricEngine = new ElectricEngine();
            Car electricCar = new Car(electricEngine);
            electricCar.Start();
        }
    }
}
