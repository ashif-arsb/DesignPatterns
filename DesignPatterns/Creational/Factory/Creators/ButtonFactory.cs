using DesignPatterns.Creational.Factory.Products;

namespace DesignPatterns.Creational.Factory.Creators
{
    public abstract class ButtonFactory
    {
        public abstract IButton CreateButton();

        public void CreateAndInteractWithButton()
        {
            IButton button = CreateButton();
            button.Render();
            button.Click();
            Console.WriteLine("Button created and interacted with.");
        }
    }
}
