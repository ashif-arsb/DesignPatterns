namespace DesignPatterns.Structural.Flyweight
{
    public class TreeFactory
    {
        private readonly Dictionary<string, ITreeType> _treeTypes = new Dictionary<string, ITreeType>();

        public ITreeType GetTreeType(string name, string color, byte[] texture)
        {
            string key = $"{name}-{color}";

            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
            }
            else
            {
                Console.WriteLine($"-> Reusing existing tree type: {name}");
            }

            return _treeTypes[key];
        }

        public void ListTreeTypes()
        {
            Console.WriteLine($"\nFactory has {_treeTypes.Count} tree types in total.");
        }
    }
}
