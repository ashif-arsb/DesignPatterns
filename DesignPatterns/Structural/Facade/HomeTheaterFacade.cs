namespace DesignPatterns.Structural.Facade
{
    public class HomeTheaterFacade
    {
        private readonly Amplifier _amplifier;
        private readonly Projector _projector;
        private readonly TheaterLights _lights;
        private readonly StreamingPlayer _player;

        public HomeTheaterFacade(Amplifier amp, Projector proj, TheaterLights lights, StreamingPlayer player)
        {
            _amplifier = amp;
            _projector = proj;
            _lights = lights;
            _player = player;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _lights.Dim(10);
            _projector.On();
            _projector.SetInput("Streaming Player");
            _amplifier.On();
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(8);
            _player.On();
            _player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("\nShutting movie theater down...");
            _player.Off();
            _amplifier.Off();
            _projector.Off();
            _lights.On();
        }
    }
}
