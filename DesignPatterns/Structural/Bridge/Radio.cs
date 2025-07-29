namespace DesignPatterns.Structural.Bridge
{
    public class Radio : IDevice
    {
        private bool _isOn = false;
        private int _volume = 30;
        private double _frequency = 98.5;
        private bool _isMuted = false;

        public void PowerOn()
        {
            _isOn = true;
            Console.WriteLine("Radio is ON.");
        }

        public void PowerOff()
        {
            _isOn = false;
            Console.WriteLine("Radio is OFF.");
        }

        public void SetVolume(int level)
        {
            if (_isOn && !_isMuted)
            {
                _volume = Math.Clamp(level, 0, 100);
                Console.WriteLine($"Radio Volume set to: {_volume}");
            }
            else if (_isMuted)
            {
                Console.WriteLine("Radio is muted. Unmute to change volume.");
            }
            else
            {
                Console.WriteLine("Radio is off. Turn on to change volume.");
            }
        }

        public void Mute()
        {
            if (_isOn)
            {
                _isMuted = true;
                Console.WriteLine("Radio Muted.");
            }
        }

        public void Unmute()
        {
            if (_isOn)
            {
                _isMuted = false;
                Console.WriteLine("Radio Unmuted.");
            }
        }

        public void ChannelUp() // For radio, this might mean tuning up frequency
        {
            if (_isOn)
            {
                _frequency += 0.1;
                Console.WriteLine($"Radio Frequency Up: {_frequency:F1} MHz");
            }
        }

        public void ChannelDown() // For radio, this might mean tuning down frequency
        {
            if (_isOn)
            {
                _frequency -= 0.1;
                Console.WriteLine($"Radio Frequency Down: {_frequency:F1} MHz");
            }
        }

        public string GetStatus()
        {
            return $"Radio Status: {(_isOn ? "On" : "Off")}, Volume: {_volume}, Frequency: {_frequency:F1} MHz, Muted: {_isMuted}";
        }

        public int GetVolume()
        {
            return _volume;
        }

        public int GetChannel()
        {
            return 0;
        }

        public double GetFrequencyMHz()
        {
            return _frequency;
        }
    }
}
