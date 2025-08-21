using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private Node<T>? root;

        public void Insert(T value)
        {
            var newNode = new Node<T>(value);

            if (root == null)
            {
                root = newNode;
                return;
            }

            var current = root;

            while (true)
            {
                if (value.CompareTo(current.Value) < 0)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        break;
                    }
                    current = current.Right;
                }
            }
        }

        public void Clear()
        {
            root = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (root == null)
            {
                throw new InvalidOperationException("Binary search tree has no node to iterate.");
            }

            return new InOrderTreeIterator<T>(root);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void PrintTree()
        {
            PrintTree(root, 0);
        }

        private void PrintTree(Node<T>? node, int depth)
        {
            if (node == null)
            {
                return;
            }

            PrintTree(node.Right, depth + 1);

            Console.WriteLine(new string(' ', depth * 4) + node.Value);

            PrintTree(node.Left, depth + 1);
        }
    }
}
