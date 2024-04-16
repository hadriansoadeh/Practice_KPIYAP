namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, height;
            Console.Write("Введите радиус цилиндра: ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту цилиндра: ");
            height = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine($"Объем цилиндра: {volume}");
        }
    }
}