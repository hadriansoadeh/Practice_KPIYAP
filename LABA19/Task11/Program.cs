/// <summary>
/// Пространство имен Task2
/// </summary>
namespace Task11
{
    /// <summary>
    /// Класс Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы
        /// </summary>
        static void Main()
        {
            // Путь к папке
            string path = @"New_folder";

            // Проверка на существование папки
            if (!Directory.Exists(path))
            {
                // Создание папки, если она не существует
                Directory.CreateDirectory(path);
                Console.WriteLine("Папка 'New_folder' успешно создана.");
            }
            else
            {
                // Сообщение, если папка уже существует
                Console.WriteLine("Папка 'New_folder' уже существует.");
            }
        }
    }
}
