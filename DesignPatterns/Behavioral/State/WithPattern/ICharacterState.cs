namespace DesignPatterns.Behavioral.State.WithPattern
{
    public interface ICharacterState
    {
        void HandleInput(Character character, string input);
    }
}
