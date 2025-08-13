namespace DesignPatterns.Behavioral.CoR
{
    public abstract class BaseRequestHandler : IRequestHandler
    {
        private IRequestHandler _nextHandler;

        public IRequestHandler SetNext(IRequestHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void Handle(WebRequest request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(request);
            }
        }
    }
}
