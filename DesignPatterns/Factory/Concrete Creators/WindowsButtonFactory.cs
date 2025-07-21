using DesignPatterns.Factory.ConcreteProducts;
using DesignPatterns.Factory.Creators;
using DesignPatterns.Factory.Products;

namespace DesignPatterns.Factory.Concrete_Creators
{
    public class WindowsButtonFactory : ButtonFactory
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
