namespace DesignPatterns.Behavioral.Visitor
{
    // Concrete Elements
    public class Variable : IExpression
    {
        public string Name { get; }

        public Variable(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitVariable(this);
        }
    }
}
