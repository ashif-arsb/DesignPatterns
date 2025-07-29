namespace DesignPatterns.Structural.Bridge
{
    public class TV : IDevice
    {
        private bool _isOn = false;
        private int _volume = 50;
        private int _channel = 1;
        private bool _isMuted = false;

        public void PowerOn()
        {
            _isOn = true;
            Console.WriteLine("TV is ON.");
        }

        public void PowerOff()
        {
            _isOn = false;
            Console.WriteLine("TV is OFF.");
        }

        public void SetVolume(int level)
        {
            if (_isOn && !_isMuted)
            {
                _volume = Math.Clamp(level, 0, 100);
                Console.WriteLine($"TV Volume set to: {_volume}");
            }
            else if (_isMuted)
            {
                Console.WriteLine("TV is muted. Unmute to change volume.");
            }
            else
            {
                Console.WriteLine("TV is off. Turn on to change volume.");
            }
        }

        public void Mute()
        {
            if (_isOn)
            {
                _isMuted = true;
                Console.WriteLine("TV Muted.");
            }
        }

        public void Unmute()
        {
            if (_isOn)
            {
                _isMuted = false;
                Console.WriteLine("TV Unmuted.");
            }
        }

        public void ChannelUp()
        {
            if (_isOn)
            {
                _channel++;
                Console.WriteLine($"TV Channel Up: {_channel}");
            }
        }

        public void ChannelDown()
        {
            if (_isOn)
            {
                _channel--;
                Console.WriteLine($"TV Channel Down: {_channel}");
            }
        }

        public string GetStatus()
        {
            return $"TV Status: {(_isOn ? "On" : "Off")}, Volume: {_volume}, Channel: {_channel}, Muted: {_isMuted}";
        }

        public int GetVolume()
        {
            return _volume;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public double GetFrequencyMHz()
        {
            return 0.0;
        }
    }
}
