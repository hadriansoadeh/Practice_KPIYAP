/// <summary>
/// Пространство имен для задачи 4.
/// </summary>
namespace Task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
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

    /// <summary>
    /// Класс для вычисления минимального значения.
    /// </summary>
    class MinCalculator
    {
        /// <summary>
        /// Возвращает минимальное из двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Минимальное значение.</returns>
        public int Min(int a, int b)
        {
            return Math.Min(a, b);
        }

        /// <summary>
        /// Возвращает минимальное из трех чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <param name="c">Третье число.</param>
        /// <returns>Минимальное значение.</returns>
        public int Min(int a, int b, int c)
        {
            return Math.Min(Math.Min(a, b), c);
        }
    }
}
