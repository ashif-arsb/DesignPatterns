namespace DesignPatterns.Creational.PrototypePattern
{
    public class PrototypePatternSimulation
    {
        public void Simulate()
        {
            List<string> initialItems = new List<string> { "Apple", "Banana" };
            ConcretePrototype original = new ConcretePrototype(1, "Original Object", initialItems);
            Console.Write("Original Object: ");
            original.Display();

            ConcretePrototype cloned1 = (ConcretePrototype)original.Clone();
            cloned1.Id = 2;
            cloned1.Name = "Cloned Object 1";
            cloned1.Items.Add("Cherry");
            Console.Write("Cloned Object 1: ");
            cloned1.Display();

            ConcretePrototype cloned2 = (ConcretePrototype)original.Clone();
            cloned2.Id = 3;
            cloned2.Name = "Cloned Object 2";
            cloned2.Items.Remove("Banana");
            Console.Write("Cloned Object 2: ");
            cloned2.Display();

            Console.Write("Original Object (after clones modified): ");
            original.Display();
        }
    }
}
