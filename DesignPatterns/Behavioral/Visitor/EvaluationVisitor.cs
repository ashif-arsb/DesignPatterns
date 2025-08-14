namespace DesignPatterns.Behavioral.Visitor
{
    // Concrete Visitor for evaluating the expression
    public class EvaluationVisitor : IVisitor
    {
        public int Result { get; private set; }
        private readonly Dictionary<string, int> _variables;

        public EvaluationVisitor(Dictionary<string, int> variables)
        {
            _variables = variables;
        }

        public void VisitLiteral(Literal literal)
        {
            Result = literal.Value;
        }

        public void VisitVariable(Variable variable)
        {
            if (_variables.TryGetValue(variable.Name, out var value))
            {
                Result = value;
            }
            else
            {
                throw new InvalidOperationException($"Variable '{variable.Name}' not found.");
            }
        }

        public void VisitBinaryExpression(BinaryExpression expression)
        {
            expression.Left.Accept(this);
            var leftValue = Result;

            expression.Right.Accept(this);
            var rightValue = Result;

            switch (expression.Operator)
            {
                case '+': Result = leftValue + rightValue; break;
                case '-': Result = leftValue - rightValue; break;
                case '*': Result = leftValue * rightValue; break;
                case '/': Result = leftValue / rightValue; break;
            }
        }
    }
}
