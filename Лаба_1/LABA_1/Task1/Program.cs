using System.Threading.Channels;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            int x = int.Parse(Console.ReadLine());
            double y;

            if (x >=10)
            {
                y = 4 + x * x - (Math.Pow(Math.E,Math.Abs(x)));
                Console.WriteLine("y = " + y);

            }
            else if (x<10)
            {
                y = 3.4 - x + 0.1 * Math.Pow(x, 3);
                Console.WriteLine("y = " + y);

            }
            
        }
    }
}