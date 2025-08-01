namespace DesignPatterns.Creational.BuilderPattern
{
    public class BuilderPatternSimulation
    {
        public void BuildCustomComputer()
        {
            try
            {
                Computer customComputer = new Computer.Builder()
                    .WithCpu("AMD Ryzen 9")
                    .WithRam("64GB")
                    .WithStorage("2TB NVMe SSD")
                    .WithGraphicsCard("NVIDIA GeForce RTX 4090")
                    .WithOperatingSystem("Linux Ubuntu")
                    .Build();
                customComputer.DisplayConfiguration();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error building custom computer: {ex.Message}");
            }
        }

        public void BuildComputersByDirector()
        {
            ComputerAssembler assembler = new ComputerAssembler();
            Computer.Builder computerBuilder = new Computer.Builder();

            Console.WriteLine("Building an office computer:");
            try
            {
                Computer officeComputer = assembler.AssembleOfficeComputer(computerBuilder);
                officeComputer.DisplayConfiguration();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error building office computer: {ex.Message}");
            }

            Console.WriteLine("\nBuilding a gaming computer:");
            computerBuilder = new Computer.Builder();
            try
            {
                Computer gamingComputer = assembler.AssembleGamingComputer(computerBuilder);
                gamingComputer.DisplayConfiguration();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error building gaming computer: {ex.Message}");
            }

            Console.WriteLine("\nBuilding a workstation computer (with optical drive):");
            computerBuilder = new Computer.Builder();
            try
            {
                Computer workstationComputer = assembler.AssembleWorkstationComputer(computerBuilder);
                workstationComputer.DisplayConfiguration();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error building workstation computer: {ex.Message}");
            }
        }
    }
}
