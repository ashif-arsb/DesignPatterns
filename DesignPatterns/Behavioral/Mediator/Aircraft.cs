namespace DesignPatterns.Behavioral.Mediator
{
    public class Aircraft : IAircraft
    {
        private IAirTrafficControl? _atc;
        private readonly string _flightNumber;

        public Aircraft(string flightNumber)
        {
            _flightNumber = flightNumber;
        }

        public void SetAirTrafficControl(IAirTrafficControl atc)
        {
            _atc = atc;
        }

        public string GetFlightNumber()
        {
            return _flightNumber;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Aircraft {_flightNumber} received: '{message}'");
        }

        public void RequestTakeoff()
        {
            Console.WriteLine($"Aircraft {_flightNumber} is requesting takeoff.");
            _atc.SendMessage("Requesting takeoff.", this);
        }
    }

}
