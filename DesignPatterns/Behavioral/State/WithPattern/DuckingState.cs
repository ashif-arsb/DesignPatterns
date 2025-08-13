namespace DesignPatterns.Behavioral.State.WithPattern
{
    public class DuckingState : ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "up")
            {
                character.SetState(new StandingState());
            }
        }
    }
}
