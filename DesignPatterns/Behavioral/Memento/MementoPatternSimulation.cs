namespace DesignPatterns.Behavioral.Memento
{
    public class MementoPatternSimulation
    {
        public void Simulate()
        {
            Canvas canvas = new();
            History history = new();

            history.SaveState(canvas.SaveState());

            Console.WriteLine("Welcome to the interactive drawing app!");
            Console.WriteLine("Available commands: 'add <shape>', 'undo', 'redo', 'draw', 'exit'");

            while (true)
            {
                Console.Write("\nEnter a command: ");
                string? input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input)) continue;

                if (input == "exit")
                {
                    Console.WriteLine("Exiting application.");
                    break;
                }

                if (input.StartsWith("add "))
                {
                    string shape = input.Substring(4);
                    canvas.AddShape(shape);
                    history.SaveState(canvas.SaveState());
                    canvas.Draw();
                }
                else if (input == "undo")
                {
                    CanvasMemento? undoState = history.Undo();
                    if (undoState != null)
                    {
                        canvas.RestoreState(undoState);
                        canvas.Draw();
                    }
                    else
                    {
                        Console.WriteLine("Cannot undo further.");
                    }
                }
                else if (input == "redo")
                {
                    CanvasMemento? redoState = history.Redo();
                    if (redoState != null)
                    {
                        canvas.RestoreState(redoState);
                        canvas.Draw();
                    }
                    else
                    {
                        Console.WriteLine("Cannot redo further.");
                    }
                }
                else if (input == "draw")
                {
                    canvas.Draw();
                }
                else if (input == "cls")
                {
                    Console.Clear();
                    Console.WriteLine("Console cleared. Welcome back!");
                    Console.WriteLine("Available commands: 'add <shape>', 'undo', 'redo', 'draw', 'clear', 'exit'");
                }
                else
                {
                    Console.WriteLine("Unknown command. Please use 'add <shape>', 'undo', 'redo', 'draw', or 'exit'.");
                }
            }
        }
    }
}
