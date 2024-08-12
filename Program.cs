
using TMS_13_Serialization.Models;

namespace TMS_13_Serialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "JSON.txt");
            var json = File.ReadAllText(path);

            Models.Currency currency = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Currency>(json);
            Write(currency.ToFormatedString());

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        private static void WriteNewLine()
        {
            Console.WriteLine();
        }

        private static void Write(string value)
        {
            Console.WriteLine(value);
        }
    }

}