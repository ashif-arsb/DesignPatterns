namespace DesignPatterns.Structural.Decorator
{
    public class Latte : Beverage
    {
        public Latte()
        {
            Description = "Latte";
        }

        public override double Cost()
        {
            return 2.50;
        }
    }
}
