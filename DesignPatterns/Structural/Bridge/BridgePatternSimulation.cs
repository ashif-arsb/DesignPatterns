namespace DesignPatterns.Structural.Bridge
{
    public class BridgePatternSimulation
    {
        public void Simulate()
        {
            Console.WriteLine("Using Basic Remote with TV:");
            IDevice tv = new TV();
            RemoteControl basicTVRemote = new BasicRemote(tv);
            basicTVRemote.Interact();

            Console.WriteLine("\nUsing Basic Remote with Radio:");
            IDevice radio = new Radio();
            RemoteControl basicRadioRemote = new BasicRemote(radio);
            basicRadioRemote.Interact();

            Console.WriteLine("\nUsing Advanced Remote with TV:");
            RemoteControl advancedTVRemote = new AdvancedRemote(new TV());
            advancedTVRemote.Interact();

            Console.WriteLine("\nUsing Advanced Remote with Radio:");
            RemoteControl advancedRadioRemote = new AdvancedRemote(new Radio());
            advancedRadioRemote.Interact();
        }
    }
}
