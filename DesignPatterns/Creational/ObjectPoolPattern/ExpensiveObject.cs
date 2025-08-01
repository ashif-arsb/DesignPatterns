namespace DesignPatterns.Creational.ObjectPoolPattern
{
    public class ExpensiveObject
    {
        private Guid _id;
        private bool _inUse;

        public ExpensiveObject()
        {
            _id = Guid.NewGuid();
            Console.WriteLine($"ExpensiveObject {_id} created.");
        }

        public void Use()
        {
            _inUse = true;
            Console.WriteLine($"ExpensiveObject {_id} is now in use.");
        }

        public void Reset()
        {
            _inUse = false;
            Console.WriteLine($"ExpensiveObject {_id} has been reset.");
        }

        public bool IsInUse => _inUse;
    }
}
