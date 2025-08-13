namespace DesignPatterns.Behavioral.State.WithPattern
{
    public class StandingState : ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "up")
            {
                character.SetState(new JumpingState());
            }
            else if (input == "down")
            {
                character.SetState(new DuckingState());
            }
        }
    }
}
