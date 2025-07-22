namespace DesignPatterns.BuilderPattern
{
    public class Computer
    {
        public string? CPU { get; set; }
        public string? RAM { get; set; } // e.g., "8GB", "16GB"
        public string? Storage { get; set; } // e.g., "256GB SSD", "1TB HDD"
        public string? GraphicsCard { get; set; }
        public string? OperatingSystem { get; set; }
        public bool HasOpticalDrive { get; set; } = false;

        // Private constructor to enforce construction through the builder
        private Computer() { }

        public void DisplayConfiguration()
        {
            Console.WriteLine("--- Computer Configuration ---");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            if (!string.IsNullOrEmpty(GraphicsCard))
                Console.WriteLine($"Graphics Card: {GraphicsCard}");
            if (!string.IsNullOrEmpty(OperatingSystem))
                Console.WriteLine($"OS: {OperatingSystem}");
            Console.WriteLine($"Optical Drive: {(HasOpticalDrive ? "Yes" : "No")}");
            Console.WriteLine("----------------------------");
        }

        // Nested Builder class (common in C# for simpler builders)
        public class Builder
        {
            private readonly Computer _computer;

            public Builder()
            {
                _computer = new Computer();
            }

            public Builder WithCpu(string cpu)
            {
                _computer.CPU = cpu;
                return this;
            }

            public Builder WithRam(string ram)
            {
                _computer.RAM = ram;
                return this;
            }

            public Builder WithStorage(string storage)
            {
                _computer.Storage = storage;
                return this;
            }

            public Builder WithGraphicsCard(string graphicsCard)
            {
                _computer.GraphicsCard = graphicsCard;
                return this;
            }

            public Builder WithOperatingSystem(string os)
            {
                _computer.OperatingSystem = os;
                return this;
            }

            public Builder WithOpticalDrive()
            {
                _computer.HasOpticalDrive = true;
                return this;
            }

            public Computer Build()
            {
                // Basic validation: Ensure essential parts are set
                if (string.IsNullOrEmpty(_computer.CPU))
                    throw new InvalidOperationException("CPU is required for the computer.");
                if (string.IsNullOrEmpty(_computer.RAM))
                    throw new InvalidOperationException("RAM is required for the computer.");
                if (string.IsNullOrEmpty(_computer.Storage))
                    throw new InvalidOperationException("Storage is required for the computer.");

                return _computer;
            }
        }
    }
}
