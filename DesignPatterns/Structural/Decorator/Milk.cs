namespace DesignPatterns.Structural.Decorator
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage)
        {
            
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Milk";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.20;
        }
    }
}
