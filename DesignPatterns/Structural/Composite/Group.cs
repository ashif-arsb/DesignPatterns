namespace DesignPatterns.Structural.Composite
{
    public class Group : IDrawable
    {
        private readonly List<IDrawable> _children = new List<IDrawable>();
        private readonly string _name;

        public Group(string name)
        {
            _name = name;
        }

        public void Add(IDrawable component)
        {
            _children.Add(component);
            Console.WriteLine($"Added component to group '{_name}'.");
        }

        public void Remove(IDrawable component)
        {
            _children.Remove(component);
            Console.WriteLine($"Removed component from group '{_name}'.");
        }

        public void Draw()
        {
            Console.WriteLine($"\n--- Drawing Group: {_name} ---");
            foreach (var child in _children)
            {
                child.Draw();
            }
            Console.WriteLine($"--- Finished Drawing Group: {_name} ---\n");
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"\nMoving Group: {_name} by ({x},{y})...");
            foreach (var child in _children)
            {
                child.Move(x, y);
            }
            Console.WriteLine($"Finished Moving Group: {_name}.\n");
        }

        public void ChangeColor(string color)
        {
            Console.WriteLine($"\nChanging color of Group: {_name} to {color}...");
            foreach (var child in _children)
            {
                child.ChangeColor(color);
            }
            Console.WriteLine($"Finished changing color of Group: {_name}.\n");
        }
    }
}
