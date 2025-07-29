namespace DesignPatterns.Structural.Flyweight
{
    public class Forest
    {
        private readonly List<Tree> _trees = new List<Tree>();
        private readonly TreeFactory _factory = new TreeFactory();

        public void PlantTree(int x, int y, string name, string color, byte[] texture)
        {
            ITreeType type = _factory.GetTreeType(name, color, texture);
            var tree = new Tree(x, y, type);
            _trees.Add(tree);
        }

        public void DrawForest()
        {
            foreach (var tree in _trees)
            {
                tree.Draw();
            }
            _factory.ListTreeTypes();
        }
    }
}
