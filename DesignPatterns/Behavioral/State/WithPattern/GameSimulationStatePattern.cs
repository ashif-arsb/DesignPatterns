namespace DesignPatterns.Behavioral.State.WithPattern
{
    public class GameSimulationStatePattern
    {
        private Character _character;

        public GameSimulationStatePattern()
        {
            _character = new Character();
        }

        public void Run()
        {
            Console.WriteLine("Game Simulation Started. Commands: 'up', 'down', 'quit'");

            string input;
            do
            {
                CharacterDrawerStatePattern.ClearConsoleAndDraw(_character.GetCurrentState());
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
