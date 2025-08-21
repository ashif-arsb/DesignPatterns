namespace DesignPatterns.Behavioral.Mediator
{
    public interface IAircraft
    {
        void SetAirTrafficControl(IAirTrafficControl atc);
        void ReceiveMessage(string message);
        string GetFlightNumber();
    }
}
