using DesignPatterns.Factory.ConcreteProducts;
using DesignPatterns.Factory.Creators;
using DesignPatterns.Factory.Products;

namespace DesignPatterns.Factory.Concrete_Creators
{
    public class LinuxButtonFactory : ButtonFactory
    {
        public override IButton CreateButton()
        {
            return new LinuxButton();
        }
    }
}
