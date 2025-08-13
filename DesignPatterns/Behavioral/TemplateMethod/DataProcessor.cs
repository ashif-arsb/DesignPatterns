namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class DataProcessor
    {
        public void ProcessData()
        {
            Console.WriteLine("Starting data processing...");
            ReadData();
            ValidateData();
            TransformData();
            SaveData();
            Console.WriteLine("Data processing completed.");
        }

        protected abstract void ReadData();
        protected abstract void ValidateData();
        protected abstract void TransformData();
        protected abstract void SaveData();

        // A hook method can be used to provide optional behavior.
        // In this case, we won't use one, but it's good to know.
    }
}
