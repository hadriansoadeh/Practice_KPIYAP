namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число a1:");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число b1:");
            int b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число a2:");
            int a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число b2:");
            int b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число c2:");
            int c2 = int.Parse(Console.ReadLine());

            MinCalculator calculator = new MinCalculator();
            int result = calculator.Min(a1, b1) * calculator.Min(a2, b2, c2);

            Console.WriteLine($"Результат вычисления: {result}");
        }
    
    }
    class MinCalculator
    {
        public int Min(int a, int b)
        {
            return Math.Min(a, b);
        }

        public int Min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}