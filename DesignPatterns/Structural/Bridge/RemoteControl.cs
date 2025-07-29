namespace DesignPatterns.Structural.Bridge
{
    public abstract class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.GetStatus().Contains("Off"))
            {
                _device.PowerOn();
            }
            else
            {
                _device.PowerOff();
            }
        }

        public void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 10);
        }

        public void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        public abstract void Interact();
    }
}
