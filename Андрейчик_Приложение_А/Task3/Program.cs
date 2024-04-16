namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());

            double z1 = (1 - 2 * (Math.Pow(Math.Sin(a), 2))) / (1 + (Math.Sin(2 * a)));

            double z2 = (1 - (Math.Tan(a))) / (1 + (Math.Tan(a)));

            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
        }
    }
}