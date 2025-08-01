namespace DesignPatterns.Structural.Flyweight
{
    public class TreeType : ITreeType
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public byte[] Texture { get; private set; }

        public TreeType(string name, string color, byte[] texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
            Console.WriteLine($"-> Creating new tree type: {Name} (Heavy object)");
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Drawing a {Name} tree of color {Color} at ({x}, {y})");
        }
    }
}
