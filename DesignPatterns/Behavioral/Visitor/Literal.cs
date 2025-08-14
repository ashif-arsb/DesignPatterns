namespace DesignPatterns.Behavioral.Visitor
{
    // Concrete Elements
    public class Literal : IExpression
    {
        public int Value { get; }

        public Literal(int value)
        {
            Value = value;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLiteral(this);
        }
    }
}
