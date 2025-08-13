namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class CsvDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from a CSV file.");
        }

        protected override void ValidateData()
        {
            Console.WriteLine("Validating CSV data format.");
        }

        protected override void TransformData()
        {
            Console.WriteLine("Transforming CSV data into a list of objects.");
        }

        protected override void SaveData()
        {
            Console.WriteLine("Saving processed data to a database table.");
        }
    }
}
