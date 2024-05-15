namespace Task2
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Вычисляет и выводит в консоль степени числа A: 2, 3 и 4.
        /// </summary>
        /// <param name="A">Число, степени которого нужно вычислить.</param>
        /// <param name="B">Вторая степень числа A.</param>
        /// <param name="C">Третья степень числа A.</param>
        /// <param name="D">Четвертая степень числа A.</param>
        static void PowerA234(int A, out double B, out double C, out double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
            Console.WriteLine("Число " + A + " в степени 2 равно " + B);
            Console.WriteLine("Число " + A + " в степени 3 равно " + C);
            Console.WriteLine("Число " + A + " в степени 4 равно " + D);
        }

        /// <summary>
        /// Точка входа в программу.
        /// Считывает число из консоли и вызывает метод PowerA234.
        /// </summary>
        static void Main(string[] args)
        {
            double B, C, D;
            int A = int.Parse(Console.ReadLine());
            PowerA234(A, out B, out C, out D);
        }
    }
}
