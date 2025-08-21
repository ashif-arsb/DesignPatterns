namespace DesignPatterns.Behavioral.Mediator
{
    public interface IAirTrafficControl
    {
        void RegisterAircraft(IAircraft aircraft);
        void SendMessage(string message, IAircraft sender);
    }
}
