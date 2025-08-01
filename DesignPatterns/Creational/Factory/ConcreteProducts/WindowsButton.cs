using DesignPatterns.Creational.Factory.Products;

namespace DesignPatterns.Creational.Factory.ConcreteProducts
{
    public class WindowsButton : IButton
    {
        public void Render() { Console.WriteLine("Rendering a Windows-style button."); }
        public void Click() { Console.WriteLine("Windows button clicked!"); }
    }
}
