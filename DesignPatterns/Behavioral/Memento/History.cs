namespace DesignPatterns.Behavioral.Memento
{
    public class History
    {
        private readonly Stack<CanvasMemento> _undoStack = new();
        private readonly Stack<CanvasMemento> _redoStack = new();

        public void SaveState(CanvasMemento memento)
        {
            _undoStack.Push(memento);
            _redoStack.Clear();
        }

        public CanvasMemento? Undo()
        {
            if (_undoStack.Count > 1)
            {
                CanvasMemento lastState = _undoStack.Pop();
                _redoStack.Push(lastState);
                return _undoStack.Peek();
            }
            return null;
        }

        public CanvasMemento? Redo()
        {
            if (_redoStack.Count > 0)
            {
                CanvasMemento restoredState = _redoStack.Pop();
                _undoStack.Push(restoredState);
                return restoredState;
            }
            return null;
        }
    }
}
