namespace DesignPatterns.Behavioral.Observer
{
    public class Follower : IObserver
    {
        public string Name { get; }

        public Follower(string name)
        {
            Name = name;
        }

        public void Update(IUser user)
        {
            if (user is SocialMediaUser socialUser)
            {
                string latestPost = socialUser.GetLatestPost();
                Console.WriteLine($"  {Name} received a notification: '{socialUser.UserName}' posted: '{latestPost}'");
            }
        }
    }
}
