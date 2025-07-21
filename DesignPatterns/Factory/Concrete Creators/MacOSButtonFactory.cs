using DesignPatterns.Factory.ConcreteProducts;
using DesignPatterns.Factory.Creators;
using DesignPatterns.Factory.Products;

namespace DesignPatterns.Factory.Concrete_Creators
{
    public class MacOSButtonFactory : ButtonFactory
    {
        public override IButton CreateButton()
        {
            return new MacOSButton();
        }
    }
}
