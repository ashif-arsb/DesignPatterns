namespace DesignPatterns.Behavioral.Iterator
{
    public class InOrderTreeIterator<T> : IEnumerator<T> where T : IComparable<T>
    {
        private readonly Stack<Node<T>> _stack;
        private Node<T>? _current;
        private bool _disposed = false;

        public InOrderTreeIterator(Node<T> root)
        {
            _stack = new Stack<Node<T>>();
            _current = root;
            PushLeftSubtree(root);
        }

        private void PushLeftSubtree(Node<T>? node)
        {
            while (node != null)
            {
                _stack.Push(node);
                node = node.Left;
            }
        }

        public T Current
        {
            get
            {
                if (_disposed)
                {
                    throw new ObjectDisposedException(nameof(InOrderTreeIterator<T>));
                }
                if (_current == null)
                {
                    throw new InvalidOperationException("Iterator has not started or has reached the end.");
                }
                return _current.Value;
            }
        }

        object System.Collections.IEnumerator.Current => this.Current;

        public bool MoveNext()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(InOrderTreeIterator<T>));
            }

            if (_stack.Count == 0)
            {
                _current = null;
                return false;
            }

            _current = _stack.Pop();
            PushLeftSubtree(_current.Right);
            return true;
        }

        public void Reset()
        {
            throw new NotSupportedException("Reset is not supported for this iterator.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _stack?.Clear();
                }
                _current = null;
                _disposed = true;
            }
        }
    }

}
