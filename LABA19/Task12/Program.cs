namespace Task12
{
    /// <summary>
    /// Класс Program содержит основную логику программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            string filePath = "file.txt";
            string newFilePath = "newFile.txt";

            // Создание файла и запись строк в него
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Первая строка");
                sw.WriteLine("Вторая строка, немного длиннее");
                sw.WriteLine("Третья строка, еще длиннее");
                sw.WriteLine("Четвертая строка, самая длинная из всех");
                sw.WriteLine("Пятая строка");
            }

            // Чтение строк из файла
            var lines = File.ReadAllLines(filePath).ToList();

            Console.WriteLine("Содержимое файла:");
            lines.ForEach(Console.WriteLine);

            Console.WriteLine("Количество строк: " + lines.Count);

            // Вывод количества символов в каждой строке
            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine("Количество символов в строке " + (i + 1) + ": " + lines[i].Length);
            }

            // Удаление последней строки и запись оставшихся строк в новый файл
            lines.RemoveAt(lines.Count - 1);
            File.WriteAllLines(newFilePath, lines);

            int s1 = 1, s2 = 3;
            Console.WriteLine("Строки с " + s1 + " по " + s2 + ":");

            // Вывод строк с s1 по s2
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }

            // Вывод длины самой длинной строки
            int maxLength = lines.Max(line => line.Length);
            Console.WriteLine("Длина самой длинной строки: " + maxLength);

            char letter = 'В';
        }
    }
}
