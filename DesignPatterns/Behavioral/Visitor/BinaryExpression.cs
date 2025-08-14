namespace DesignPatterns.Behavioral.Visitor
{
    public class BinaryExpression : IExpression
    {
        public IExpression Left { get; }
        public IExpression Right { get; }
        public char Operator { get; }

        public BinaryExpression(IExpression left, IExpression right, char op)
        {
            Left = left;
            Right = right;
            Operator = op;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitBinaryExpression(this);
        }
    }
}
