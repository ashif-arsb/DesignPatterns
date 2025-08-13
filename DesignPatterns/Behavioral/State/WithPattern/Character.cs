namespace DesignPatterns.Behavioral.State.WithPattern
{
    public class Character
    {
        private ICharacterState _currentState;

        public Character()
        {
            _currentState = new StandingState();
        }

        public ICharacterState GetCurrentState() => _currentState;

        public void SetState(ICharacterState newState) => _currentState = newState;

        public void HandleInput(string input)
        {
            _currentState.HandleInput(this, input);
        }
    }
}
