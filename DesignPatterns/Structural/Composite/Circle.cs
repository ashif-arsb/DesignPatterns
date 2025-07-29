namespace DesignPatterns.Structural.Composite
{
    public class Circle : IDrawable
    {
        private int _x;
        private int _y;
        private readonly int _radius;
        private string _color;

        public Circle(int x, int y, int radius, string color)
        {
            _x = x;
            _y = y;
            _radius = radius;
            _color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {_color} Circle at ({_x},{_y}) with radius {_radius}.");
        }

        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
            Console.WriteLine($"Circle moved to ({_x},{_y}).");
        }

        public void ChangeColor(string color)
        {
            _color = color;
            Console.WriteLine($"Circle color changed to {_color}.");
        }
    }
}
