namespace DesignPatterns.Behavioral.Observer
{
    // The Observer interface (follower)
    public interface IObserver
    {
        void Update(IUser user);
    }
}
