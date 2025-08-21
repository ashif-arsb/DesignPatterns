namespace DesignPatterns.Behavioral.Mediator
{
    public class AirTrafficControl : IAirTrafficControl
    {
        private readonly List<IAircraft> _registeredAircraft = new List<IAircraft>();

        public void RegisterAircraft(IAircraft aircraft)
        {
            if (!_registeredAircraft.Contains(aircraft))
            {
                _registeredAircraft.Add(aircraft);
                aircraft.SetAirTrafficControl(this);
                Console.WriteLine($"ATC registered Aircraft: {aircraft.GetFlightNumber()}");
            }
        }

        public void SendMessage(string message, IAircraft sender)
        {
            Console.WriteLine($"\nATC is broadcasting message from {sender.GetFlightNumber()}: '{message}'");
            foreach (var aircraft in _registeredAircraft)
            {
                if (aircraft != sender)
                {
                    aircraft.ReceiveMessage($"Message from {sender.GetFlightNumber()}: {message}");
                }
            }
        }
    }
}
