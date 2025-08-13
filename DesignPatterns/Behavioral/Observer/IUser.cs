namespace DesignPatterns.Behavioral.Observer
{
    // The Subject interface (user being followed)
    public interface IUser
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}
