using DesignPatterns.Factory.Products;

namespace DesignPatterns.Factory.ConcreteProducts
{
    public class MacOSButton : IButton
    {
        public void Render() { Console.WriteLine("Drawing a macOS-style button."); }
        public void Click() { Console.WriteLine("macOS button action performed!"); }
    }
}
