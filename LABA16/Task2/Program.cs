namespace Task2
{
    class Program
    {
        static void Main()
        {
            string path = @"New_folder";

            
            if (!Directory.Exists(path))
            {
                
                Directory.CreateDirectory(path);
                Console.WriteLine("Папка 'New_folder' успешно создана.");
            }
            else
            {
                Console.WriteLine("Папка 'New_folder' уже существует.");
            }
        }
    }
}
