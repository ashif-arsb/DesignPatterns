namespace DesignPatterns.Creational.ObjectPoolPattern
{
    public class ObjectPoolPatternSimulation
    {
        public void Simulate()
        {
            Console.WriteLine("Starting Object Pool Example...");

            // Create a pool with 2 initial objects and a max of 5
            ExpensiveObjectPool pool = new(2, 5);

            // Acquire and use objects
            ExpensiveObject? obj1 = pool.Acquire();
            obj1?.Use();

            ExpensiveObject? obj2 = pool.Acquire();
            obj2?.Use();

            ExpensiveObject? obj3 = pool.Acquire(); // Will create a new one
            obj3?.Use();

            ExpensiveObject? obj4 = pool.Acquire(); // Will create a new one
            obj4?.Use();

            ExpensiveObject? obj5 = pool.Acquire(); // Will create a new one
            obj5?.Use();

            ExpensiveObject? obj6 = pool.Acquire(); // Pool exhausted
            obj6?.Use(); // This will not execute as obj6 is null

            Console.WriteLine("\nReleasing objects...");

            // Release objects back to the pool
            pool.Release(obj1);
            pool.Release(obj2);
            pool.Release(obj3);
            pool.Release(obj4);
            pool.Release(obj5);

            Console.WriteLine("\nAcquiring again after release...");

            ExpensiveObject? obj7 = pool.Acquire(); // Will acquire from pool
            obj7?.Use();

            ExpensiveObject? obj8 = pool.Acquire(); // Will acquire from pool
            obj8?.Use();

            Console.WriteLine("Object Pool Example Finished.");
        }
    }
}
