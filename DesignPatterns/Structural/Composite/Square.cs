namespace DesignPatterns.Structural.Composite
{
    public class Square : IDrawable
    {
        private int _x;
        private int _y;
        private readonly int _side;
        private string _color;

        public Square(int x, int y, int side, string color)
        {
            _x = x;
            _y = y;
            _side = side;
            _color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {_color} Square at ({_x},{_y}) with side {_side}.");
        }

        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
            Console.WriteLine($"Square moved to ({_x},{_y}).");
        }

        public void ChangeColor(string color)
        {
            _color = color;
            Console.WriteLine($"Square color changed to {_color}.");
        }
    }
}
