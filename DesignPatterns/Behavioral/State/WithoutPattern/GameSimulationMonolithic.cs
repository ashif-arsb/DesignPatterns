namespace DesignPatterns.Behavioral.State.WithoutPattern
{
    public class GameSimulationMonolithic
    {
        private readonly CharacterMonolithic _character;

        public GameSimulationMonolithic()
        {
            _character = new CharacterMonolithic();
        }

        public void Run()
        {
            Console.WriteLine("Game Simulation Started. Commands: 'up', 'down', 'quit'");

            string input;
            do
            {
                CharacterDrawerMonolithic.ClearConsoleAndDraw(_character.CurrentState);
                Console.Write("Enter command: ");
                input = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrEmpty(input) && input != "quit")
                {
                    _character.HandleInput(input);
                }
            } while (input != "quit");

            Console.WriteLine("Game Simulation Ended.");
        }
    }
}
