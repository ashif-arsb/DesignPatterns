namespace DesignPatterns.Behavioral.Interpreter
{
    public class InterpreterPatternSimulation
    {
        // Build the AST for "5 + 3 - 2"
        public void Simulate()
        {
            IExpression expression =
                new MinusExpression(
                    new PlusExpression(
                        new NumberExpression(5),
                        new NumberExpression(3)
                    ),
                    new NumberExpression(2)
                );

            int result = expression.Interpret();
            Console.WriteLine($"Result: {result}");
        }
    }
}
