namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = Math.Pow(Math.E, 2 * 5) - Math.Pow(Math.E, Math.Sqrt(Math.Abs(1 - 5))) + (2 * Math.Pow(Math.Sin(5), 2) / Math.PI * (5 * 5));

            Console.WriteLine(y);
        }
    }
}