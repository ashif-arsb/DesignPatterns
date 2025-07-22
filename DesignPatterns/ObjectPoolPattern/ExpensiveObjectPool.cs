using System.Collections.Concurrent;

namespace DesignPatterns.ObjectPoolPattern
{
    public class ExpensiveObjectPool
    {
        private readonly ConcurrentBag<ExpensiveObject> _pool;
        private readonly int _maxPoolSize;
        private int _currentObjectsCreated;

        public ExpensiveObjectPool(int initialPoolSize, int maxPoolSize)
        {
            _maxPoolSize = maxPoolSize;
            _pool = new ConcurrentBag<ExpensiveObject>();
            _currentObjectsCreated = 0;

            for (int i = 0; i < initialPoolSize; i++)
            {
                if (Interlocked.Increment(ref _currentObjectsCreated) <= _maxPoolSize)
                {
                    _pool.Add(new ExpensiveObject());
                }
                else
                {
                    Interlocked.Decrement(ref _currentObjectsCreated);
                    break;
                }
            }
        }

        public ExpensiveObject? Acquire()
        {
            if (_pool.TryTake(out var obj))
            {
                Console.WriteLine("Acquired existing object from pool.");
                return obj;
            }
            else
            {
                if (Interlocked.Increment(ref _currentObjectsCreated) <= _maxPoolSize)
                {
                    Console.WriteLine("Creating new object (pool was empty).");
                    return new ExpensiveObject();
                }
                else
                {
                    Interlocked.Decrement(ref _currentObjectsCreated);
                    Console.WriteLine("Pool exhausted. Cannot create more objects.");
                    return null;
                }
            }
        }

        public void Release(ExpensiveObject? obj)
        {
            if (obj != null)
            {
                obj.Reset();
                if (_pool.Count < _maxPoolSize)
                {
                    _pool.Add(obj);
                    Console.WriteLine("Object released back to pool.");
                }
                else
                {
                    Console.WriteLine("Pool is full, object discarded.");
                    Interlocked.Decrement(ref _currentObjectsCreated);
                }
            }
        }
    }
}
