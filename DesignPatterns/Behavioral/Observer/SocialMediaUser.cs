namespace DesignPatterns.Behavioral.Observer
{
    public class SocialMediaUser : IUser
    {
        private readonly List<IObserver> _followers = new List<IObserver>();
        private string _latestPost = string.Empty;

        public string UserName { get; }

        public SocialMediaUser(string userName)
        {
            UserName = userName;
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine($"{((Follower)observer).Name} started following {UserName}.");
            _followers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine($"{((Follower)observer).Name} unfollowed {UserName}.");
            _followers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine($"\n{UserName} is notifying all followers about a new post.");
            foreach (var follower in _followers)
            {
                follower.Update(this);
            }
        }

        public void CreateNewPost(string postContent)
        {
            _latestPost = postContent;
            Console.WriteLine($"\n--- NEW POST from {UserName} ---");
            Console.WriteLine($"Post content: '{_latestPost}'");
            Notify();
        }

        public string GetLatestPost() => _latestPost;
    }
}
