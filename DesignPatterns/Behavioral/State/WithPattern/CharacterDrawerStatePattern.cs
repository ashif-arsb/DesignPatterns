namespace DesignPatterns.Behavioral.State.WithPattern
{
    public static class CharacterDrawerStatePattern
    {
        public static void DrawStanding()
        {
            Console.WriteLine("    O    ");
            Console.WriteLine("   /|\\  ");
            Console.WriteLine("   / \\  ");
            Console.WriteLine("=========");
        }

        public static void DrawJumping()
        {
            Console.WriteLine("   \\O/   ");
            Console.WriteLine("    |    ");
            Console.WriteLine("   / \\  ");
            Console.WriteLine("=========");
        }

        public static void DrawDucking()
        {
            Console.WriteLine("         ");
            Console.WriteLine("         ");
            Console.WriteLine("    O_   ");
            Console.WriteLine("   / \\  ");
            Console.WriteLine("=========");
        }

        public static void ClearConsoleAndDraw(ICharacterState state)
        {
            Console.Clear();
            Console.WriteLine("Current State: " + state.GetType().Name.Replace("State", ""));
            Console.WriteLine("---------------------");
            if (state is StandingState)
            {
                DrawStanding();
            }
            else if (state is JumpingState)
            {
                DrawJumping();
            }
            else if (state is DuckingState)
            {
                DrawDucking();
            }
            Console.WriteLine("---------------------");
        }
    }
}
