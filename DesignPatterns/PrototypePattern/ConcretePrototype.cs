namespace DesignPatterns.PrototypePattern
{
    public class ConcretePrototype : IProtoType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Items { get; set; }

        public ConcretePrototype(int id, string name, List<string> items)
        {
            Id = id;
            Name = name;
            Items = items;
        }

        public object Clone()
        {
            return new ConcretePrototype(this.Id, this.Name, [.. this.Items]);
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Items: {string.Join(", ", Items)}");
        }
    }
}
