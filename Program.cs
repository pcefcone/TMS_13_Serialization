
using TMS_13_Serialization.Models;

namespace TMS_13_Serialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "JSON.txt");
            string json = File.ReadAllText(path);

            Models.Currency currency = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Currency>(json);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Parse from JSON:");
            Console.BackgroundColor = default;
            Write(currency.ToFormatedString());
            var jsonOut = Newtonsoft.Json.JsonConvert.SerializeObject(currency);
            var pathOut = Path.Combine(Environment.CurrentDirectory, "jsonOut.txt");
            File.WriteAllText(pathOut, jsonOut);

            string path1 = ("C:\\Users\\yaros\\source\\repos\\TMS_13_Serialization\\bin\\Debug\\net8.0\\jsonOut.txt");
            using (StreamReader sr = new StreamReader(path1))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("\nParse to JSON:");
                Console.BackgroundColor = default;
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
                sr.Close();
            }

            Console.WriteLine("\nPress any key");
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