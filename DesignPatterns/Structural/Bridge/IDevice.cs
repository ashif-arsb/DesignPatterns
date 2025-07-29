namespace DesignPatterns.Structural.Bridge
{
    public interface IDevice
    {
        void PowerOn();
        void PowerOff();
        int GetVolume();
        void SetVolume(int level);
        void Mute();
        void Unmute();
        int GetChannel();
        double GetFrequencyMHz();
        void ChannelUp();
        void ChannelDown();
        string GetStatus();
    }
}
