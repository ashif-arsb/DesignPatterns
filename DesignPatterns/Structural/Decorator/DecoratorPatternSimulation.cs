namespace DesignPatterns.Structural.Decorator
{
    public class DecoratorPatternSimulation
    {
        public void Simulate()
        {
            Console.WriteLine("Welcome to the Coffee Shop!");

            // Order 1: Simple Espresso
            Beverage espresso = new Espresso();
            Console.WriteLine($"Order 1: {espresso.GetDescription()} - ${espresso.Cost():F2}");

            // Order 2: Dark Roast with Milk
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Milk(darkRoast); // Decorate with Milk
            Console.WriteLine($"Order 2: {darkRoast.GetDescription()} - ${darkRoast.Cost():F2}");

            // Order 3: Latte with Milk and Sugar
            Beverage latte = new Latte();
            latte = new Milk(latte);       // Decorate with Milk
            latte = new Sugar(latte);      // Decorate with Sugar
            Console.WriteLine($"Order 3: {latte.GetDescription()} - ${latte.Cost():F2}");

            // Order 4: Espresso with Double Milk and Whipped Cream
            Beverage customEspresso = new Espresso();
            customEspresso = new Milk(customEspresso);
            customEspresso = new Milk(customEspresso); // Adding milk twice!
            customEspresso = new WhippedCream(customEspresso);
            Console.WriteLine($"Order 4: {customEspresso.GetDescription()} - ${customEspresso.Cost():F2}");
        }
    }
}
