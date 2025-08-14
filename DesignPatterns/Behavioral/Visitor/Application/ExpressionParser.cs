namespace DesignPatterns.Behavioral.Visitor.Application
{
    public class ExpressionParser
    {
        private readonly List<string> _tokens;
        private int _position;

        public ExpressionParser(List<string> tokens)
        {
            _tokens = tokens;
            _position = 0;
        }

        public IExpression Parse()
        {
            var expression = ParseExpression();
            if (_position != _tokens.Count)
            {
                throw new InvalidOperationException("Unexpected tokens after expression.");
            }
            return expression;
        }

        private IExpression ParseExpression()
        {
            var left = ParseTerm();

            while (_position < _tokens.Count)
            {
                var op = _tokens[_position];
                if (op == "+" || op == "-")
                {
                    _position++;
                    var right = ParseTerm();
                    left = new BinaryExpression(left, right, op[0]);
                }
                else
                {
                    break;
                }
            }

            return left;
        }

        private IExpression ParseTerm()
        {
            var left = ParseFactor();

            while (_position < _tokens.Count)
            {
                var op = _tokens[_position];
                if (op == "*" || op == "/")
                {
                    _position++;
                    var right = ParseFactor();
                    left = new BinaryExpression(left, right, op[0]);
                }
                else
                {
                    break;
                }
            }

            return left;
        }

        private IExpression ParseFactor()
        {
            var token = _tokens[_position];
            _position++;

            if (token == "(")
            {
                var expression = ParseExpression();
                if (_tokens[_position] != ")")
                {
                    throw new InvalidOperationException("Mismatched parentheses.");
                }
                _position++;
                return expression;
            }

            if (int.TryParse(token, out int value))
            {
                return new Literal(value);
            }

            return new Variable(token);
        }
    }
}
