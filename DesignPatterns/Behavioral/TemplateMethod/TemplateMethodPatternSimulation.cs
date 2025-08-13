namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class TemplateMethodPatternSimulation
    {
        public void Simulate()
        {
            Console.WriteLine("--- Processing CSV Data ---");
            DataProcessor csvProcessor = new CsvDataProcessor();
            csvProcessor.ProcessData();

            Console.WriteLine();

            Console.WriteLine("--- Processing JSON Data ---");
            DataProcessor jsonProcessor = new JsonDataProcessor();
            jsonProcessor.ProcessData();
        }
    }
}
