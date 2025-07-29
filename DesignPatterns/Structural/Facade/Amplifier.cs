namespace DesignPatterns.Structural.Facade
{
    public class Amplifier
    {
        public void On() => Console.WriteLine("Amplifier is on");
        public void Off() => Console.WriteLine("Amplifier is off");
        public void SetSurroundSound() => Console.WriteLine("Amplifier set to surround sound mode");
        public void SetVolume(int level) => Console.WriteLine($"Amplifier volume set to {level}");
    }
}
