namespace DesignPatterns.Behavioral.Interpreter
{
    // Terminal expression
    public class NumberExpression : IExpression
    {
        private readonly int number;

        public NumberExpression(int number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return number;
        }
    }
}
