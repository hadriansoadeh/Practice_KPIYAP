namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Math.PI / 4;
            double B = Math.PI / 2;
            int M = 15;

            double H = (B - A) / M;

            for (double x = A; x <= B; x += H)
            {
                double result = 2 - Math.Sin(x);
                Console.WriteLine($"F({x:F1}) = {result:F4}");
            }
        }
    }
}