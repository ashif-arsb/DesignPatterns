namespace DesignPatterns.AntiPattern.GoldenHammer
{
    // This is an over-engineered abstraction for a simple in-memory list.
    public interface IUserRepository
    {
        User GetById(int id);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }

    // The "Golden Hammer" implementation
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();

        public InMemoryUserRepository()
        {
            // Pre-populate with some data
            _users.Add(new User { Id = 1, Name = "Alice" });
            _users.Add(new User { Id = 2, Name = "Bob" });
        }

        public User GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Update(User user)
        {
            var existingUser = GetById(user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
            }
        }

        public void Delete(User user)
        {
            _users.RemoveAll(u => u.Id == user.Id);
        }
    }

    public class UserService
    {
        private readonly IUserRepository _userRepository = new InMemoryUserRepository();

        public void PrintAllUsers()
        {
            var users = _userRepository.GetAll();
            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
