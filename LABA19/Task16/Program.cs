/// <summary>
/// Пространство имен Task16 содержит класс Program.
/// </summary>
namespace Task16
{
    /// <summary>
    /// Класс Program выполняет операции с файлами и каталогами.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            try
            {
                // Выводим список всех файлов на локальном диске C
                var files = Directory.GetFiles("C:\\", "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Файлы на диске C:");
                foreach (var file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Нет доступа к некоторым файлам или каталогам.");
            }

            // Создаем новый каталог на диске D
            var directory = Directory.CreateDirectory("D:\\Example_36tp");

            // Копируем первые три файла из другого каталога в новый каталог
            var sourceFiles = Directory.GetFiles("C:\\SomeOtherDirectory").Take(3);
            foreach (var sourceFile in sourceFiles)
            {
                var destinationFile = Path.Combine(directory.FullName, Path.GetFileName(sourceFile));
                File.Copy(sourceFile, destinationFile);

                // Делаем файл скрытым
                var fileInfo = new FileInfo(destinationFile);
                fileInfo.Attributes |= FileAttributes.Hidden;

                // Создаем ярлык для файла
                File.Create(destinationFile + ".lnk");
            }
        }
    }
}
