using DesignPatterns.Factory.Products;

namespace DesignPatterns.Factory.ConcreteProducts
{
    public class WindowsButton : IButton
    {
        public void Render() { Console.WriteLine("Rendering a Windows-style button."); }
        public void Click() { Console.WriteLine("Windows button clicked!"); }
    }
}
