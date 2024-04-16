namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.81523;

            Console.Write("Введите высоту, с которой падает камень (в метрах): ");
            double h = Convert.ToDouble(Console.ReadLine());

            if (h >= 0)
            {
                double time = Math.Sqrt(2 * h / g);
                Console.WriteLine($"Время падения камня на поверхность земли: {time:F2} секунд");
            }
            else
            {
                Console.WriteLine("Высота не может быть отрицательной.");
            }
        }
    }
}