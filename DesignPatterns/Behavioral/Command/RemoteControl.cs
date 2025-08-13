namespace DesignPatterns.Behavioral.Command
{
    public class RemoteControl
    {
        private ICommand? _slot;

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot?.Execute();
        }

        public void ButtonWasUndone()
        {
            _slot?.Undo();
        }
    }
}
