namespace DesignPatterns.Behavioral.Interpreter
{
    // Non-terminal expression
    public class MinusExpression : IExpression
    {
        private readonly IExpression left;
        private readonly IExpression right;

        public MinusExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public int Interpret()
        {
            return left.Interpret() - right.Interpret();
        }
    }
}
