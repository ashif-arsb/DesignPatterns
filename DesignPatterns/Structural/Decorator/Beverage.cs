namespace DesignPatterns.Structural.Decorator
{
    public abstract class Beverage
    {
        public string Description { get; protected set; } = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
