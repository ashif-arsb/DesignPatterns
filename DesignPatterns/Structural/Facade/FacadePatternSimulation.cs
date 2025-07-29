namespace DesignPatterns.Structural.Facade
{
    public class FacadePatternSimulation
    {
        public void Simulate()
        {
            var amp = new Amplifier();
            var projector = new Projector();
            var lights = new TheaterLights();
            var player = new StreamingPlayer();

            var homeTheater = new HomeTheaterFacade(amp, projector, lights, player);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
