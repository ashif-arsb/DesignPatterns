namespace DesignPatterns.Behavioral.State.WithoutPattern
{
    public static class CharacterDrawerMonolithic
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

        public static void ClearConsoleAndDraw(CharacterState state)
        {
            Console.Clear();
            Console.WriteLine("Current State: " + state);
            Console.WriteLine("---------------------");
            switch (state)
            {
                case CharacterState.Standing:
                    DrawStanding();
                    break;
                case CharacterState.Jumping:
                    DrawJumping();
                    break;
                case CharacterState.Ducking:
                    DrawDucking();
                    break;
            }
            Console.WriteLine("---------------------");
        }
    }
}
