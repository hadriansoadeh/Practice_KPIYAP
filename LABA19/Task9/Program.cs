namespace Task9
{
    /// <summary>
    /// Делегат для генерации случайного числа.
    /// </summary>
    delegate int RandomNumberDelegate();

    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            RandomNumberDelegate[] delegates = {
            new RandomNumberDelegate(() => GetRandomNumber()),
            new RandomNumberDelegate(() => GetRandomNumber()),
            new RandomNumberDelegate(() => GetRandomNumber())
        };

            Console.WriteLine($"Среднее случайных чисел: {CalculateAverage(delegates)}");
        }

        /// <summary>
        /// Генерирует случайное число от 1 до 100.
        /// </summary>
        /// <returns>Случайное число.</returns>
        static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }

        /// <summary>
        /// Вычисляет среднее значение массива случайных чисел.
        /// </summary>
        /// <param name="delegates">Массив делегатов, генерирующих случайные числа.</param>
        /// <returns>Среднее значение.</returns>
        static double CalculateAverage(params RandomNumberDelegate[] delegates)
        {
            int sum = 0;
            foreach (var del in delegates)
            {
                sum += del();
            }

            return (double)sum / delegates.Length;
        }
    }
}
