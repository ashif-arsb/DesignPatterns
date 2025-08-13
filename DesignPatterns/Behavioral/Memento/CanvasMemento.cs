namespace DesignPatterns.Behavioral.Memento
{
    public class CanvasMemento
    {
        private readonly List<string> _shapes;

        public CanvasMemento(List<string> shapes)
        {
            _shapes = [.. shapes];
        }

        public List<string> GetShapes()
        {
            return [.. _shapes];
        }
    }
}
