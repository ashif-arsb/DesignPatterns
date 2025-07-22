namespace DesignPatterns.LazyInitializationPattern
{
    public class MyServiceWithLazy
    {
        private readonly Lazy<ExpensiveResource> _lazyResource = new Lazy<ExpensiveResource>(() => new ExpensiveResource());

        public ExpensiveResource Resource
        {
            get
            {
                return _lazyResource.Value;
            }
        }

        public void PerformOperation()
        {
            Console.WriteLine("Performing an operation in MyServiceWithLazy.");
            Resource.DoSomething();
        }
    }
}
