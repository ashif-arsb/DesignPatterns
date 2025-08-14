namespace DesignPatterns.Behavioral.Visitor
{
    // Element interface
    public interface IExpression
    {
        void Accept(IVisitor visitor);
    }
}
