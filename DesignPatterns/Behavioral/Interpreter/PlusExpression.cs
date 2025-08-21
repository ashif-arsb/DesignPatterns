namespace DesignPatterns.Behavioral.Interpreter
{
    // Non-terminal expression
    public class PlusExpression : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public PlusExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret()
        {
            return left.Interpret() + right.Interpret();
        }
    }
}
