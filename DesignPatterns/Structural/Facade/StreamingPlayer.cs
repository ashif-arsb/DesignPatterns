namespace DesignPatterns.Structural.Facade
{
    public class StreamingPlayer
    {
        public void On() => Console.WriteLine("Streaming player is on");
        public void Off() => Console.WriteLine("Streaming player is off");
        public void Play(string movie) => Console.WriteLine($"Streaming player is playing \"{movie}\"");
    }
}
