namespace DesignPatterns.Behavioral.State.WithoutPattern
{
    public enum CharacterState
    {
        Standing,
        Jumping,
        Ducking
    }

    public class CharacterMonolithic
    {
        public CharacterState CurrentState { get; private set; }

        public CharacterMonolithic()
        {
            CurrentState = CharacterState.Standing;
        }

        public void HandleInput(string input)
        {
            Console.WriteLine($"Input received: '{input}'");
            switch (CurrentState)
            {
                case CharacterState.Standing:
                    if (input == "up")
                    {
                        CurrentState = CharacterState.Jumping;
                    }
                    else if (input == "down")
                    {
                        CurrentState = CharacterState.Ducking;
                    }
                    break;

                case CharacterState.Jumping:
                    if (input == "down")
                    {
                        CurrentState = CharacterState.Standing;
                    }
                    break;

                case CharacterState.Ducking:
                    if (input == "up")
                    {
                        CurrentState = CharacterState.Standing;
                    }
                    break;
            }
        }
    }
}
