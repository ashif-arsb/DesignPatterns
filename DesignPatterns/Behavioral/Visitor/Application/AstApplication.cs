namespace DesignPatterns.Behavioral.Visitor.Application
{
    public class AstApplication
    {
        private readonly Dictionary<string, int> _variables = new();
        private IExpression? _storedExpression = null;

        public void Run()
        {
            Console.WriteLine("Expression Interpreter. Type 'exit' to quit.");
            Console.WriteLine("Commands: cls, var x = 5, exp (x + 2) * 3, print, evaluate");

            while (true)
            {
                Console.Write("> ");
                string command = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(command) || command.ToLower() == "exit")
                {
                    break;
                }

                ProcessCommand(command);
            }
        }

        private void ProcessCommand(string command)
        {
            var parts = command.Split(' ', 2);
            string action = parts[0].ToLower();

            try
            {
                switch (action)
                {
                    case "cls":
                        Console.Clear();
                        ShowHelpMessage();
                        break;

                    case "var":
                        ParseVariable(parts[1]);
                        Console.WriteLine("Variable stored.");
                        break;
                    case "exp":
                        _storedExpression = ParseExpression(parts[1]);
                        Console.WriteLine("Expression stored.");
                        break;
                    case "print":
                        if (_storedExpression != null)
                        {
                            var printVisitor = new PrintVisitor();
                            _storedExpression.Accept(printVisitor);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No expression to print.");
                        }
                        break;
                    case "evaluate":
                        if (_storedExpression != null)
                        {
                            var evalVisitor = new EvaluationVisitor(_variables);
                            _storedExpression.Accept(evalVisitor);
                            Console.WriteLine($"Result: {evalVisitor.Result}");
                        }
                        else
                        {
                            Console.WriteLine("No expression to evaluate.");
                        }
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void ShowHelpMessage()
        {
            Console.WriteLine("Expression Interpreter. Type 'exit' to quit.");
            Console.WriteLine("Commands: cls, var x = 5, exp (x + 2) * 3, print, evaluate");
        }

        private void ParseVariable(string declaration)
        {
            var parts = declaration.Split('=', 2);
            if (parts.Length == 2 && parts[0].Trim().Length > 0)
            {
                string varName = parts[0].Trim();
                int varValue = int.Parse(parts[1].Trim());
                _variables[varName] = varValue;
            }
            else
            {
                throw new ArgumentException("Invalid variable declaration format.");
            }
        }

        private IExpression? ParseExpression(string expression)
        {
            var tokens = Tokenize(expression);
            if (tokens.Count == 0) return null;

            var parser = new ExpressionParser(tokens);
            return parser.Parse();
        }

        private static List<string> Tokenize(string expression)
        {
            var tokens = new List<string>();
            var currentTokenBuilder = new System.Text.StringBuilder();

            foreach (char c in expression.Replace(" ", ""))
            {
                if (char.IsLetter(c) || char.IsDigit(c))
                {
                    currentTokenBuilder.Append(c);
                }
                else if (c == '(' || c == ')' || c == '+' || c == '-' || c == '*' || c == '/')
                {
                    if (currentTokenBuilder.Length > 0)
                    {
                        tokens.Add(currentTokenBuilder.ToString());
                        currentTokenBuilder.Clear();
                    }
                    tokens.Add(c.ToString());
                }
                else
                {
                    throw new ArgumentException($"Invalid character in expression: {c}");
                }
            }

            if (currentTokenBuilder.Length > 0)
            {
                tokens.Add(currentTokenBuilder.ToString());
            }

            return tokens;
        }
    }
}
