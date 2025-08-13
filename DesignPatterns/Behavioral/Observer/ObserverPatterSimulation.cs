namespace DesignPatterns.Behavioral.Observer
{
    public class ObserverPatterSimulation
    {
        public void Simulate()
        {
            // The subject
            var influencer = new SocialMediaUser("TechGuru");

            // The observers
            var user1 = new Follower("Alice");
            var user2 = new Follower("Bob");
            var user3 = new Follower("Charlie");

            // Alice and Bob start following TechGuru
            influencer.Attach(user1);
            influencer.Attach(user2);

            // TechGuru posts something
            influencer.CreateNewPost("Just released a new video on async programming!");

            // Charlie starts following
            influencer.Attach(user3);

            // TechGuru posts again
            influencer.CreateNewPost("My new article on C# generics is live!");

            // Alice unfollows TechGuru
            influencer.Detach(user1);

            // TechGuru posts one last time
            influencer.CreateNewPost("I'm speaking at the DevCon conference next month!");
        }
    }
}
