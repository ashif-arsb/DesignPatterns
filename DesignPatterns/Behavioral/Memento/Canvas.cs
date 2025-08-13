namespace DesignPatterns.Behavioral.Memento
{
    public class Canvas
    {
        private List<string> _shapes = new List<string>();

        public void AddShape(string shape)
        {
            _shapes.Add(shape);
        }

        public void Draw()
        {
            Console.WriteLine("--------------------");
            if (_shapes.Count == 0)
            {
                Console.WriteLine("Canvas is empty.");
            }
            else
            {
                _shapes.ForEach(s => Console.WriteLine(s));
            }
            Console.WriteLine("--------------------");
        }

        public CanvasMemento SaveState()
        {
            return new CanvasMemento(_shapes);
        }

        public void RestoreState(CanvasMemento memento)
        {
            if (memento != null)
            {
                _shapes = memento.GetShapes();
            }
        }
    }
}
