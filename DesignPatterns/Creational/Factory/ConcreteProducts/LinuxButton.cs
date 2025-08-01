using DesignPatterns.Creational.Factory.Products;

namespace DesignPatterns.Creational.Factory.ConcreteProducts
{
    public class LinuxButton : IButton
    {
        public void Render() { Console.WriteLine("Displaying a Linux-style button."); }
        public void Click() { Console.WriteLine("Linux button triggered!"); }
    }
}
