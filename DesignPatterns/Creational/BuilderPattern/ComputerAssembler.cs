namespace DesignPatterns.Creational.BuilderPattern
{
    public class ComputerAssembler
    {
        public Computer AssembleOfficeComputer(Computer.Builder builder)
        {
            return builder
                .WithCpu("Intel i5")
                .WithRam("8GB")
                .WithStorage("256GB SSD")
                .WithOperatingSystem("Windows 10 Pro")
                .Build();
        }

        public Computer AssembleGamingComputer(Computer.Builder builder)
        {
            return builder
                .WithCpu("Intel i9")
                .WithRam("32GB")
                .WithStorage("1TB NVMe SSD")
                .WithGraphicsCard("NVIDIA GeForce RTX 4080")
                .WithOperatingSystem("Windows 11 Home")
                .Build();
        }

        public Computer AssembleWorkstationComputer(Computer.Builder builder)
        {
            return builder
                .WithCpu("AMD Ryzen 7")
                .WithRam("16GB")
                .WithStorage("512GB SSD")
                .WithOpticalDrive()
                .Build();
        }
    }
}
