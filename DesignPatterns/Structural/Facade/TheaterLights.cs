namespace DesignPatterns.Structural.Facade
{
    public class TheaterLights
    {
        public void Dim(int level) => Console.WriteLine($"Theater lights dimming to {level}%");
        public void On() => Console.WriteLine("Theater lights are on");
    }
}
