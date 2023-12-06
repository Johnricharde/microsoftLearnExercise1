namespace MicrosoftLearnExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12,3", "45", "ABC", "11", "DEF" };

            string messageResult = "";
            decimal numberResult = 0;

            foreach (string value in values)
            {
                if (decimal.TryParse(value, out decimal parsedValue))
                    numberResult += parsedValue;
                else
                {
                    messageResult += value;
                }
            }

            Console.WriteLine($"Message: {messageResult}");
            Console.WriteLine($"Total: { numberResult}");
        }
    }
}

