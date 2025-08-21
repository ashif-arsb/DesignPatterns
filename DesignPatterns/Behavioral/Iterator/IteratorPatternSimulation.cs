namespace DesignPatterns.Behavioral.Iterator
{
    public class IteratorPatternSimulation
    {
        public void Simulate()
        {
            var bst = new BinarySearchTree<int>();

            Console.WriteLine("Binary Search Tree Builder");
            Console.WriteLine("Enter numbers to add to the tree.");

            while (true)
            {
                Console.Write("\nEnter a number or a command ('exit'/'quit'/'print'/'traverse'/'reset'): ");
                string? input = Console.ReadLine()?.ToLower();

                if (input == "exit" || input == "quit")
                {
                    break;
                }
                else if (input == "print")
                {
                    Console.Clear();
                    Console.WriteLine("Printing tree structure:");
                    bst.PrintTree();
                }
                else if (input == "traverse")
                {
                    Console.Clear();
                    Console.WriteLine("\nPrinting tree structure:");
                    bst.PrintTree();

                    Console.WriteLine("Traversing tree using the Iterator pattern:");
                    foreach (var item in bst)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
                else if (input == "reset")
                {
                    bst.Clear();
                    Console.Clear();
                    Console.WriteLine("Tree has been reset.");
                }
                else if (int.TryParse(input, out int number))
                {
                    bst.Insert(number);
                    Console.Clear();
                    Console.WriteLine("Added node. New tree structure:");
                    bst.PrintTree();
                }
                else
                {
                    Console.WriteLine("Invalid command or input.");
                }
            }
        }
    }
}
