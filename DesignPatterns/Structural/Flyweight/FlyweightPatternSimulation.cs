namespace DesignPatterns.Structural.Flyweight
{
    public class FlyweightPatternSimulation
    {
        public void Simulate()
        {
            var forest = new Forest();

            byte[] oakTexture = new byte[1024 * 1024];
            byte[] pineTexture = new byte[1024 * 1024];

            Console.WriteLine("Planting trees...\n");

            // Plant 5 trees, but only 2 unique types
            forest.PlantTree(10, 20, "Oak", "Brown", oakTexture);
            forest.PlantTree(50, 100, "Oak", "Brown", oakTexture);
            forest.PlantTree(200, 30, "Oak", "Brown", oakTexture);
            forest.PlantTree(75, 80, "Pine", "Green", pineTexture);
            forest.PlantTree(150, 250, "Pine", "Green", pineTexture);

            Console.WriteLine("\nDrawing the forest...\n");
            forest.DrawForest();
        }
    }
}
