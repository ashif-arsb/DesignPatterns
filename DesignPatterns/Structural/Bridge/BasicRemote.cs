namespace DesignPatterns.Structural.Bridge
{
    public class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device) { }

        public override void Interact()
        {
            Console.WriteLine("\n--- Basic Remote Interactions ---");
            TogglePower();
            _device.SetVolume(60);
            Console.WriteLine(_device.GetStatus());
        }
    }
}
