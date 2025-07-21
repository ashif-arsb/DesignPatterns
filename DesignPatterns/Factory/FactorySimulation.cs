using DesignPatterns.Factory.Concrete_Creators;
using DesignPatterns.Factory.Creators;
using DesignPatterns.Factory.Products;

namespace DesignPatterns.Factory
{
    public class FactorySimulation
    {
        private readonly ButtonFactory _factory;
        public FactorySimulation(string osType)
        {
            if (osType.Equals("Windows", StringComparison.OrdinalIgnoreCase))
            {
                _factory = new WindowsButtonFactory();
            }
            else if (osType.Equals("MacOS", StringComparison.OrdinalIgnoreCase))
            {
                _factory = new MacOSButtonFactory();
            }
            else if (osType.Equals("Linux", StringComparison.OrdinalIgnoreCase))
            {
                _factory = new LinuxButtonFactory();
            }
            else
            {
                throw new ArgumentException("Unsupported OS type.");
            }
        }

        public void Simulate()
        {
            Console.WriteLine($"Running application on {_factory.GetType().Name.Replace("ButtonFactory", "")}...");
            //IButton myButton = _factory.CreateButton();
            //myButton.Render();
            //myButton.Click();

            _factory.CreateAndInteractWithButton();
        }
    }
}
