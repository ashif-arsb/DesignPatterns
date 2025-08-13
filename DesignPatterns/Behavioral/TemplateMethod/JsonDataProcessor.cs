namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class JsonDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("Reading data from a JSON file.");
        }

        protected override void ValidateData()
        {
            Console.WriteLine("Validating JSON data structure.");
        }

        protected override void TransformData()
        {
            Console.WriteLine("Transforming JSON data into a list of objects.");
        }

        protected override void SaveData()
        {
            Console.WriteLine("Saving processed data to an API endpoint.");
        }
    }
}
