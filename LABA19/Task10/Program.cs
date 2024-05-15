/// <summary>
/// Пространство имен для задания 1.
/// </summary>
namespace Task10
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Путь к файлу.
            string filePath = "f.txt";

            // Создание текстового файла и запись случайных чисел в него.
            using (StreamWriter sw = File.CreateText(filePath))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.NextDouble() * 50);
                }
            }

            // Чтение чисел из файла и преобразование их в список.
            var numbers = File.ReadAllLines(filePath).Select(double.Parse).ToList();

            // Вычисление суммы всех чисел.
            double sum = numbers.Sum();
            // Вычисление разности между первым и последним числом.
            double difference = numbers.First() - numbers.Last();

            // Вывод суммы всех чисел.
            Console.WriteLine("Сумма всех чисел: " + sum);
            // Вывод разности между первым и последним числом.
            Console.WriteLine("Разность первого и последнего числа: " + difference);
        }
    }
}
