namespace DesignPatterns.Behavioral.Mediator
{
    public class MediatorPatternSimulation
    {
        public void Simulate()
        {
            var atc = new AirTrafficControl();

            var boeing747 = new Aircraft("Boeing 747");
            var airbusA380 = new Aircraft("Airbus A380");
            var cessna172 = new Aircraft("Cessna 172");

            atc.RegisterAircraft(boeing747);
            atc.RegisterAircraft(airbusA380);
            atc.RegisterAircraft(cessna172);

            boeing747.RequestTakeoff();
            airbusA380.RequestTakeoff();
            cessna172.RequestTakeoff();
        }
    }
}
