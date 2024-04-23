using System.Text.RegularExpressions;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b\d{2}\.\d{2}\.\d{4}\b");
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                if (DateTime.Parse(match.Value) < DateTime.Now )
                {
                    Console.WriteLine(match.Value);
                }
                else
                {
                    Console.WriteLine( $"Неверный формат даты: {match.Value}");
                }
                
            }
        }
    }
}