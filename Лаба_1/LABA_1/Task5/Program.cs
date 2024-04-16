namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число N (1<=N<=20): ");
            int N = int.Parse(Console.ReadLine());

            double sum = 0.0;
            int sign = 1;

            for (int i = 1; i <= N; i++)
            {
                sum += sign * (1.0 + i * 0.1);
                sign *= -1;
            }

            Console.WriteLine($"Результат: {sum:F4}");
        }
    }
}