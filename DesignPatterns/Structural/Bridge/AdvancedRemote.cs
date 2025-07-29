namespace DesignPatterns.Structural.Bridge
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device) { }

        public void Mute()
        {
            _device.Mute();
        }

        public void Unmute()
        {
            _device.Unmute();
        }

        public void ChannelUp()
        {
            _device.ChannelUp();
        }

        public void ChannelDown()
        {
            _device.ChannelDown();
        }

        public override void Interact()
        {
            Console.WriteLine("\n--- Advanced Remote Interactions ---");
            TogglePower();
            _device.SetVolume(75);
            ChannelUp();
            ChannelUp();
            Mute();
            Console.WriteLine(_device.GetStatus());
            Unmute();
            _device.SetVolume(80);
            Console.WriteLine(_device.GetStatus());
            TogglePower();
            Console.WriteLine(_device.GetStatus());
        }
    }
}
