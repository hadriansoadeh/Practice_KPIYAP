using System.Text.RegularExpressions;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\W\d{12}");
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches) 
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}