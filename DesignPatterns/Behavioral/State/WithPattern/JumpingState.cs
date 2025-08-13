namespace DesignPatterns.Behavioral.State.WithPattern
{
    public class JumpingState : ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "down")
            {
                character.SetState(new StandingState());
            }
        }
    }
}
