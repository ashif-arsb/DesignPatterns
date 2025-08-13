namespace DesignPatterns.Behavioral.CoR
{
    public interface IRequestHandler
    {
        IRequestHandler SetNext(IRequestHandler handler);
        void Handle(WebRequest request);
    }
}
