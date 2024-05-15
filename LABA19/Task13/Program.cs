/// <summary>
/// Пространство имен для задания 4.
/// </summary>
namespace Task13
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
            // Читает все строки из файла "input.txt".
            var lines = File.ReadAllLines("input.txt");

            // Записывает все четные строки в файл "evenLines.txt".
            File.WriteAllLines("evenLines.txt", lines.Where((line, index) => index % 2 != 0));

            // Записывает все нечетные строки в файл "oddLines.txt".
            File.WriteAllLines("oddLines.txt", lines.Where((line, index) => index % 2 == 0));
        }
    }
}
