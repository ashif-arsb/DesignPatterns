namespace DesignPatterns.Structural.Flyweight
{
    public class Tree
    {
        // Extrinsic property
        private readonly int _x;
        private readonly int _y;

        // Intrinsic property
        private readonly ITreeType _type;

        public Tree(int x, int y, ITreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public void Draw()
        {
            _type.Draw(_x, _y);
        }
    }
}
