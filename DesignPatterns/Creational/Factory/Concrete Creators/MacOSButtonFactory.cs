using DesignPatterns.Creational.Factory.Creators;
using DesignPatterns.Creational.Factory.Products;
using DesignPatterns.Factory.ConcreteProducts;

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
