namespace DesignPatterns.Behavioral.Visitor
{
    public class VisitorPatternSimulation
    {
        public void Simulate()
        {
            // Build an AST: (x + 5) * 2
            var ast = new BinaryExpression(
                new BinaryExpression(
                    new Variable("x"),
                    new Literal(5),
                    '+'),
                new Literal(2),
                '*');

            // Print the AST
            var printVisitor = new PrintVisitor();
            ast.Accept(printVisitor);

            // Evaluate the AST with x = 10
            var variables = new Dictionary<string, int> { { "x", 10 } };
            var evaluationVisitor = new EvaluationVisitor(variables);
            ast.Accept(evaluationVisitor);
            Console.WriteLine($"\nResult: {evaluationVisitor.Result}");
        }
    }
}
