namespace DesignPatterns.Behavioral.Command
{
    public class CommandPatternSimulation
    {
        public void Simulate()
        {
            var remote = new RemoteControl();
            var livingRoomLight = new Light("Living Room");

            var lightOn = new LightOnCommand(livingRoomLight);
            var lightOff = new LightOffCommand(livingRoomLight);

            // Turn the light on
            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.ButtonWasUndone();

            // Turn the light off
            remote.SetCommand(lightOff);
            remote.ButtonWasPressed();
            remote.ButtonWasUndone();
        }
    }
}
