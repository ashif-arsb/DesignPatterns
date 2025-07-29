namespace DesignPatterns.Structural.Composite
{
    public class CompositePatternSimulation
    {
        public void Simulate()
        {
            // Create individual shapes (leaves)
            IDrawable circle1 = new Circle(10, 20, 5, "Red");
            IDrawable square1 = new Square(30, 40, 10, "Blue");
            IDrawable circle2 = new Circle(50, 60, 7, "Green");

            // Create a group of shapes (composite)
            Group foregroundElements = new Group("Foreground Elements");
            foregroundElements.Add(circle1);
            foregroundElements.Add(square1);

            // Create another individual shape
            IDrawable line1 = new Square(100, 100, 2, "Black");

            // Create a larger group that contains both individual shapes and other groups
            Group entireScene = new Group("Entire Scene");
            entireScene.Add(foregroundElements);
            entireScene.Add(circle2);
            entireScene.Add(line1);

            Console.WriteLine("--- Initial Drawing ---");
            entireScene.Draw();

            Console.WriteLine("\n--- Moving the entire scene ---");
            entireScene.Move(5, 5);
            entireScene.Draw();

            Console.WriteLine("\n--- Changing color of foreground elements ---");
            foregroundElements.ChangeColor("Yellow");
            entireScene.Draw();
        }
    }
}
