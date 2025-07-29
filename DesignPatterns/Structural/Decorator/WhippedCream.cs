namespace DesignPatterns.Structural.Decorator
{
    public class WhippedCream : CondimentDecorator
    {
        public WhippedCream(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whipped Cream";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.50;
        }
    }
}
