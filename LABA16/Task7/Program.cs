namespace Task7
{
    class Program
    {
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

            
            var directory = Directory.CreateDirectory("D:\\Example_36tp");

           
            var sourceFiles = Directory.GetFiles("C:\\SomeOtherDirectory").Take(3);
            foreach (var sourceFile in sourceFiles)
            {
                var destinationFile = Path.Combine(directory.FullName, Path.GetFileName(sourceFile));
                File.Copy(sourceFile, destinationFile);

                
                var fileInfo = new FileInfo(destinationFile);
                fileInfo.Attributes |= FileAttributes.Hidden;

                
                File.Create(destinationFile + ".lnk");
            }
        }
    }
}
