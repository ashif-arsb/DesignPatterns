namespace DesignPatterns.Behavioral.Visitor
{
    // Concrete Visitor for printing the AST
    public class PrintVisitor : IVisitor
    {
        public void VisitLiteral(Literal literal)
        {
            Console.Write(literal.Value);
        }

        public void VisitVariable(Variable variable)
        {
            Console.Write(variable.Name);
        }

        public void VisitBinaryExpression(BinaryExpression expression)
        {
            Console.Write("(");
            expression.Left.Accept(this);
            Console.Write($" {expression.Operator} ");
            expression.Right.Accept(this);
            Console.Write(")");
        }
    }
}
