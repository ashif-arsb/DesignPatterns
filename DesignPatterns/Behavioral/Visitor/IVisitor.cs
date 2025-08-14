namespace DesignPatterns.Behavioral.Visitor
{
    // Visitor interface
    public interface IVisitor
    {
        void VisitLiteral(Literal literal);
        void VisitVariable(Variable variable);
        void VisitBinaryExpression(BinaryExpression expression);
    }
}
